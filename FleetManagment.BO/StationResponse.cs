using System;

namespace FleetManagment.BO
{
    public class StationResponse : BaseObject
    {
        public int ID { get; set; }
        public int ResponseId { get; set; }
        public int StationId { get; set; }
        public int NumberOfVehicles { get; set; }
        public int VehicleTypeId { get; set; }

        public string ResponseName { get; set; }
        public string StationName { get; set; }
        public string VehicleTypeName { get; set; }

        public Response Response {get; set; }
        public Station Station { get; set; }
        public VehicleType VehicleType { get; set; }

    }
}