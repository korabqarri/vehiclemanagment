using System;
using System.Collections.Generic;
using System.Data;
using FleetManagment.BO;
using FleetManagment.BO.Interface;
using FleetManagment.DAL.Infrastructure;
using DAO=FleetManagment.DAL.Infrastructure.DataAccessObject;

namespace FleetManagment.DAL
{
    public class EmployeeDAL:DataConnection,IDataAccessLayer<Employee>
    {
        public EmployeeDAL()
        {
            
        }

        public bool Add(Employee model)
        {
            try
            {
                using (IDbConnection connection = Connection())
                {
                    String sql = "dbo.usp_Employee_Insert";
                    using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                    {
                        DAO.AddParameter(command, "prmPersonalNo", model.PersonalNo);
                        DAO.AddParameter(command, "prmName", model.Name);
                        DAO.AddParameter(command, "prmSurname", model.Surname);
                        DAO.AddParameter(command, "prmBirthdate", model.Birthdate);
                        DAO.AddParameter(command, "prmGender", model.Gender);
                        DAO.AddParameter(command, "prmCityId", model.CityId);
                        DAO.AddParameter(command, "prmEmail", model.Email);
                        DAO.AddParameter(command, "prmPhone", model.Phone);
                        DAO.AddParameter(command, "prmMobile", model.Mobile);
                        DAO.AddParameter(command, "prmIsPasiv", model.IsPasiv);
                        DAO.AddParameter(command, "prmInsBy", model.InsertBy);



                        var result = command.ExecuteNonQuery();
                        return result >= 0;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Modify(Employee model)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Employee model)
        {
            throw new System.NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Employee Get(Employee model)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            using (IDbConnection connection = Connection())
            {
                List<Employee> users = null;
                String sql = "usp_Employee_GetAll";
                using (IDbCommand command = Command(connection, sql, CommandType.StoredProcedure))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        users = new List<Employee>();
                        while (reader.Read())
                        {
                            var user = ToObject(reader);
                            users.Add(user);
                        }
                    }

                    return users;

                }
            }
        }

        public Employee ToObject(IDataReader reader)
        {
            try
            {
                Employee emp = new Employee();
                emp.ID = (int)reader["ID"];
                if (reader["Name"] != DBNull.Value)
                    emp.Name = (string)reader["Name"];
                if (reader["Surname"] != DBNull.Value)
                    emp.Surname = (string)reader["Surname"];
                if (reader["PersonalNo"] != DBNull.Value)
                    emp.PersonalNo = (string)reader["PersonalNo"];
                if (reader["Email"] != DBNull.Value)
                    emp.Email = (string)reader["Email"];
                if (reader["Mobile"] != DBNull.Value)
                    emp.Mobile = (string)reader["Mobile"];

                if (reader["Phone"] != DBNull.Value)
                    emp.Phone = (string)reader["Phone"];

                if (reader["Birthdate"] != DBNull.Value)
                    emp.Birthdate = (DateTime)reader["Birthdate"];



                if (reader["CityId"] != DBNull.Value)
                    emp.CityId = (int)reader["CityId"];



                if (reader["Gender"] != DBNull.Value)
                    emp.Gender = char.Parse(reader["Gender"].ToString());


                if (reader["IsPasiv"] != DBNull.Value)
                    emp.IsPasiv = bool.Parse(reader["IsPasiv"].ToString());


                //if (reader["InsertBy"] != DBNull.Value)
                //    emp.InsertBy = (int)reader["InsertBy"];
                return emp;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}