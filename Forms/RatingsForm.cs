using System;
using System.Data;
using System.Windows.Forms;
using UniShare.DAL;     
using UniShare.Helpers; 

namespace UniShare.Forms
{
    public partial class RatingsForm : Form
    {

        RatingDAL ratingDAL = new RatingDAL(); 

        public RatingsForm()
        {
            InitializeComponent();
        }

        private void LoadCoRiders()
        {
            try
            {
                DataTable dt = ratingDAL.GetMyCoRiders(SessionManager.UserId);
                dgvCoRiders.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No co-riders found. Join a ride group first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading co-riders: " + ex.Message);
            }
        }

        private void RatingsForm_Load(object sender, EventArgs e)
        {
            cmbStars.Items.Clear();
            for (int i = 1; i <= 5; i++)
                cmbStars.Items.Add(i.ToString());

            cmbStars.SelectedIndex = 4; // default 5 stars

            LoadCoRiders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCoRiders();
        }

        private void btnSubmitRating_Click(object sender, EventArgs e)
        {
            if (dgvCoRiders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a co-rider.");
                return;
            }

            int ratedUserId = Convert.ToInt32(dgvCoRiders.SelectedRows[0].Cells["UserId"].Value);
            int groupId = Convert.ToInt32(dgvCoRiders.SelectedRows[0].Cells["GroupId"].Value);
            int stars = Convert.ToInt32(cmbStars.Text);
            string comment = txtComment.Text.Trim();

            bool success = ratingDAL.SubmitRating(SessionManager.UserId, ratedUserId, groupId, stars, comment);

            if (success)
            {
                MessageBox.Show("Rating submitted successfully!");
                txtComment.Clear();
                LoadCoRiders();
            }
            else
            {
                MessageBox.Show("Failed to submit rating.");
            }
        }
    }
}
