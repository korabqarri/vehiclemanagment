using System;
using System.Collections.Generic;

namespace FleetManagment.BO
{
    public class Incident : BaseObject
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string AddressAdditional { get; set; }
        public int StationResponseId { get; set; }
        public int ReporterId { get; set; }
        public string ReporterName { get; set; }
        public string ReporterSurname { get; set; }
        public bool Emergency { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public List<Vehicle> Vehicles { get; set; }

    }
}