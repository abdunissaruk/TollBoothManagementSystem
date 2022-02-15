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

        public frmLoginPage()
        {
            InitializeComponent();
            _service = new EmployeeServices();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = txtLoginId.Text;
            var password = txtPassword.Text;
            var employeeLog = _service.EmployeeLogin(username, password);
            if (employeeLog != null)
            {
                if (employeeLog.EmpAdminPrivelege == 1)
                {
                    new frmAdminPage().Show();
                    Hide();

                }
                else if (employeeLog.EmpAdminPrivelege == 0)
                {
                    new frmDashboardPage().Show();
                    Hide();
                }
            }
            else if(employeeLog == null)
            {
                MessageBox.Show("Incorrect Entry ");
            }
            
        }
    }
}
