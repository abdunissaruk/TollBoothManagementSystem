using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothManagementSystem.Model
{
    internal class Employee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string EmpEmail { get; set; }

        public string EmpMobile { get; set; }

        public string EmpPassword { get; set; }

        public Byte EmpAdminPrivelege { get; set; }
    }
}
