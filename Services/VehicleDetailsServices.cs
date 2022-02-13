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

        public int AddOneEmployee(Employee employee)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"INSERT INTO{nameof(Employee)} ({nameof(Employee.EmpName)},{nameof(Employee.EmpEmail)},{nameof(Employee.EmpMobile)},{nameof(Employee.EmpPassword)},{nameof(Employee.EmpAdminPrivelege)}) VALUES" +
                "(@name,@email,@mobile,@password,@adminPrivelage)";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@name", employee.EmpName);
            cmd.Parameters.AddWithValue("@email", employee.EmpEmail);
            cmd.Parameters.AddWithValue("@mobile", employee.EmpMobile);
            cmd.Parameters.AddWithValue("@password", employee.EmpPassword);
            cmd.Parameters.AddWithValue("@adminPrivelage", employee.EmpAdminPrivelege);
            return cmd.ExecuteNonQuery();

        }
    }
}
