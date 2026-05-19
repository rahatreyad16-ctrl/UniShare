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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        
          public string UserEmail { get; set; }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + UserEmail;
        }

        private void OpenChildForm(Form childForm)
        {
            panelMain.Controls.Clear();          // remove previous form
            childForm.TopLevel = false;          // make it a child
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;     // fill panel
            panelMain.Controls.Add(childForm);   // add form to panel
            panelMain.Tag = childForm;
            childForm.Show();
        }

        private void btnBookRide_Click(object sender, EventArgs e)
        {
            BookRideForm bookForm = new BookRideForm();
            OpenChildForm(bookForm);  
        }

        private void btnMatchRide_Click(object sender, EventArgs e)
        {
            MatchRideForm matchForm = new MatchRideForm();
            OpenChildForm(matchForm);
        }

        private void btnTrackRide_Click(object sender, EventArgs e)
        {
            TrackingForm trackingForm = new TrackingForm();
            OpenChildForm(trackingForm);
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            SavingsForm savingsForm = new SavingsForm();
            OpenChildForm(savingsForm);
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            RatingsForm ratingsForm = new RatingsForm();
             OpenChildForm(ratingsForm);
        }

        private void btnScheduledRides_Click(object sender, EventArgs e)
        {
            ScheduledRideForm scheduledRideForm = new ScheduledRideForm();
                        OpenChildForm(scheduledRideForm);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
              NotificationsForm notificationsForm = new NotificationsForm();
            OpenChildForm(notificationsForm);
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
