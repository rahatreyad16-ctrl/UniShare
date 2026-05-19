using UniShare.DAL;
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
    public partial class TrackingForm : Form
    {

        int progress = 0;

        private int rideRequestId; // store selected ride

        public TrackingForm(int rideId) // constructor
        {
            InitializeComponent();
            rideRequestId = rideId;
        }
        public TrackingForm()
        {
            InitializeComponent();
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {
            // Initialize UI controls for tracking
            try
            {
                progress = 0;
                progressBarRide.Minimum = 0;
                progressBarRide.Maximum = 100;
                progressBarRide.Value = 0;

                lblStatus.Text = "Ride not started";
                lblETA.Text = "ETA: --";
                btnStartRide.Text = "Start Ride";

                // Load ride info from DB only if a ride id was provided
                if (rideRequestId > 0)
                {
                    string query = "SELECT PickupLocation, Destination FROM Rides WHERE RideRequestId=@RideId";
                    SqlParameter[] parameters = { new SqlParameter("@RideId", rideRequestId) };
                    DataTable dt = DbHelper.GetDataTable(query, parameters);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        string pickup = dt.Rows[0]["PickupLocation"]?.ToString() ?? "Unknown";
                        string dest = dt.Rows[0]["Destination"]?.ToString() ?? "Unknown";
                        lblStatus.Text = $"Tracking ride from {pickup} to {dest}";
                    }
                }
            }
            catch (Exception ex)
            {
                // Keep the UI responsive and show minimal info on error
                MessageBox.Show("Failed to load ride information: " + ex.Message);
            }
        }

        private void timerRide_Tick(object sender, EventArgs e)
        {
            try
            {
                // Advance progress in stable increments and update UI
                if (progress < 100)
                {
                    progress = Math.Min(100, progress + 5); // increase 5% per tick
                    progressBarRide.Value = progress;
                    lblStatus.Text = $"Ride in progress... {progress}%";

                    int etaTicks = (100 - progress) / 5;
                    lblETA.Text = $"ETA: {etaTicks * (timerRide.Interval / 1000.0):0.#}s";
                }

                if (progress >= 100)
                {
                    progress = 100;
                    timerRide.Stop();
                    progressBarRide.Value = 100;
                    lblStatus.Text = "Ride Completed!";
                    lblETA.Text = "ETA: 0s";
                    MessageBox.Show("You have reached your destination!");
                }
            }
            catch (Exception ex)
            {
                timerRide.Stop();
                MessageBox.Show("An error occurred while tracking the ride: " + ex.Message);
            }
        }

        private void btnStartRide_Click(object sender, EventArgs e)
        {
            // Toggle start/pause. When starting from zero, reset progress.
            if (!timerRide.Enabled)
            {
                if (progress <= 0)
                {
                    progress = 0;
                    progressBarRide.Value = 0;
                }
                lblStatus.Text = "Ride started...";
                btnStartRide.Text = "Pause Ride";
                timerRide.Start();
            }
            else
            {
                timerRide.Stop();
                btnStartRide.Text = "Start Ride";
                lblStatus.Text = $"Ride paused... {progress}%";
            }
        }
    }
}
