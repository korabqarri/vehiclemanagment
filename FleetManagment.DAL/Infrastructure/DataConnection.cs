using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FleetManagment.DAL.Infrastructure
{
    public class DataConnection
    {
        public string ConnectionString => ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        #region DataConnection
        public IDbConnection Connection()
        {

            IDbConnection sqlConnection = new SqlConnection(ConnectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw;
            }
            return sqlConnection;
        }

        public IDbConnection Connection(SqlConnection _sqlConnection)
        {

            IDbConnection sqlConnection = _sqlConnection;
            return sqlConnection;
        }


        public IDbCommand Command()
        {
            return Command(null, null, CommandType.Text);
        }

        public IDbCommand Command(IDbConnection connection, string commandText)
        {
            return Command(connection, commandText, CommandType.Text);
        }

        public IDbCommand Command(IDbConnection connection, string commandText, CommandType commandType)
        {
            IDbCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = commandType;
            command.CommandText = commandText;
            return command;
        }

        #endregion
    }
}