using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothManagementSystem.Data;
using TollBoothManagementSystem.Model;

namespace TollBoothManagementSystem.Services
{
    internal class VehicleDetailsServices
    {
        private readonly SqlConnection _connection;
        public VehicleDetailsServices()
        {
            _connection = ConnectionManager.Connection;
        }
        public int AddOneEntry(Employee employee)
        {
            return 0;
        }
        public int SearchVehicle(Employee employee)
        {
            return 0;
        }
    }
}
