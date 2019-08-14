using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class StationResponseDAL : DataConnection, IDataAccessLayer<StationResponse>
    {
        public bool Add(StationResponse model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_StationResponseInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "ResponseId", model.ResponseId);
                        DAO.AddParameter(command, "StationId", model.StationId);
                        DAO.AddParameter(command, "NumberOfVehicles", model.NumberOfVehicles);
                        DAO.AddParameter(command, "VehicleTypeId", model.VehicleTypeId);
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

        public bool Modify(StationResponse model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_StationResponseUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "ResponseId", model.ResponseId);
                        DAO.AddParameter(command, "StationId", model.StationId);
                        DAO.AddParameter(command, "NumberOfVehicles", model.NumberOfVehicles);
                        DAO.AddParameter(command, "VehicleTypeId", model.VehicleTypeId);
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

        public bool Remove(StationResponse model)
        {
            throw new NotImplementedException();
        }

        StationResponse IDataAccessLayer<StationResponse>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public StationResponse Get(StationResponse model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StationResponse> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<StationResponse> stationResponses = null;
                String sql = "usp_StationResponseGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        stationResponses = new List<StationResponse>();
                        while (reader.Read())
                        {
                            stationResponses.Add(ToObject(reader));
                        }
                    }

                    return stationResponses;

                }
            }
        }

        public StationResponse ToObject(IDataReader reader)
        {
            try
            {
                StationResponse stationResponse = new StationResponse();
                stationResponse.ID = (int)reader["Id"];
                stationResponse.ResponseId = (int)reader["ResponseId"];
                stationResponse.StationId = (int)reader["StationId"];
                stationResponse.NumberOfVehicles = (int)reader["NumberOfVehicles"]; ;
                stationResponse.VehicleTypeId = (int)reader["VehicleTypeId"]; ;
                stationResponse.ResponseName = (string)reader["ResponseName"];
                stationResponse.StationName = (string)reader["StationName"];
                stationResponse.VehicleTypeName = (string)reader["VehicleTypeName"]; ;
                return stationResponse;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        StationResponse IDataAccessLayer<StationResponse>.ToObject(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_StationResponseDelete";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", id);
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