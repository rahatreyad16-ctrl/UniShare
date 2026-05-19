using UniShare.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using UniShare.Helpers;

namespace UniShare.DAL
{
    public class UserDAL
    {
        public bool Signup(string fullName, string universityId, string email, string phone, string password)
        {
            string query = @"INSERT INTO Users 
                            (FullName, UniversityId, Email, Phone, Password, Role)
                            VALUES
                            (@FullName, @UniversityId, @Email, @Phone, @Password, 'User')";

            SqlParameter[] parameters =
            {
                new SqlParameter("@FullName", fullName),
                new SqlParameter("@UniversityId", universityId),
                new SqlParameter("@Email", email),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Password", password)
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Login(string email, string password)
        {
            string query = @"SELECT UserId, FullName, Email, Role 
                             FROM Users 
                             WHERE Email=@Email AND Password=@Password AND IsActive=1";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password)
            };

            DataTable dt = DbHelper.GetDataTable(query, parameters);

            if (dt.Rows.Count == 1)
            {
                SessionManager.UserId = (int)dt.Rows[0]["UserId"];
                SessionManager.FullName = dt.Rows[0]["FullName"].ToString();
                SessionManager.Email = dt.Rows[0]["Email"].ToString();
                SessionManager.Role = dt.Rows[0]["Role"].ToString();

                return true;
            }

            return false;
        }

        public DataTable GetAllUsers()
        {
            string query = @"SELECT UserId, FullName, UniversityId, Email, Phone, Role, TrustScore, ReliabilityScore, CreatedAt 
                             FROM Users";
            return DbHelper.GetDataTable(query);
        }
    }
}
