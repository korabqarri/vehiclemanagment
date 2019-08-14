using System;

namespace FleetManagment.BO
{
    public class City:BaseObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}