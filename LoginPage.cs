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
    public partial class FrmLoginPage : Form
    {
        private readonly EmployeeServices _service;

        public static string loggedUser = "";

        public static FrmAdminPage frmAdminPageObj;
        public static FrmDashboardPage frmDashboardPageObj;
        public FrmLoginPage()
        {
            InitializeComponent();
            _service = new EmployeeServices();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = txtLoginId.Text;
            var password = txtPassword.Text;

            //Checking user enterd or not username and password 
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password", "Enter password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (FrmEmployeeDetails.IsNotValidEmail(username))//Email validation
            {
                MessageBox.Show("Email format is not valid", "Email id not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 4)//Password length validation
            {
                MessageBox.Show("The password must have atleast 4 characters long.", "Retype password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var employeeLog = _service.EmployeeLogin(username, password);

            //Checking user enterd username and password exist in the employee database 
            if (employeeLog == null)
            {
                MessageBox.Show("Incorrect username or passowrd", "Not valid ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Providing admin privelege
            if (employeeLog.EmpAdminPrivelege == 1)//Navigate to admin page if have admin privilege
            {
                loggedUser = employeeLog.EmpName;//For name of current logged user
                frmAdminPageObj = new FrmAdminPage();
                frmAdminPageObj.Show();
                FrmSplashScreen.frmLoginPageObj.Hide();

            }
            else if (employeeLog.EmpAdminPrivelege == 0)//Navigate to dashboard page if doesn't have admin privilege
            {
                loggedUser = employeeLog.EmpName;//For name of current logged user
                frmDashboardPageObj = new FrmDashboardPage();
                frmDashboardPageObj.Show();
                FrmSplashScreen.frmLoginPageObj.Hide();

            }
            //Clearing username and password field after login
            txtLoginId.Text = "";
            txtPassword.Text = "";
        }

        private void FrmLoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
