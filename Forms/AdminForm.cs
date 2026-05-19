using UniShare.DAL;
using UniShare.Helpers; // Add this using for SessionManager
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
    public partial class AdminForm : Form
    {
        
        AdminDAL adminDAL = new AdminDAL();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Restrict access to admin only
            if (!SessionManager.IsAdmin)
            {
                MessageBox.Show("Access denied. Admins only.");
                this.Close();
                return;
            }

            lblTitle.Text = "Admin Panel";

            // Style each DataGridView
            StyleGrid(dgvUsers);
            StyleGrid(dgvRideRequests);
            StyleGrid(dgvRideGroups);
            StyleGrid(dgvPopularRoutes);

            // Load data
            LoadAdminData();
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(28, 28, 42);
            dgv.BorderStyle = BorderStyle.None;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 55);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(24, 24, 36);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 87, 137);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Dock = DockStyle.Fill; // fill the tab page
        }

        private void LoadAdminData()
        {
            try
            {
                dgvUsers.DataSource = adminDAL.GetAllUsers();
                dgvRideRequests.DataSource = adminDAL.GetAllRideRequests();
                dgvRideGroups.DataSource = adminDAL.GetAllRideGroups();
                dgvPopularRoutes.DataSource = adminDAL.GetPopularRoutes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin data: " + ex.Message);
            }
        }
    }
}
