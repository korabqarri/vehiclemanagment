using FleetManagment.BO;

namespace FleetManagment
{
    public class ApplicationCookie
    {
        public static UserAccount CurrentUser = null;
        public static string UserName = "";
        public static int UserId = 0;
        public static string Role = "";
    }
}