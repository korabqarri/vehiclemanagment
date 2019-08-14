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
    public class IncidentBLL
    {
        private readonly IncidentDAL _incidentDal;

        public IncidentBLL()
        {
            _incidentDal = new IncidentDAL();
        }

        public bool Insert(Incident incident)
        {
            return _incidentDal.Add(incident);
        }

        public bool Update(Incident incident)
        {
            return _incidentDal.Modify(incident);
        }

        public bool Delete(int id)
        {
            return _incidentDal.Remove(id);
        }

        public IEnumerable<Incident> GetAll()
        {
            return _incidentDal.GetAll();
        }
    }
}
