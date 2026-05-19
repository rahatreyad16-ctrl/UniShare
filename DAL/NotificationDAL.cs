using UniShare.DAL;
using System.Data;
using System.Data.SqlClient;

namespace UniShare.DAL
{
    public class NotificationDAL
    {
        public void AddNotification(int userId, string title, string message, string type)
        {
            string query = @"INSERT INTO Notifications
                            (UserId, Title, Message, Type)
                            VALUES
                            (@UserId, @Title, @Message, @Type)";

            DbHelper.ExecuteNonQuery(query, new[]
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Title", title),
                new SqlParameter("@Message", message),
                new SqlParameter("@Type", type)
            });
        }

        public DataTable GetNotifications(int userId)
        {
            string query = @"SELECT NotificationId, Title, Message, Type, IsRead, CreatedAt
                             FROM Notifications
                             WHERE UserId=@UserId
                             ORDER BY CreatedAt DESC";

            return DbHelper.GetDataTable(query, new[]
            {
                new SqlParameter("@UserId", userId)
            });
        }

        public void MarkAllAsRead(int userId)
        {
            string query = @"UPDATE Notifications SET IsRead=1 WHERE UserId=@UserId";

            DbHelper.ExecuteNonQuery(query, new[]
            {
                new SqlParameter("@UserId", userId)
            });
        }
    }
}