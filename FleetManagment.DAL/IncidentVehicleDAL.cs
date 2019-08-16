using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class IncidentVehicleDAL : DataConnection, IDataAccessLayer<IncidentVehicle>
    {
        public bool Add(IncidentVehicle model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_IncidentVehicleInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "IncidentId", model.IncidentId);
                        DAO.AddParameter(command, "VehicleId", model.VehicleId);
                        DAO.AddParameter(command, "Time", model.Time);
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

        public bool Modify(IncidentVehicle model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_IncidentVehicleUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "IncidentId", model.IncidentId);
                        DAO.AddParameter(command, "VehicleId", model.VehicleId);
                        DAO.AddParameter(command, "Time", model.Time);
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

        public bool Remove(IncidentVehicle model)
        {
            throw new NotImplementedException();
        }

        IncidentVehicle IDataAccessLayer<IncidentVehicle>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public IncidentVehicle Get(IncidentVehicle model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncidentVehicle> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<IncidentVehicle> incidentVehicles = null;
                String sql = "usp_IncidentVehicleGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        incidentVehicles = new List<IncidentVehicle>();
                        while (reader.Read())
                        {
                            incidentVehicles.Add(ToObject(reader));
                        }
                    }

                    return incidentVehicles;

                }
            }
        }

        public IncidentVehicle ToObject(IDataReader reader)
        {
            try
            {
                IncidentVehicle incidentVehicle = new IncidentVehicle();
                incidentVehicle.ID = (int)reader["Id"];
                incidentVehicle.IncidentId = (int)reader["IncidentId"];
                incidentVehicle.VehicleId = (int)reader["VehicleId"];
                incidentVehicle.Time = (DateTime)reader["Time"];
                return incidentVehicle;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_IncidentVehicleDelete";
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

        public IncidentVehicle Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}