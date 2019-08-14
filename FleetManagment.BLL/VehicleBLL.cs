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
    public class VehicleBLL
    {
        private readonly VehicleDAL _vehicleDal;

        public VehicleBLL()
        {
            _vehicleDal = new VehicleDAL();
        }

        public bool Insert(Vehicle vehicle)
        {
            return _vehicleDal.Add(vehicle);
        }

        public bool Update(Vehicle vehicle)
        {
            return _vehicleDal.Modify(vehicle);
        }

        public bool Delete(int id)
        {
            return _vehicleDal.Remove(id);
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _vehicleDal.GetAll();
        }
    }
}
