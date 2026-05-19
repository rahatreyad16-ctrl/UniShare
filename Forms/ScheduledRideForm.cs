using UniShare.DAL;
using UniShare.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniShare.Forms
{
    public partial class ScheduledRideForm : Form
    {
        RideDAL rideDAL = new RideDAL();

        public ScheduledRideForm()
        {
            InitializeComponent();
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            string pickup = txtPickup.Text.Trim();
            string destination = txtDestination.Text.Trim();
            string vehicle = cmbVehicle.Text;

            if (string.IsNullOrEmpty(pickup) || string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please enter pickup and destination.");
                return;
            }

            // Days as comma-separated
            List<string> selectedDays = new List<string>();
            if (chkMon.Checked) selectedDays.Add("Mon");
            if (chkTue.Checked) selectedDays.Add("Tue");
            if (chkWed.Checked) selectedDays.Add("Wed");
            if (chkThu.Checked) selectedDays.Add("Thu");
            if (chkFri.Checked) selectedDays.Add("Fri");
            if (chkSat.Checked) selectedDays.Add("Sat");
            if (chkSun.Checked) selectedDays.Add("Sun");

            if (selectedDays.Count == 0)
            {
                MessageBox.Show("Select at least one day.");
                return;
            }

            string days = string.Join(",", selectedDays);

            DateTime rideDateTime = dtpRideDateTime.Value;
            if (rideDateTime == null || rideDateTime == default(DateTime))
            {
                MessageBox.Show("Please select a valid ride date & time.");
                return;
            }

            try
            {
                bool success = rideDAL.SaveScheduledRide(
                    SessionManager.UserId,
                    pickup,
                    destination,
                    rideDateTime,
                    days,
                    vehicle
                );

                if (success)
                {
                    MessageBox.Show("Scheduled ride saved successfully!");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving schedule: " + ex.Message);
            }
        }

        private void ScheduledRideForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtPickup.Clear();
            txtDestination.Clear();
            chkMon.Checked = false;
            chkTue.Checked = false;
            chkWed.Checked = false;
            chkThu.Checked = false;
            chkFri.Checked = false;
            chkSat.Checked = false;
            chkSun.Checked = false;
            cmbVehicle.SelectedIndex = 0;
            dtpRideDateTime.Value = DateTime.Now; // resets the DateTimePicker
        }
    }
}
