using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetManagment.BO;
using FleetManagment.DAL;
using FleetManagment.DAL.Infrastructure;


namespace FleetManagment.BLL
{
    public class IncidentVehicleBLL
    {
        private readonly IncidentVehicleDAL _incidentVehicleDal;

        public IncidentVehicleBLL()
        {
            _incidentVehicleDal = new IncidentVehicleDAL();
        }

        public bool Insert(IncidentVehicle incidentVehicle)
        {
            return _incidentVehicleDal.Add(incidentVehicle);
        }

        public bool Update(IncidentVehicle incidentVehicle)
        {
            return _incidentVehicleDal.Modify(incidentVehicle);
        }

        public bool Delete(int id)
        {
            return _incidentVehicleDal.Remove(id);
        }

        public IEnumerable<IncidentVehicle> GetAll()
        {
            return _incidentVehicleDal.GetAll();
        }
    }
}
