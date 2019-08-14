using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using FleetManagment.BO;
using FleetManagment.DAL;

namespace FleetManagment.BLL
{
    public class UserAccountBLL
    {
        private readonly UserAccountDAL userDal;

        public UserAccountBLL()
        {
            userDal=new UserAccountDAL();
        }
        public bool Add(UserAccount model)
        {
            return userDal.Add(model);
        }

        public IEnumerable<UserAccount> GetAll()
        {
            return userDal.GetAll();
        }
        public UserAccount Login(string username, string password)
        {
            return userDal.Login(username, password);
        }

        public bool Delete(int id)
        {
            return userDal.Remove(id);
        }
    }
}