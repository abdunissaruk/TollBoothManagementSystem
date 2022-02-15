using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TollBoothManagementSystem.Services;

namespace TollBoothManagementSystem
{
    public partial class frmLoginPage : Form
    {
        private readonly EmployeeServices _service;
        public static string loggedUser="";
        public frmLoginPage()
        {
            InitializeComponent();
            _service = new EmployeeServices();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var Username = txtLoginId.Text;
            var Password = txtPassword.Text;
            var employee = _service.EmployeeLogin(Username, Password);
            if (employee.EmpAdminPrivelege == 1)
            {
                loggedUser = employee.EmpName;
                new frmAdminPage().Show();
                Hide();

            }
            else if (employee.EmpAdminPrivelege == 0)
            {
                loggedUser = employee.EmpName;
                new frmDashboardPage().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Entry");
            }
        }
    }
}
