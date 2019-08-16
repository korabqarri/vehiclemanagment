using System;

namespace FleetManagment.BO
{
    public class Vehicle:BaseObject
    {
        public int ID { get; set; }
        public int StationId { get; set; }
        public int VehicleTypeId { get; set; }
        public string LicensePlate { get; set; }
        public string LastPosition { get; set; }
        public string VehicleTypeName { get; set; }
        public string StationName { get; set; }
        public bool IsAvailable { get; set; }

        public Station Station { get; set; }
        public VehicleType VehicleType { get; set; }

    }
}