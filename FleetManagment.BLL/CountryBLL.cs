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
    public class CountryBLL
    {
        private readonly CountryDAL _countryDal;

        public CountryBLL()
        {
            _countryDal = new CountryDAL();
        }

        public bool Insert(Country country)
        {
            return _countryDal.Add(country);
        }

        public bool Update(Country country)
        {
            return _countryDal.Modify(country);
        }

        public bool Delete(int id)
        {
            return _countryDal.Remove(id);
        }

        public IEnumerable<Country> GetAll()
        {
            return _countryDal.GetAll();
        }
    }
}
