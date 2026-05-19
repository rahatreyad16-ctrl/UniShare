using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniShare.Helpers
{
    public static class SessionManager
    {
        public static int UserId { get; set; }
        public static string FullName { get; set; }

         public static string UserName { get; set; }
        
        public static string Email { get; set; }
        public static string Role { get; set; }
        public static bool IsAdmin { get; set; } // Add this property

        public static bool IsLoggedIn()
        {
            return UserId > 0;
        }

        public static void Logout()
        {
            UserId = 0;
            FullName = null;
            Email = null;
            Role = null;
        }
    }
}