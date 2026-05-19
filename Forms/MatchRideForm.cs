using UniShare.DAL;
using UniShare.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniShare.Forms
{
    public partial class MatchRideForm : Form
    {
        public MatchRideForm()
        {
            InitializeComponent();
        }

        private void MatchRideForm_Load(object sender, EventArgs e)
        {
            cmbVehicleFilter.Items.Clear();
            cmbVehicleFilter.Items.AddRange(new string[] { "Bike", "CNG", "Car", "SharePool" });
            cmbVehicleFilter.SelectedIndex = 0;

            dgvMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatches.ReadOnly = true;
            dgvMatches.AllowUserToAddRows = false;
            dgvMatches.AllowUserToDeleteRows = false;
        }

        private void LoadMatches()
        {
            string pickup = txtPickupFilter.Text.Trim();
            string destination = txtDestinationFilter.Text.Trim();
            string vehicle = cmbVehicleFilter.Text;
            DateTime matchTime = dtpMatchTime.Value;

            if (pickup == "" || destination == "" || vehicle == "")
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Please fill pickup, destination and vehicle type.";
                return;
            }

            try
            {
                int currentUserId = SessionManager.UserId;

                string query = @"
SELECT 
    rr.RideRequestId,
    u.FullName AS RiderName,
    rr.PickupLocation,
    rr.Destination,
    rr.VehicleType,
    rr.RideDateTime,
    rr.OriginalFare,
    rr.Status,
    rr.Seats - ISNULL(gm.CountMembers,0) AS SeatsAvailable
FROM RideRequests rr
INNER JOIN Users u ON rr.UserId = u.UserId
LEFT JOIN (
    SELECT GroupId, COUNT(UserId) AS CountMembers
    FROM GroupMembers
    GROUP BY GroupId
) gm ON rr.RideRequestId = gm.GroupId
WHERE 
    rr.UserId <> @CurrentUserId
    AND rr.Status = 'Pending'
    AND rr.PickupLocation LIKE '%' + @Pickup + '%'
    AND rr.Destination LIKE '%' + @Destination + '%'
    AND rr.VehicleType = @VehicleType
    AND ABS(DATEDIFF(MINUTE, rr.RideDateTime, @MatchTime)) <= 15
ORDER BY rr.RideDateTime ASC";

                SqlParameter[] parameters =
                {
            new SqlParameter("@CurrentUserId", currentUserId),
            new SqlParameter("@Pickup", pickup),
            new SqlParameter("@Destination", destination),
            new SqlParameter("@VehicleType", vehicle),
            new SqlParameter("@MatchTime", matchTime)
        };

                DataTable dt = DbHelper.GetDataTable(query, parameters);

                dgvMatches.AutoGenerateColumns = true;
                dgvMatches.DataSource = dt;

                if (dgvMatches.Columns.Contains("RideRequestId"))
                {
                    dgvMatches.Columns["RideRequestId"].HeaderText = "Ride ID";
                }

                if (dgvMatches.Columns.Contains("RiderName"))
                {
                    dgvMatches.Columns["RiderName"].HeaderText = "Rider Name";
                }

                if (dgvMatches.Columns.Contains("PickupLocation"))
                {
                    dgvMatches.Columns["PickupLocation"].HeaderText = "Pickup";
                }

                if (dgvMatches.Columns.Contains("RideDateTime"))
                {
                    dgvMatches.Columns["RideDateTime"].HeaderText = "Ride Time";
                }

                if (dgvMatches.Columns.Contains("SeatsAvailable"))
                {
                    dgvMatches.Columns["SeatsAvailable"].HeaderText = "Seats Available";
                }

                if (dgvMatches.Columns.Contains("OriginalFare"))
                {
                    dgvMatches.Columns["OriginalFare"].HeaderText = "Fare";
                }

                lblMessage.ForeColor = Color.LightGreen;
                lblMessage.Text = dt.Rows.Count + " match(es) found.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void JoinSelectedRide()
        {
            if (dgvMatches.CurrentRow == null)
            {
                MessageBox.Show("Please select a ride first.");
                return;
            }

            int rideRequestId = Convert.ToInt32(dgvMatches.CurrentRow.Cells["RideRequestId"].Value);
            int currentUserId = SessionManager.UserId;

            if (currentUserId <= 0)
            {
                MessageBox.Show("User session not found. Please login again.");
                return;
            }

            try
            {
                // 1. Get selected ride request details
                string rideQuery = @"
            SELECT 
                RideRequestId,
                UserId,
                PickupLocation,
                Destination,
                VehicleType,
                RideDateTime,
                OriginalFare
            FROM RideRequests
            WHERE RideRequestId = @RideRequestId";

                SqlParameter[] rideParams =
                {
            new SqlParameter("@RideRequestId", rideRequestId)
        };

                DataTable rideDt = DbHelper.GetDataTable(rideQuery, rideParams);

                if (rideDt.Rows.Count == 0)
                {
                    MessageBox.Show("Ride request not found.");
                    return;
                }

                int rideOwnerUserId = Convert.ToInt32(rideDt.Rows[0]["UserId"]);
                string pickup = rideDt.Rows[0]["PickupLocation"].ToString();
                string destination = rideDt.Rows[0]["Destination"].ToString();
                string vehicleType = rideDt.Rows[0]["VehicleType"].ToString();
                DateTime rideDateTime = Convert.ToDateTime(rideDt.Rows[0]["RideDateTime"]);
                decimal originalFare = Convert.ToDecimal(rideDt.Rows[0]["OriginalFare"]);

                // 2. Decide max seats based on vehicle type
                int maxSeats = 4;

                if (vehicleType == "Bike")
                    maxSeats = 2;
                else if (vehicleType == "CNG")
                    maxSeats = 4;
                else if (vehicleType == "Car")
                    maxSeats = 4;
                else if (vehicleType == "SharePool")
                    maxSeats = 4;

                // 3. Check if a ride group already exists for same route/time/vehicle
                string checkGroupQuery = @"
            SELECT TOP 1 
                GroupId,
                TotalFare,
                MaxSeats,
                CurrentSeats
            FROM RideGroups
            WHERE 
                PickupArea = @PickupArea
                AND Destination = @Destination
                AND VehicleType = @VehicleType
                AND ABS(DATEDIFF(MINUTE, RideDateTime, @RideDateTime)) <= 15
                AND Status = 'Open'
            ORDER BY CreatedAt DESC";

                SqlParameter[] checkGroupParams =
                {
            new SqlParameter("@PickupArea", pickup),
            new SqlParameter("@Destination", destination),
            new SqlParameter("@VehicleType", vehicleType),
            new SqlParameter("@RideDateTime", rideDateTime)
        };

                DataTable groupDt = DbHelper.GetDataTable(checkGroupQuery, checkGroupParams);

                int groupId;
                int currentSeats;

                // 4. If group exists, use it
                if (groupDt.Rows.Count > 0)
                {
                    groupId = Convert.ToInt32(groupDt.Rows[0]["GroupId"]);
                    currentSeats = Convert.ToInt32(groupDt.Rows[0]["CurrentSeats"]);

                    if (currentSeats >= maxSeats)
                    {
                        MessageBox.Show("This ride group is already full.");
                        return;
                    }
                }
                else
                {
                    // 5. If no group exists, create new RideGroup
                    string createGroupQuery = @"
                INSERT INTO RideGroups
                (CreatedByUserId, PickupArea, Destination, VehicleType, RideDateTime, TotalFare, MaxSeats, CurrentSeats, Status)
                VALUES
                (@CreatedByUserId, @PickupArea, @Destination, @VehicleType, @RideDateTime, @TotalFare, @MaxSeats, 0, 'Open');

                SELECT SCOPE_IDENTITY();";

                    SqlParameter[] createGroupParams =
                    {
                new SqlParameter("@CreatedByUserId", rideOwnerUserId),
                new SqlParameter("@PickupArea", pickup),
                new SqlParameter("@Destination", destination),
                new SqlParameter("@VehicleType", vehicleType),
                new SqlParameter("@RideDateTime", rideDateTime),
                new SqlParameter("@TotalFare", originalFare),
                new SqlParameter("@MaxSeats", maxSeats)
            };

                    groupId = Convert.ToInt32(DbHelper.ExecuteScalar(createGroupQuery, createGroupParams));
                    currentSeats = 0;

                    // 6. Add original ride owner as first member
                    string insertOwnerQuery = @"
                INSERT INTO GroupMembers
                (GroupId, UserId, RideRequestId, SharedFare)
                VALUES
                (@GroupId, @UserId, @RideRequestId, @SharedFare)";

                    SqlParameter[] ownerParams =
                    {
                new SqlParameter("@GroupId", groupId),
                new SqlParameter("@UserId", rideOwnerUserId),
                new SqlParameter("@RideRequestId", rideRequestId),
                new SqlParameter("@SharedFare", originalFare)
            };

                    DbHelper.ExecuteNonQuery(insertOwnerQuery, ownerParams);

                    currentSeats = 1;
                }

                // 7. Check if current user already joined
                string checkMemberQuery = @"
            SELECT COUNT(*)
            FROM GroupMembers
            WHERE GroupId = @GroupId AND UserId = @UserId";

                SqlParameter[] checkMemberParams =
                {
            new SqlParameter("@GroupId", groupId),
            new SqlParameter("@UserId", currentUserId)
        };

                int alreadyJoined = Convert.ToInt32(DbHelper.ExecuteScalar(checkMemberQuery, checkMemberParams));

                if (alreadyJoined > 0)
                {
                    MessageBox.Show("You have already joined this ride group.");
                    return;
                }

                // 8. Calculate new shared fare
                int newSeatCount = currentSeats + 1;
                decimal sharedFare = originalFare / newSeatCount;

                // 9. Add current user to GroupMembers
                string insertMemberQuery = @"
            INSERT INTO GroupMembers
            (GroupId, UserId, RideRequestId, SharedFare)
            VALUES
            (@GroupId, @UserId, @RideRequestId, @SharedFare)";

                SqlParameter[] insertMemberParams =
                {
            new SqlParameter("@GroupId", groupId),
            new SqlParameter("@UserId", currentUserId),
            new SqlParameter("@RideRequestId", rideRequestId),
            new SqlParameter("@SharedFare", sharedFare)
        };

                DbHelper.ExecuteNonQuery(insertMemberQuery, insertMemberParams);

                // 10. Update all group members' shared fare
                string updateFareQuery = @"
            UPDATE GroupMembers
            SET SharedFare = @SharedFare
            WHERE GroupId = @GroupId";

                SqlParameter[] updateFareParams =
                {
            new SqlParameter("@SharedFare", sharedFare),
            new SqlParameter("@GroupId", groupId)
        };

                DbHelper.ExecuteNonQuery(updateFareQuery, updateFareParams);

                // 11. Update RideGroups seat count and status
                string updateGroupQuery = @"
            UPDATE RideGroups
            SET 
                CurrentSeats = @CurrentSeats,
                Status = CASE 
                            WHEN @CurrentSeats >= MaxSeats THEN 'Full'
                            ELSE 'Open'
                         END
            WHERE GroupId = @GroupId";

                SqlParameter[] updateGroupParams =
                {
            new SqlParameter("@CurrentSeats", newSeatCount),
            new SqlParameter("@GroupId", groupId)
        };

                DbHelper.ExecuteNonQuery(updateGroupQuery, updateGroupParams);

                // 12. Update ride request status
                string updateRequestQuery = @"
            UPDATE RideRequests
            SET Status = 'Grouped'
            WHERE RideRequestId = @RideRequestId";

                SqlParameter[] updateRequestParams =
                {
            new SqlParameter("@RideRequestId", rideRequestId)
        };

                DbHelper.ExecuteNonQuery(updateRequestQuery, updateRequestParams);

                MessageBox.Show("You joined the ride successfully!\nShared Fare: " + sharedFare.ToString("0.00") + " BDT");

                LoadMatches();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error joining ride: " + ex.Message);
            }
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadMatches();
        }

        private void btnJoinRide_Click(object sender, EventArgs e)
        {
            JoinSelectedRide();
        }

        private void btnTrackRide_Click(object sender, EventArgs e)
        {
            if (dgvMatches.CurrentRow == null)
            {
                MessageBox.Show("Please select a ride first to track.");
                return;
            }

            int rideRequestId = Convert.ToInt32(dgvMatches.CurrentRow.Cells["RideRequestId"].Value);

            TrackingForm trackForm = new TrackingForm(rideRequestId);
            trackForm.Show();
            this.Hide();


        }
    }
    
}
