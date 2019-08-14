using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class VehicleDAL : DataConnection, IDataAccessLayer<Vehicle>
    {
        public bool Add(Vehicle model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_VehicleInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "LicensePlate", model.LicensePlate);
                        DAO.AddParameter(command, "LastPosition", model.LastPosition);
                        DAO.AddParameter(command, "VehicleTypeId", model.VehicleTypeId);
                        DAO.AddParameter(command, "StationId", model.StationId);
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

        public bool Modify(Vehicle model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_VehicleUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "LicensePlate", model.LicensePlate);
                        DAO.AddParameter(command, "LastPosition", model.LastPosition);
                        DAO.AddParameter(command, "VehicleTypeId", model.VehicleTypeId);
                        DAO.AddParameter(command, "StationId", model.StationId);
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

        public bool Remove(Vehicle model)
        {
            throw new NotImplementedException();
        }

        Vehicle IDataAccessLayer<Vehicle>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle Get(Vehicle model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<Vehicle> cities = null;
                String sql = "usp_VehicleGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        cities = new List<Vehicle>();
                        while (reader.Read())
                        {
                            cities.Add(ToObject(reader));
                        }
                    }

                    return cities;

                }
            }
        }

        public Vehicle ToObject(IDataReader reader)
        {
            try
            {
                Vehicle vehicle = new Vehicle();
                vehicle.ID = (int)reader["Id"];
                vehicle.LicensePlate = (string)reader["LicensePlate"];
                vehicle.VehicleTypeId = (int)reader["VehicleTypeId"];
                vehicle.StationId = (int)reader["StationId"];
                vehicle.VehicleTypeName = (string)reader["VehicleTypeName"];
                vehicle.StationName = (string)reader["StationName"];
                return vehicle;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        Vehicle IDataAccessLayer<Vehicle>.ToObject(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_VehicleDelete";
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