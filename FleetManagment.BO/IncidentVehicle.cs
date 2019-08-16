using System;

namespace FleetManagment.BO
{
    public class IncidentVehicle : BaseObject
    {
        public int ID { get; set; }
        public int IncidentId { get; set; }
        public int VehicleId { get; set; }
        public DateTime Time { get; set; }
    }
}