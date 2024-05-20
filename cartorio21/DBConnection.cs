using System;
using System.Configuration;
using System.Data.SqlClient;


namespace cartorio21
{

    public class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Cartorio21ConnectionString"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}
