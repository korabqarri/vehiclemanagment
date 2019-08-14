using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class ResponseDAL : DataConnection, IDataAccessLayer<Response>
    {
        public Response Get(int id)
        {

            using (IDbConnection connection = Connection())
            {
                Response response = null;
                String sql = "usp_ResponseSelect";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    DAO.AddParameter(command, "Id", id);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response = ToObject(reader);
                        }
                    }

                    return response;

                }
            }
        }

        public bool Add(Response model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_ResponseInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Name", model.Name);
                        DAO.AddParameter(command, "Emergency", model.Emergency);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public bool Modify(Response model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_ResponseUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "Name", model.Name);
                        DAO.AddParameter(command, "Emergency", model.Emergency);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public bool Remove(Response model)
        {
            throw new NotImplementedException();
        }

        Response IDataAccessLayer<Response>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public Response Get(Response model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Response> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<Response> Responses = null;
                String sql = "usp_ResponseGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        Responses = new List<Response>();
                        while (reader.Read())
                        {
                            Responses.Add(ToObject(reader));
                        }
                    }

                    return Responses;

                }
            }
        }

        public Response ToObject(IDataReader reader)
        {
            try
            {
                Response Response = new Response();
                Response.ID = (int)reader["Id"];
                Response.Name = (string)reader["Name"];
                Response.Emergency = (bool)reader["Emergency"];
                return Response;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        Response IDataAccessLayer<Response>.ToObject(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_ResponseDelete";
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
    }
}