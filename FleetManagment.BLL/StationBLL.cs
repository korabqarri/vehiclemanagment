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
    public class StationBLL
    {
        private readonly StationDAL _stationDal;

        public StationBLL()
        {
            _stationDal = new StationDAL();
        }

        public Station Get(int Id)
        {
            return _stationDal.Get(Id);
        }

        public bool Insert(Station station)
        {
            return _stationDal.Add(station);
        }

        public bool Update(Station station)
        {
            return _stationDal.Modify(station);
        }

        public bool Delete(int id)
        {
            return _stationDal.Remove(id);
        }

        public IEnumerable<Station> GetAll()
        {
            return _stationDal.GetAll();
        }
    }
}
