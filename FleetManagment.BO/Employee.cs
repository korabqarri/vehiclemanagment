using System;

namespace FleetManagment.BO
{
    public class Employee:BaseObject
    {
        public int ID { get; set; }
        public string PersonalNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public char Gender { get; set; }
        public int CityId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public bool IsPasiv { get; set; }
    }
}