using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniShare.DAL;
using UniShare.Helpers;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniShare.Forms
{
    public partial class BookRideForm : Form
    {
        public BookRideForm()
        {
            InitializeComponent();
        }

        private void BookRideForm1_Load(object sender, EventArgs e)
        {

        }

        private void lblPickup_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitRide_Click(object sender, EventArgs e)
        {
            string pickup = txtPickup.Text.Trim();
            string destination = txtDestination.Text.Trim();
            DateTime rideDateTime = dtpRideDate.Value.Date + dtpRideTime.Value.TimeOfDay;
            string vehicle = cmbVehicle.SelectedItem?.ToString();

            if (pickup == "" || destination == "" || vehicle == null)
            {
                lblMessage.Text = "Please fill all fields.";
                return;
            }

            try
            {
                string insertQuery = @"INSERT INTO RideRequests
                      (UserId, PickupLocation, Destination, RideDateTime, VehicleType, DistanceKm, OriginalFare, Status)
                      VALUES
                      (@UserId, @Pickup, @Destination, @RideDateTime, @VehicleType, @DistanceKm, @OriginalFare, @Status)";


                int userId = SessionManager.UserId;

                SqlParameter[] parameters =
             {
                 new SqlParameter("@UserId", userId),
                 new SqlParameter("@Pickup", pickup),
                 new SqlParameter("@Destination", destination),
                 new SqlParameter("@RideDateTime", rideDateTime),
                 new SqlParameter("@VehicleType", vehicle),
                 new SqlParameter("@DistanceKm", 8),
                 new SqlParameter("@OriginalFare", 160),
                 new SqlParameter("@Status", "Pending")
             };

                int result = DbHelper.ExecuteNonQuery(insertQuery, parameters);

                if (result > 0)
                {
                    lblMessage.ForeColor = Color.LightGreen;
                    lblMessage.Text = "Ride booked successfully!";
                }
                else
                {
                    lblMessage.Text = "Failed to book ride.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}
