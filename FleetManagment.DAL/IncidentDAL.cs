using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class IncidentDAL : DataConnection, IDataAccessLayer<Incident>
    {
        public bool Add(Incident model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_IncidentInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Time", model.Time);
                        DAO.AddParameter(command, "Description", model.Description);
                        DAO.AddParameter(command, "Address", model.Address);
                        DAO.AddParameter(command, "AddressAdditional", model.AddressAdditional);
                        DAO.AddParameter(command, "StationResponseId", model.StationResponseId);
                        DAO.AddParameter(command, "ReporterId", model.ReporterId);
                        DAO.AddParameter(command, "Emergency", model.Emergency);
                        DAO.AddParameter(command, "Latitude", model.Latitude);
                        DAO.AddParameter(command, "Longitude", model.Longitude);

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

        public bool Modify(Incident model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_IncidentUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "Time", model.Time);
                        DAO.AddParameter(command, "Description", model.Description);
                        DAO.AddParameter(command, "Address", model.Address);
                        DAO.AddParameter(command, "AddressAdditional", model.AddressAdditional);
                        DAO.AddParameter(command, "StationResponseId", model.StationResponseId);
                        DAO.AddParameter(command, "ReporterId", model.ReporterId);
                        DAO.AddParameter(command, "Emergency", model.Emergency);
                        DAO.AddParameter(command, "Latitude", model.Latitude);
                        DAO.AddParameter(command, "Longitude", model.Longitude);

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

        public bool Remove(Incident model)
        {
            throw new NotImplementedException();
        }

        Incident IDataAccessLayer<Incident>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public Incident Get(Incident model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Incident> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<Incident> incidents = null;
                String sql = "usp_IncidentGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        incidents = new List<Incident>();
                        while (reader.Read())
                        {
                            incidents.Add(ToObject(reader));
                        }
                    }

                    return incidents;

                }
            }
        }

        public Incident ToObject(IDataReader reader)
        {
            try
            {
                Incident incident = new Incident();
                incident.ID = (int)reader["Id"];
                incident.Time = (DateTime)reader["Time"];
                incident.Description = (string)reader["Description"];
                incident.Address = (string)reader["Address"];
                incident.AddressAdditional = (string)reader["AddressAdditional"];
                incident.StationResponseId = (int)reader["StationResponseId"];
                incident.ReporterId = (int)reader["ReporterId"];
                incident.ReporterName = (string)reader["ReporterName"];
                incident.ReporterSurname = (string)reader["ReporterSurname"];
                incident.Emergency = (bool)reader["Emergency"];
                incident.Latitude = (string)reader["Latitude"];
                incident.Longitude = (string)reader["Longitude"];

                return incident;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        Incident IDataAccessLayer<Incident>.ToObject(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_IncidentDelete";
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