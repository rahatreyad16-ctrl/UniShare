using UniShare.DAL;
using System.Data;
using System.Data.SqlClient;

namespace UniShare.DAL
{
    public class RatingDAL
    {
        public DataTable GetMyCoRiders(int userId)
        {
            string query = @"
                SELECT DISTINCT 
                    u.UserId,
                    u.FullName,
                    u.UniversityId,
                    rg.GroupId,
                    rg.Destination,
                    rg.RideDateTime
                FROM GroupMembers gm1
                INNER JOIN GroupMembers gm2 ON gm1.GroupId = gm2.GroupId
                INNER JOIN Users u ON gm2.UserId = u.UserId
                INNER JOIN RideGroups rg ON gm1.GroupId = rg.GroupId
                WHERE gm1.UserId=@UserId
                  AND gm2.UserId<>@UserId";

            return DbHelper.GetDataTable(query, new[]
            {
                new SqlParameter("@UserId", userId)
            });
        }

        public bool SubmitRating(int ratedBy, int ratedUser, int groupId, int stars, string comment)
        {
            string query = @"INSERT INTO Ratings
                            (RatedByUserId, RatedUserId, GroupId, Stars, Comment)
                            VALUES
                            (@RatedBy, @RatedUser, @GroupId, @Stars, @Comment)";

            int result = DbHelper.ExecuteNonQuery(query, new[]
            {
                new SqlParameter("@RatedBy", ratedBy),
                new SqlParameter("@RatedUser", ratedUser),
                new SqlParameter("@GroupId", groupId),
                new SqlParameter("@Stars", stars),
                new SqlParameter("@Comment", comment)
            });

            UpdateTrustScore(ratedUser);

            return result > 0;
        }

        private void UpdateTrustScore(int userId)
        {
            string query = @"
                UPDATE Users
                SET TrustScore = 
                (
                    SELECT ISNULL(AVG(CAST(Stars AS DECIMAL(5,2))) * 20, 100)
                    FROM Ratings
                    WHERE RatedUserId=@UserId
                )
                WHERE UserId=@UserId";

            DbHelper.ExecuteNonQuery(query, new[]
            {
                new SqlParameter("@UserId", userId)
            });
        }
    }
}