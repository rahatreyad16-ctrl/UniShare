using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using UniShare.DAL;


namespace UniShare.Forms
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string universityId = txtUniversityId.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (fullName == "" || universityId == "" || email == "" || password == "" || confirmPassword == "")
            {
                lblMessage.Text = "Please fill all fields.";
                return;
            }

            if (password != confirmPassword)
            {
                lblMessage.Text = "Password and Confirm Password do not match.";
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                lblMessage.Text = "Please enter a valid email.";
                return;
            }

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email=@Email OR UniversityId=@UniversityId";

                SqlParameter[] checkParameters =
                {
                    new SqlParameter("@Email", email),
                    new SqlParameter("@UniversityId", universityId)
                };

                int existingUser = Convert.ToInt32(DbHelper.ExecuteScalar(checkQuery, checkParameters));

                if (existingUser > 0)
                {
                    lblMessage.Text = "Email or University ID already exists.";
                    return;
                }

                string insertQuery = @"INSERT INTO Users
                                       (FullName, UniversityId, Email, Password, Role, TrustScore, ReliabilityScore)
                                       VALUES
                                       (@FullName, @UniversityId, @Email, @Password, @Role, @TrustScore, @ReliabilityScore)";

                SqlParameter[] insertParameters =
                {
                    new SqlParameter("@FullName", fullName),
                    new SqlParameter("@UniversityId", universityId),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@Role", "Student"),
                    new SqlParameter("@TrustScore", 5),
                    new SqlParameter("@ReliabilityScore", 100)
                };

                int result = DbHelper.ExecuteNonQuery(insertQuery, insertParameters);

                if (result > 0)
                {
                    MessageBox.Show("Account created successfully. Please login now.");

                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    lblMessage.Text = "Account creation failed.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void lblBackToLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
