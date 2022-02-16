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
    internal class EmployeeServices
    {
        private readonly SqlConnection _connection;
        public EmployeeServices()
        {
            _connection = ConnectionManager.Connection;
        }

        public IEnumerable<Employee> DisplayEmployee()
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT { nameof(Employee.EmpId)}, { nameof(Employee.EmpName)}, { nameof(Employee.EmpEmail)}, { nameof(Employee.EmpMobile)}, { nameof(Employee.EmpPassword)}, { nameof(Employee.EmpAdminPrivelege)} FROM {nameof(Employee)}";
            var cmd = new SqlCommand(sql, _connection);
            var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return null;
            }

            var employeeList = new List<Employee>();
            do
            {
                var employee = new Employee()
                {
                    EmpId = reader.GetInt32(0),
                    EmpName = reader.GetString(1),
                    EmpEmail = reader.GetString(2),
                    EmpMobile = reader.GetString(3),
                    EmpPassword = reader.GetString(4),
                    EmpAdminPrivelege = reader.GetByte(5)
                };
                employeeList.Add(employee);
            }
            while (reader.Read());
            reader.Close();
            return employeeList;
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
            if (reader.Read())
            {
                var employee = new Employee()
                {
                    EmpName = reader.GetString(0),
                    EmpEmail = reader.GetString(1),
                    EmpMobile = reader.GetString(2),
                    EmpPassword = reader.GetString(3),
                    EmpAdminPrivelege = reader.GetByte(4)
                };
                reader.Close();
                return employee;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public int UpdateEmployee(int id, Employee employee)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"UPDATE {nameof(Employee)} SET {nameof(Employee.EmpName)} = @name, {nameof(Employee.EmpEmail)} = @email, {nameof(Employee.EmpMobile)} = @mobile, {nameof(Employee.EmpPassword)} = @password, {nameof(Employee.EmpAdminPrivelege)} = @adminPrivelage WHERE {nameof(Employee.EmpId)} = @id";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", employee.EmpName);
            cmd.Parameters.AddWithValue("@email", employee.EmpEmail);
            cmd.Parameters.AddWithValue("@mobile", employee.EmpMobile);
            cmd.Parameters.AddWithValue("@password", employee.EmpPassword);
            cmd.Parameters.AddWithValue("@adminPrivelage", employee.EmpAdminPrivelege);
            return cmd.ExecuteNonQuery();

        }

        public int DeleteEmployee(int id)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"DELETE FROM {nameof(Employee)} WHERE EmpId=@id";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();
        }

        public Employee EmployeeLogin(String username, String password)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT  { nameof(Employee.EmpName)}, { nameof(Employee.EmpAdminPrivelege)} FROM {nameof(Employee)} WHERE EmpEmail=@email and EmpPassword=@password";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@email", username);
            cmd.Parameters.AddWithValue("@password", password);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var employee = new Employee()
                {
                    EmpName = reader.GetString(0),
                    EmpAdminPrivelege = reader.GetByte(1),
                };

                reader.Close();
                return employee;                
            }
            else
                return null;
            
        }

        public Employee CheckEmployeeExist(String email, String password)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT  * FROM {nameof(Employee)} WHERE EmpEmail=@email and EmpPassword=@password";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var employee = new Employee()
                {
                    EmpId = reader.GetInt32(0),
                    EmpName = reader.GetString(1),
                    EmpEmail = reader.GetString(2),
                    EmpMobile = reader.GetString(3),
                    EmpPassword = reader.GetString(4),
                    EmpAdminPrivelege = reader.GetByte(5)
                };
                reader.Close();
                return employee;
            }
            else
            {
                reader.Close();
                return null;
            }
        }
    }
}
