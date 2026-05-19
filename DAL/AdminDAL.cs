using UniShare.DAL;
using System.Data;

namespace UniShare.DAL
{
    public class AdminDAL
    {
        public DataTable GetAllUsers()
        {
            string query = @"SELECT UserId, FullName, UniversityId, Email, Phone, Role, TrustScore, ReliabilityScore, CreatedAt
                             FROM Users";
            return DbHelper.GetDataTable(query);
        }

        public DataTable GetAllRideRequests()
        {
            string query = @"SELECT rr.RideRequestId, u.FullName, rr.PickupLocation, rr.Destination,
                                    rr.RideDateTime, rr.VehicleType, rr.OriginalFare, rr.Status
                             FROM Rides rr
                             INNER JOIN Users u ON rr.UserId = u.UserId
                             ORDER BY rr.RideDateTime DESC";
            return DbHelper.GetDataTable(query);
        }

        public DataTable GetAllRideGroups()
        {
            string query = @"SELECT GroupId, PickupArea, Destination, VehicleType, RideDateTime,
                                    TotalFare, MaxSeats, CurrentSeats, Status
                             FROM RideGroups
                             ORDER BY RideDateTime DESC";
            return DbHelper.GetDataTable(query);
        }

        public DataTable GetPopularRoutes()
        {
            string query = @"SELECT PickupLocation, Destination, COUNT(*) AS TotalRequests
                             FROM Rides
                             GROUP BY PickupLocation, Destination
                             ORDER BY TotalRequests DESC";
            return DbHelper.GetDataTable(query);
        }

        public DataTable GetDashboardStats()
        {
            string query = @"
                SELECT 
                    (SELECT COUNT(*) FROM Users) AS TotalUsers,
                    (SELECT COUNT(*) FROM Rides) AS TotalRequests,
                    (SELECT COUNT(*) FROM RideGroups) AS TotalGroups,
                    (SELECT COUNT(*) FROM RideGroups WHERE Status='Open') AS ActiveGroups";
            return DbHelper.GetDataTable(query);
        }
    }
}