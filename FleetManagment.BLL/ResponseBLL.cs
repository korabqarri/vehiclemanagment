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
    public class ResponseBLL
    {
        private readonly ResponseDAL _responseDal;

        public ResponseBLL()
        {
            _responseDal = new ResponseDAL();
        }

        public Response Get(int Id)
        {
            return _responseDal.Get(Id);
        }

        public bool Insert(Response response)
        {
            return _responseDal.Add(response);
        }

        public bool Update(Response response)
        {
            return _responseDal.Modify(response);
        }

        public bool Delete(int id)
        {
            return _responseDal.Remove(id);
        }

        public IEnumerable<Response> GetAll()
        {
            return _responseDal.GetAll();
        }
    }
}
