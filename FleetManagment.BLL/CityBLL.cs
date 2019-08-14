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
    public class CityBLL
    {
        private readonly CityDAL _cityDal;

        public CityBLL()
        {
            _cityDal = new CityDAL();
        }

        public bool Insert(City city)
        {
            return _cityDal.Add(city);
        }

        public bool Update(City city)
        {
            return _cityDal.Modify(city);
        }

        public bool Delete(int id)
        {
            return _cityDal.Remove(id);
        }

        public IEnumerable<City> GetAll()
        {
            return _cityDal.GetAll();
        }
    }
}
