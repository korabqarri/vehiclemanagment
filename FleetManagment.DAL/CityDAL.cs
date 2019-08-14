using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class CityDAL : DataConnection, IDataAccessLayer<City>
    {
        public bool Add(City model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_CityInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Name", model.Name);
                        DAO.AddParameter(command, "CountryId", model.CountryId);
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

        public bool Modify(City model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_CityUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "Name", model.Name);
                        DAO.AddParameter(command, "CountryId", model.CountryId);
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

        public bool Remove(City model)
        {
            throw new NotImplementedException();
        }

        City IDataAccessLayer<City>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public City Get(City model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<City> cities = null;
                String sql = "usp_CityGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        cities = new List<City>();
                        while (reader.Read())
                        {
                            cities.Add(ToObject(reader));
                        }
                    }

                    return cities;

                }
            }
        }

        public City ToObject(IDataReader reader)
        {
            try
            {
                City city = new City();
                city.ID = (int)reader["Id"];
                city.Name = (string)reader["Name"];
                city.CountryId = (int)reader["CountryId"];
                city.CountryName = (string)reader["CountryName"];
                return city;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        City IDataAccessLayer<City>.ToObject(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_CityDelete";
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