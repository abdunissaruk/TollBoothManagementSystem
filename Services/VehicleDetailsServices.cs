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
        public int AddOneEntry(VehicleDetails vehicleDetails)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"INSERT INTO {nameof(VehicleDetails)} ({nameof(VehicleDetails.VehicleReg)}," +
                $"{nameof(VehicleDetails.VehicleDateTime)}, {nameof(VehicleDetails.TripType)}, " +
                $"{nameof(VehicleDetails.VehicleClass)},  {nameof(VehicleDetails.Amount)}, " +
                $"{ nameof(VehicleDetails.Returned)}) VALUES" +
                "(@vehicleReg,@vehicleDateTime,@tripType, @vehicleClass, @amount, @returned)";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@vehicleReg", vehicleDetails.VehicleReg);
            cmd.Parameters.AddWithValue("@vehicleDateTime", vehicleDetails.VehicleDateTime);
            cmd.Parameters.AddWithValue("@tripType", vehicleDetails.TripType);
            cmd.Parameters.AddWithValue("@vehicleClass", vehicleDetails.VehicleClass);
            cmd.Parameters.AddWithValue("@amount", vehicleDetails.Amount);
            cmd.Parameters.AddWithValue("@returned", vehicleDetails.Returned);
            return cmd.ExecuteNonQuery();
        }
        public IEnumerable<VehicleDetails> VehicleSearch(string vehicleReg)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT {nameof(VehicleDetails.VehicleReg)}, {nameof(VehicleDetails.VehicleDateTime)}, " +
                $"{nameof(VehicleDetails.TripType)}, {nameof(VehicleDetails.VehicleClass)}, {nameof(VehicleDetails.Amount)}, " +
                $"{nameof(VehicleDetails.Returned)} FROM {nameof(VehicleDetails)} WHERE " +
                $"{nameof(VehicleDetails.VehicleReg)}=@vehicleReg ORDER BY {nameof(VehicleDetails.VehicleDateTime)} DESC";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@vehicleReg", vehicleReg);
            var reader = cmd.ExecuteReader();

            //Stop execution if reader returns false that means no row exist
            if (reader.Read() == false)
            {
                reader.Close();
                return null;
            }

            var vehicleD = new List<VehicleDetails>();//List object
            do
            {
                var vehicleDetails = new VehicleDetails()
                {
                    VehicleReg = reader.GetString(0),
                    VehicleDateTime = reader.GetDateTime(1),
                    TripType = reader.GetString(2),
                    VehicleClass = reader.GetString(3),
                    Amount = reader.GetInt32(4),
                    Returned = reader.GetByte(5)
                };
                vehicleD.Add(vehicleDetails);//Adding obj to list
            } while (reader.Read());
            reader.Close();
            return vehicleD;//Return object list
        }
        public IEnumerable<VehicleDetails> ViewVehicleDetails(DateTime startDate, DateTime endTime )
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT {nameof(VehicleDetails.VehicleReg)}, {nameof(VehicleDetails.VehicleDateTime)}, " +
                $"{nameof(VehicleDetails.TripType)}, {nameof(VehicleDetails.VehicleClass)}, {nameof(VehicleDetails.Amount)}, " +
                $"{nameof(VehicleDetails.Returned)} FROM {nameof(VehicleDetails)} WHERE {nameof(VehicleDetails.VehicleDateTime)} " +
                $"BETWEEN @startDate AND @endTime ORDER BY {nameof(VehicleDetails.VehicleDateTime)} DESC";
            var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endTime", endTime);
            var reader = cmd.ExecuteReader();

            //Stop execution if reader returns false that means no row exist
            if (reader.Read() == false)
            {
                reader.Close();
                return null;
            }

            var vehicles = new List<VehicleDetails>();//Object list
            do
            {
                var vehicleDetails = new VehicleDetails()
                {
                    VehicleReg = reader.GetString(0),
                    VehicleDateTime = reader.GetDateTime(1),
                    TripType = reader.GetString(2),
                    VehicleClass = reader.GetString(3),
                    Amount = reader.GetInt32(4),
                    Returned = reader.GetByte(5)
                };
                vehicles.Add(vehicleDetails);//Adding object to list
            } while (reader.Read());
            reader.Close();
            return vehicles;//Return object list
        }
    }
}
