using UniShare.DAL;
using UniShare.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace UniShare.DAL
{
    public class RideDAL
    {
        public int BookRide(int userId, string pickup, string destination, DateTime rideTime,
                            string vehicleType, decimal distanceKm, decimal originalFare)
        {
            string query = @"INSERT INTO RideRequests
                            (UserId, PickupLocation, Destination, RideDateTime, VehicleType, DistanceKm, OriginalFare)
                            OUTPUT INSERTED.RideRequestId
                            VALUES
                            (@UserId, @Pickup, @Destination, @RideDateTime, @VehicleType, @DistanceKm, @OriginalFare)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Pickup", pickup),
                new SqlParameter("@Destination", destination),
                new SqlParameter("@RideDateTime", rideTime),
                new SqlParameter("@VehicleType", vehicleType),
                new SqlParameter("@DistanceKm", distanceKm),
                new SqlParameter("@OriginalFare", originalFare),
                new SqlParameter("@Status", SqlDbType.NVarChar) { Value = "Pending" }

            };
           
            object result = DbHelper.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        public DataTable FindMatches(int userId, int rideRequestId)
        {
            string query = @"
                DECLARE @Pickup NVARCHAR(150), @Destination NVARCHAR(150), 
                        @RideTime DATETIME, @VehicleType NVARCHAR(20);

                SELECT 
                    @Pickup = PickupLocation,
                    @Destination = Destination,
                    @RideTime = RideDateTime,
                    @VehicleType = VehicleType
                FROM RideRequests
                WHERE RideRequestId = @RideRequestId;

                SELECT 
                    rr.RideRequestId,
                    u.FullName,
                    u.UniversityId,
                    rr.PickupLocation,
                    rr.Destination,
                    rr.RideDateTime,
                    rr.VehicleType,
                    rr.OriginalFare,
                    u.TrustScore
                FROM RideRequests rr
                INNER JOIN Users u ON rr.UserId = u.UserId
                WHERE 
                    rr.UserId <> @UserId
                    AND rr.Destination = @Destination
                    AND rr.VehicleType = @VehicleType
                    AND ABS(DATEDIFF(MINUTE, rr.RideDateTime, @RideTime)) <= 15
                    AND rr.Status = 'Pending'
                    AND (
                        rr.PickupLocation LIKE '%' + @Pickup + '%'
                        OR @Pickup LIKE '%' + rr.PickupLocation + '%'
                    )";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@RideRequestId", rideRequestId)
            };

            return DbHelper.GetDataTable(query, parameters);
        }

        public DataTable GetMyRideRequests(int userId)
        {
            string query = @"SELECT RideRequestId, PickupLocation, Destination, RideDateTime, VehicleType, OriginalFare, Status
                             FROM RideRequests
                             WHERE UserId=@UserId
                             ORDER BY RideDateTime DESC";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserId", userId)
            };


            return DbHelper.GetDataTable(query, parameters);
        }

        public int CreateGroupFromRequest(int requestId, int createdByUserId)
        {
            string selectQuery = @"SELECT PickupLocation, Destination, VehicleType, RideDateTime, OriginalFare
                                   FROM RideRequests
                                   WHERE RideRequestId=@RideRequestId";

            DataTable dt = DbHelper.GetDataTable(selectQuery, new[]
            {
                new SqlParameter("@RideRequestId", requestId)
            });

            if (dt.Rows.Count == 0)
                return 0;

            string pickup = dt.Rows[0]["PickupLocation"].ToString();
            string destination = dt.Rows[0]["Destination"].ToString();
            string vehicle = dt.Rows[0]["VehicleType"].ToString();
            DateTime rideTime = Convert.ToDateTime(dt.Rows[0]["RideDateTime"]);
            decimal fare = Convert.ToDecimal(dt.Rows[0]["OriginalFare"]);
            int maxSeats = FareCalculator.GetMaxSeats(vehicle);

            string insertGroup = @"INSERT INTO RideGroups
                                   (CreatedByUserId, PickupArea, Destination, VehicleType, RideDateTime, TotalFare, MaxSeats, CurrentSeats)
                                   OUTPUT INSERTED.GroupId
                                   VALUES
                                   (@CreatedByUserId, @PickupArea, @Destination, @VehicleType, @RideDateTime, @TotalFare, @MaxSeats, 0)";

            int groupId = Convert.ToInt32(DbHelper.ExecuteScalar(insertGroup, new[]
            {
                new SqlParameter("@CreatedByUserId", createdByUserId),
                new SqlParameter("@PickupArea", pickup),
                new SqlParameter("@Destination", destination),
                new SqlParameter("@VehicleType", vehicle),
                new SqlParameter("@RideDateTime", rideTime),
                new SqlParameter("@TotalFare", fare),
                new SqlParameter("@MaxSeats", maxSeats)
            }));

            JoinGroup(groupId, createdByUserId, requestId);

            return groupId;
        }

        public bool JoinGroup(int groupId, int userId, int rideRequestId)
        {
            string checkQuery = @"SELECT MaxSeats, CurrentSeats, TotalFare
                                  FROM RideGroups
                                  WHERE GroupId=@GroupId AND Status='Open'";

            DataTable group = DbHelper.GetDataTable(checkQuery, new[]
            {
                new SqlParameter("@GroupId", groupId)
            });

            if (group.Rows.Count == 0)
                return false;

            int maxSeats = Convert.ToInt32(group.Rows[0]["MaxSeats"]);
            int currentSeats = Convert.ToInt32(group.Rows[0]["CurrentSeats"]);
            decimal totalFare = Convert.ToDecimal(group.Rows[0]["TotalFare"]);

            if (currentSeats >= maxSeats)
                return false;

            int newSeatCount = currentSeats + 1;
            decimal sharedFare = totalFare / newSeatCount;

            string insertMember = @"INSERT INTO GroupMembers
                                    (GroupId, UserId, RideRequestId, SharedFare)
                                    VALUES
                                    (@GroupId, @UserId, @RideRequestId, @SharedFare)";

            DbHelper.ExecuteNonQuery(insertMember, new[]
            {
                new SqlParameter("@GroupId", groupId),
                new SqlParameter("@UserId", userId),
                new SqlParameter("@RideRequestId", rideRequestId),
                new SqlParameter("@SharedFare", sharedFare)
            });

            string updateMembersFare = @"UPDATE GroupMembers
                                         SET SharedFare=@SharedFare
                                         WHERE GroupId=@GroupId";

            DbHelper.ExecuteNonQuery(updateMembersFare, new[]
            {
                new SqlParameter("@SharedFare", sharedFare),
                new SqlParameter("@GroupId", groupId)
            });

            string updateGroup = @"UPDATE RideGroups
                                   SET CurrentSeats=@CurrentSeats,
                                       Status = CASE WHEN @CurrentSeats >= MaxSeats THEN 'Full' ELSE 'Open' END
                                   WHERE GroupId=@GroupId";

            DbHelper.ExecuteNonQuery(updateGroup, new[]
            {
                new SqlParameter("@CurrentSeats", newSeatCount),
                new SqlParameter("@GroupId", groupId)
            });

            string updateRequest = @"UPDATE RideRequests
                                     SET Status='Grouped'
                                     WHERE RideRequestId=@RideRequestId";

            DbHelper.ExecuteNonQuery(updateRequest, new[]
            {
                new SqlParameter("@RideRequestId", rideRequestId)
            });

            return true;
        }

        public DataTable GetOpenGroups()
        {
            string query = @"SELECT GroupId, PickupArea, Destination, VehicleType, RideDateTime,
                                    TotalFare, MaxSeats, CurrentSeats, Status
                             FROM RideGroups
                             WHERE Status='Open'
                             ORDER BY RideDateTime DESC";

            return DbHelper.GetDataTable(query);
        }

        public DataTable GetUserSavings(int userId)
        {
            string query = @"
                SELECT 
                    CONVERT(date, gm.JoinedAt) AS RideDate,
                    SUM(rr.OriginalFare - gm.SharedFare) AS Savings
                FROM GroupMembers gm
                INNER JOIN RideRequests rr ON gm.RideRequestId = rr.RideRequestId
                WHERE gm.UserId=@UserId
                GROUP BY CONVERT(date, gm.JoinedAt)
                ORDER BY RideDate";

            return DbHelper.GetDataTable(query, new[]
            {
                new SqlParameter("@UserId", userId)
            });
        }

        public bool SaveScheduledRide(int userId, string pickup, string destination, DateTime rideDateTime, string days, string vehicleType)
        {
            string query = @"
    INSERT INTO ScheduledRiderequests
    (UserId, PickupLocation, Destination, VehicleType, RideTime, DaysOfWeek, DistanceKm, OriginalFare)
    VALUES
    (@UserId, @PickupLocation, @Destination, @VehicleType, @RideTime, @DaysOfWeek, @DistanceKm, @OriginalFare)";

            SqlParameter[] parameters =
            {
        new SqlParameter("@UserId", userId),
        new SqlParameter("@PickupLocation", pickup),
        new SqlParameter("@Destination", destination),
        new SqlParameter("@VehicleType", vehicleType),
        new SqlParameter("@RideTime", rideDateTime.TimeOfDay), // only time portion
        new SqlParameter("@DaysOfWeek", days),
        new SqlParameter("@DistanceKm", 8), // adjust if dynamic
        new SqlParameter("@OriginalFare", 160) // adjust if dynamic
    };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetVehicleUsage(int userId)
        {
            string query = @"
                SELECT rr.VehicleType, COUNT(*) AS TotalRides
                FROM RideRequests rr
                WHERE rr.UserId=@UserId
                GROUP BY rr.VehicleType";

            return DbHelper.GetDataTable(query, new[]
            {
                new SqlParameter("@UserId", userId)
            });
        }
    }
}