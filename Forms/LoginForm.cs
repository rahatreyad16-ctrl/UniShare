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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");

                return;
            }

            string query = "SELECT UserId, FullName, Role FROM Users WHERE Email=@Email AND Password=@Password";
            SqlParameter[] parameters =
            {
    new SqlParameter("@Email", email),
    new SqlParameter("@Password", password)
};

            DataTable dt = DbHelper.GetDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(dt.Rows[0]["UserId"]);  
                string fullName = dt.Rows[0]["FullName"].ToString();
                string role = dt.Rows[0]["Role"].ToString();

                
                SessionManager.UserId = userId;
                SessionManager.UserName = fullName;
                SessionManager.IsAdmin = role == "Admin";

                // Open Dashboard
                DashboardForm dashboard = new DashboardForm();
                dashboard.UserEmail = fullName;  
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
            }
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();

            signup.Show();

            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
