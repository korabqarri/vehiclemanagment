using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class VehicleTypeDAL : DataConnection, IDataAccessLayer<VehicleType>
    {
        public bool Add(VehicleType model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_VehicleTypeInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "name", model.Name);
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

        public bool Modify(VehicleType model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_VehicleTypeUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "Name", model.Name);
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

        public bool Remove(VehicleType model)
        {
            throw new NotImplementedException();
        }

        VehicleType IDataAccessLayer<VehicleType>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public VehicleType Get(VehicleType model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleType> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<VehicleType> vehicleTypes = null;
                String sql = "usp_VehicleTypeGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        vehicleTypes = new List<VehicleType>();
                        while (reader.Read())
                        {
                            vehicleTypes.Add(ToObject(reader));
                        }
                    }

                    return vehicleTypes;

                }
            }
        }

        public VehicleType ToObject(IDataReader reader)
        {
            try
            {
                VehicleType vehicleType = new VehicleType();
                vehicleType.ID = (int)reader["Id"];
                vehicleType.Name = (string)reader["Name"];
                return vehicleType;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        VehicleType IDataAccessLayer<VehicleType>.ToObject(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_VehicleTypeDelete";
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