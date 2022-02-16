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
        public static string loggedUser = "";
        public frmLoginPage()
        {
            InitializeComponent();
            _service = new EmployeeServices();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = txtLoginId.Text;
            var password = txtPassword.Text;

            //checking user enterd or not username and password 
            if (username == ""|| password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            var employeeLog = _service.EmployeeLogin(username, password);

            //checking user enterd username and password exist in the employee database 
            if (employeeLog == null)
            {
                MessageBox.Show("Incorrect username or passowrd");
                return;
            }

            //providing admin privelege
            if (employeeLog.EmpAdminPrivelege == 1)
            {
                loggedUser = employeeLog.EmpName;
                new frmAdminPage().Show();
                Hide();
            }
            else if (employeeLog.EmpAdminPrivelege == 0)
            {
                loggedUser = employeeLog.EmpName;
                new frmDashboardPage().Show();
                Hide();
            }

        }
    }
}
