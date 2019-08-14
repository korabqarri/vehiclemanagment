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
    public class VehicleTypeBLL
    {
        private readonly VehicleTypeDAL _vehicleTypeDal;

        public VehicleTypeBLL()
        {
            _vehicleTypeDal = new VehicleTypeDAL();
        }

        public bool Insert(VehicleType vehicleType)
        {
            return _vehicleTypeDal.Add(vehicleType);
        }

        public bool Update(VehicleType vehicleType)
        {
            return _vehicleTypeDal.Modify(vehicleType);
        }

        public bool Delete(int id)
        {
            return _vehicleTypeDal.Remove(id);
        }

        public IEnumerable<VehicleType> GetAll()
        {
            return _vehicleTypeDal.GetAll();
        }
    }
}
