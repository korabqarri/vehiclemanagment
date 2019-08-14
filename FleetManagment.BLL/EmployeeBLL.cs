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
    public class EmployeeBLL
    {
        private readonly EmployeeDAL _db;

        public EmployeeBLL()
        {
            _db = new EmployeeDAL();
        }

        public bool Insert(Employee employee)
        {
            return _db.Add(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _db.GetAll();
        }
    }
}
