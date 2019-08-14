using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO=FleetManagment.DAL.Infrastructure.DataAccessObject;
namespace FleetManagment.DAL
{
    public class RoleDAL:DataConnection,IDataAccessLayer<Role>
    {
        public bool Add(Role model)
        {
            throw new System.NotImplementedException();
        }

        public bool Modify(Role model)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Role model)
        {
            throw new System.NotImplementedException();
        }

        public Role Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Role Get(Role model)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Role> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<Role> users = null;
                string sql = "usp_Role_GetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        users = new List<Role>();
                        while (reader.Read())
                        {
                            users.Add(ToObject(reader));
                        }
                    }

                    return users;

                }
            }
        }

        public Role ToObject(IDataReader reader)
        {
            Role role = new Role();
            role.ID = (int) reader["ID"];
            role.Name = reader["Name"].ToString();
            return role;
        }
    }
}