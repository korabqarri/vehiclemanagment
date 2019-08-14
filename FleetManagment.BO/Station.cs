using System;

namespace FleetManagment.BO
{
    public class Station:BaseObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
    }
}