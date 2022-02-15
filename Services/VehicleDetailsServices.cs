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
        public IEnumerable<VehicleDetails> ViewVehicleDetails(DateTime startDate, DateTime endTime )
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT {nameof(VehicleDetails.VehicleReg)}, {nameof(VehicleDetails.VehicleDateTime)}, {nameof(VehicleDetails.TripType)}, {nameof(VehicleDetails.VehicleClass)}, {nameof(VehicleDetails.Amount)} FROM {nameof(VehicleDetails)} WHERE {nameof(VehicleDetails.VehicleDateTime)} BETWEEN @startDate AND @endTime";
            var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endTime", endTime);
            var reader = cmd.ExecuteReader();
            
            //checking enrty exist 
            if (reader.Read() == false)
            {
                reader.Close();
                return null;
            }

            var vehicles = new List<VehicleDetails>();
            do
            {
                var vehicleDetails = new VehicleDetails()
                {
                    VehicleReg = reader.GetString(0),
                    VehicleDateTime = reader.GetDateTime(1),
                    TripType = reader.GetBoolean(2),
                    VehicleClass = reader.GetString(3),
                    Amount = reader.GetInt32(4)
                };
                vehicles.Add(vehicleDetails);
            } while (reader.Read());
            reader.Close();
            return vehicles;
        }
    }
}
