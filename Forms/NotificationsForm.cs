using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniShare.DAL;
using UniShare.Helpers;

namespace UniShare.Forms
{
    public partial class NotificationsForm : Form
    {
        NotificationDAL notificationDAL = new NotificationDAL();
        public NotificationsForm()
        {
            InitializeComponent();
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Notifications";

            StyleGrid();

            LoadNotifications();
        }
        private void StyleGrid()
        {
            dgvNotifications.BackgroundColor = Color.FromArgb(28, 28, 42);
            dgvNotifications.BorderStyle = BorderStyle.None;

            dgvNotifications.EnableHeadersVisualStyles = false;
            dgvNotifications.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 55);
            dgvNotifications.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNotifications.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvNotifications.DefaultCellStyle.BackColor = Color.FromArgb(24, 24, 36);
            dgvNotifications.DefaultCellStyle.ForeColor = Color.White;
            dgvNotifications.DefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 87, 137);
            dgvNotifications.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvNotifications.RowHeadersVisible = false;
            dgvNotifications.ReadOnly = true;
            dgvNotifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotifications.MultiSelect = false;
            dgvNotifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadNotifications()
        {
            try
            {
                DataTable dt = notificationDAL.GetNotifications(SessionManager.UserId);

                dgvNotifications.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message);
            }
        }

        private void btnMarkRead_Click(object sender, EventArgs e)
        {
            try
            {
                notificationDAL.MarkAllAsRead(SessionManager.UserId);

                MessageBox.Show("All notifications marked as read.");

                LoadNotifications();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking notifications as read: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNotifications();
        }
    }
}
