using System;

namespace FleetManagment.BO
{
    public class Response:BaseObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Emergency { get; set; }
    }
}