using System.Collections.Generic;
using FleetManagment.BO;
using FleetManagment.DAL;

namespace FleetManagment.BLL
{
    public class RoleBLL
    {
        private readonly RoleDAL _roleRepository;

        public RoleBLL()
        {
            _roleRepository= new RoleDAL();
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }
    }
}