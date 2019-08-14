using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO = FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class CountryDAL : DataConnection, IDataAccessLayer<Country>
    {
        public bool Add(Country model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_CountryInsert";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Name", model.Name);
                        DAO.AddParameter(command, "Code", model.Code);
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

        public bool Modify(Country model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_CountryUpdate";
                    using (IDbCommand command = Command(connection, sqlCommandText, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "Id", model.ID);
                        DAO.AddParameter(command, "Code", model.Code);
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

        public bool Remove(Country model)
        {
            throw new NotImplementedException();
        }

        Country IDataAccessLayer<Country>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public Country Get(Country model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<Country> countries = null;
                String sql = "usp_CountryGetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        countries = new List<Country>();
                        while (reader.Read())
                        {
                            countries.Add(ToObject(reader));
                        }
                    }

                    return countries;

                }
            }
        }

        public Country ToObject(IDataReader reader)
        {
            try
            {
                Country country = new Country();
                country.ID = (int)reader["Id"];
                country.Name = (string)reader["Name"];
                country.Code = (string)reader["Code"];
                return country;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        Country IDataAccessLayer<Country>.ToObject(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    string sqlCommandText = "usp_CountryDelete";
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