using System;

namespace FleetManagment.BO
{
    public class Country:BaseObject
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}