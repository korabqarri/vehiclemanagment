namespace FleetManagment.BO
{
    public class UserAccount : BaseObject
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public Role Role { get; set; }
    }
}