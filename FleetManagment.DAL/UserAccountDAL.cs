using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{

    public class UserAccountDAL : DataConnection, IDataAccessLayer<UserAccount>
    {
        public bool Add(UserAccount model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_UserAccount_Insert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "username", model.Username);
                        DAO.AddParameter(command, "password", model.Password);
                        DAO.AddParameter(command, "name", model.Name);
                        DAO.AddParameter(command, "surname", model.Surname);
                        DAO.AddParameter(command, "roleId", model.RoleId);
                        command.ExecuteNonQuery();
                        return true;

                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            
        }

        public UserAccount Get(int id)
        {

            using (IDbConnection connection = Connection())
            {
                UserAccount user = null;
                String sql = "usp_UserAccount_GetById";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    DAO.AddParameter(command, "userId", id);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = ToObject(reader);
                        }
                    }

                    return user;

                }
            }
        }

        public UserAccount Get(UserAccount model)
        {
            throw new NotImplementedException();
        }


        public UserAccount Login(string username, string password)
        {
            using (IDbConnection connection = Connection())
            {
                UserAccount user = null;
                String sql = "usp_Authenticate";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    DAO.AddParameter(command, "username", username);
                    DAO.AddParameter(command, "password", password);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = ToObject(reader);
                        }
                    }

                    return user;

                }
            }
        }
        public IEnumerable<UserAccount> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<UserAccount> users = null;
                String sql = "usp_UserAccount_GetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        users=new List<UserAccount>();
                        while (reader.Read())
                        {
                            users.Add(ToObject(reader));
                        }
                    }

                    return users;

                }
            }
        }

        public UserAccount ToObject(IDataReader reader)
        {
            try
            {
                var user = new UserAccount();
                if (reader["Id"] != DBNull.Value)
                {
                    user.ID = (int)reader["Id"];
                }

                if (reader["Username"] != DBNull.Value)
                {
                    user.Username = reader["Username"].ToString();
                }

                if (reader["Name"] != DBNull.Value)
                {
                    user.Name = reader["Name"].ToString();
                }

                if (reader["Surname"] != DBNull.Value)
                {
                    user.Surname = reader["Surname"].ToString();
                }

                if (reader["RoleId"] != DBNull.Value)
                {
                    user.RoleId = int.Parse(reader["RoleId"].ToString());
                }

                user.RoleName = reader["RoleName"].ToString();

                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Modify(UserAccount model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_UserAccount_DeleteById";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "id", id);
                        command.ExecuteNonQuery();
                        return true;

                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Remove(UserAccount model)
        {
            throw new NotImplementedException();
        }
    }
}
