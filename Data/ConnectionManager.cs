using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothManagementSystem.Data
{
    internal static class ConnectionManager
    {
        static string _connectionString = @"Server=AKHIL;Database=TollboothManagementSystem;Integrated Security=true";
        public static readonly SqlConnection Connection;

        static ConnectionManager()
        {
            Connection = new SqlConnection(_connectionString);
        }

        public static void EnsureConnectionIsActive()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }
    }
}
