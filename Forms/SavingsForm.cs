using UniShare.DAL;
using UniShare.Helpers;
using System;
using System.Windows.Forms.DataVisualization.Charting;
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
    public partial class SavingsForm : Form
    {
        public SavingsForm()
        {
            InitializeComponent();

            cmbView.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Get current user ID from SessionManager
            int userId = SessionManager.UserId;

            // SQL query to calculate savings
            string query = "";

            // Check if Daily or Monthly view
            if (cmbView.SelectedItem.ToString() == "Daily")
            {
                query = @"
        SELECT CAST(JoinedAt AS DATE) AS RideDate,
               SUM(Rides.OriginalFare - GroupMembers.SharedFare) AS SavedAmount
        FROM GroupMembers
        INNER JOIN Rides ON GroupMembers.RideRequestId = Rides.RideRequestId
        WHERE GroupMembers.UserId = @UserId
        GROUP BY CAST(JoinedAt AS DATE)
        ORDER BY RideDate";
            }
            else // Monthly view
            {
                query = @"
        SELECT FORMAT(JoinedAt,'yyyy-MM') AS Month,
               SUM(Rides.OriginalFare - GroupMembers.SharedFare) AS SavedAmount
        FROM GroupMembers
        INNER JOIN Rides ON GroupMembers.RideRequestId = Rides.RideRequestId
        WHERE GroupMembers.UserId = @UserId
        GROUP BY FORMAT(JoinedAt,'yyyy-MM')
        ORDER BY Month";
            }

            // Parameters for SQL
            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };

            // Get DataTable
            DataTable dt = DbHelper.GetDataTable(query, parameters);

            // Bind data to chart
            chartSavings.Series.Clear();
            chartSavings.ChartAreas.Clear();
            chartSavings.ChartAreas.Add("Default");

            var series = chartSavings.Series.Add("SavedAmount");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.XValueMember = dt.Columns[0].ColumnName; // RideDate or Month
            series.YValueMembers = dt.Columns[1].ColumnName;

            chartSavings.DataSource = dt;
            chartSavings.DataBind();

            chartSavings.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartSavings.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chartSavings.Series[0].Color = Color.LightGreen;
            chartSavings.ChartAreas[0].BackColor = Color.FromArgb(24, 24, 36);
            chartSavings.BackColor = Color.FromArgb(24, 24, 36);
        }

        private void chartSavings_Click(object sender, EventArgs e)
        {

        }

        private void SavingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
