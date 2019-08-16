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
    public class StationResponseBLL
    {
        private readonly StationResponseDAL _stationResponseDal;

        public StationResponseBLL()
        {
            _stationResponseDal = new StationResponseDAL();
        }

        public bool Insert(StationResponse stationResponse)
        {
            return _stationResponseDal.Add(stationResponse);
        }

        public bool Update(StationResponse stationResponse)
        {
            return _stationResponseDal.Modify(stationResponse);
        }

        public bool Delete(int id)
        {
            return _stationResponseDal.Remove(id);
        }

        public IEnumerable<StationResponse> GetAll()
        {
            return _stationResponseDal.GetAll();
        }

        public IEnumerable<StationResponse> GetByStation(int stationId)
        {
            return _stationResponseDal.GetByStation(stationId);
        }
    }
}
