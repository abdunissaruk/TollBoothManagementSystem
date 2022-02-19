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

        public static frmAdminPage frmAdminPageObj;
        public static frmDashboardPage frmDashboardPageObj;
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
                MessageBox.Show("Please enter username and password", "Enter password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var employeeLog = _service.EmployeeLogin(username, password);

            //checking user enterd username and password exist in the employee database 
            if (employeeLog == null)
            {
                MessageBox.Show("Incorrect username or passowrd", "Not valid ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //providing admin privelege
            if (employeeLog.EmpAdminPrivelege == 1)
            {
                loggedUser = employeeLog.EmpName;
                frmAdminPageObj = new frmAdminPage();
                frmAdminPageObj.Show();
                frmSplashScreen.frmLoginPageObj.Hide();
            }
            else if (employeeLog.EmpAdminPrivelege == 0)
            {
                loggedUser = employeeLog.EmpName;
                frmDashboardPageObj = new frmDashboardPage();
                frmDashboardPageObj.Show();
                frmSplashScreen.frmLoginPageObj.Hide();
            }

        }

        private void frmLoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
