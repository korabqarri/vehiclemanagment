using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class StationDAL : DataConnection, IDataAccessLayer<Station>
    {
        public bool Add(Station model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_StationInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Name", model.Name);
                        DAO.AddParameter(command, "Area", model.Area);
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

        public bool Modify(Station model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_StationUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "Name", model.Name);
                        DAO.AddParameter(command, "Area", model.Area);
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

        public bool Remove(Station model)
        {
            throw new NotImplementedException();
        }

        Station IDataAccessLayer<Station>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public Station Get(Station model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Station> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<Station> stations = null;
                String sql = "usp_StationGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        stations = new List<Station>();
                        while (reader.Read())
                        {
                            stations.Add(ToObject(reader));
                        }
                    }

                    return stations;

                }
            }
        }

        public Station ToObject(IDataReader reader)
        {
            try
            {
                Station station = new Station();
                station.ID = (int)reader["Id"];
                station.Name = (string)reader["Name"];
                station.Area = (string)reader["Area"];
                return station;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        Station IDataAccessLayer<Station>.ToObject(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_StationDelete";
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

        public Station Get(int id)
        {

            using (IDbConnection connection = Connection())
            {
                Station station = null;
                String sql = "usp_StationSelect";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    DAO.AddParameter(command, "Id", id);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            station = ToObject(reader);
                        }
                    }

                    return station;

                }
            }
        }
    }
}