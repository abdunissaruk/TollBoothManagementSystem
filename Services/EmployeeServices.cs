﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothManagementSystem.Data;
using TollBoothManagementSystem.Model;

namespace TollBoothManagementSystem.Services
{
    internal class EmployeeServices
    {
        private readonly SqlConnection _connection;
        public EmployeeServices()
        {
            _connection = ConnectionManager.Connection;
        }

        public int AddOneEmployee(Employee employee)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"INSERT INTO {nameof(Employee)} ({ nameof(Employee.EmpName)}, { nameof(Employee.EmpEmail)}, { nameof(Employee.EmpMobile)}, { nameof(Employee.EmpPassword)}, { nameof(Employee.EmpAdminPrivelege)}) VALUES" +
                "(@name,@email,@mobile,@password,@adminPrivelage)";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@name", employee.EmpName);
            cmd.Parameters.AddWithValue("@email", employee.EmpEmail);
            cmd.Parameters.AddWithValue("@mobile", employee.EmpMobile);
            cmd.Parameters.AddWithValue("@password", employee.EmpPassword);
            cmd.Parameters.AddWithValue("@adminPrivelage", employee.EmpAdminPrivelege);
            return cmd.ExecuteNonQuery();
        }
        public Employee SearchEmployee(int id)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT { nameof(Employee.EmpName)}, { nameof(Employee.EmpEmail)}, { nameof(Employee.EmpMobile)}, { nameof(Employee.EmpPassword)}, { nameof(Employee.EmpAdminPrivelege)} FROM {nameof(Employee)} WHERE EmpId=@id";

            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            reader.Read();
            var employee = new Employee()
            {
                EmpName = reader.GetString(0),
                EmpEmail = reader.GetString(1),
                EmpMobile = reader.GetString(2),
                EmpPassword = reader.GetString(3),
                EmpAdminPrivelege = reader.GetInt32(4)
            };
            reader.Close();
            return employee;
        }
        public Employee EmployeeLogin(int id)
        {


            return employee;
        }
    }
}
