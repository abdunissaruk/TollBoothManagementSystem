using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TollBoothManagementSystem.Model;
using TollBoothManagementSystem.Services;


namespace TollBoothManagementSystem
{
    public partial class frmEmployeeDetails : Form
    {
        private readonly EmployeeServices _service;
        public frmEmployeeDetails()
        {
            InitializeComponent();
            _service = new EmployeeServices();
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            txtEmployeeId.Enabled = false;
            txtEmployeeName.Enabled = false;
            txtEmployeeEmail.Enabled = false;
            txtEmployeeMobileNumber.Enabled = false;
            txtEmployeePassword.Enabled = false;
            checkBoxAdminPrivilege.Enabled = false;
            btnClear.Enabled = false;
            btnSearch.Enabled = false;
            btnSubmit.Enabled = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Enabled = false;
            txtEmployeeName.Enabled = true;
            txtEmployeeEmail.Enabled = true;
            txtEmployeeMobileNumber.Enabled = true;
            txtEmployeePassword.Enabled = true;
            checkBoxAdminPrivilege.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = false;
            btnSubmit.Enabled = true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Enabled = true;
            txtEmployeeName.Enabled = true;
            txtEmployeeEmail.Enabled = true;
            txtEmployeeMobileNumber.Enabled = true;
            txtEmployeePassword.Enabled = true;
            checkBoxAdminPrivilege.Enabled = true;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;
            btnSubmit.Enabled = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Enabled = true;
            txtEmployeeName.Enabled = false;
            txtEmployeeEmail.Enabled = false;
            txtEmployeeMobileNumber.Enabled = false;
            txtEmployeePassword.Enabled = false;
            checkBoxAdminPrivilege.Enabled = false;
            btnClear.Enabled = true;
            btnSearch.Enabled = true;
            btnSubmit.Enabled = true;
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmAdminPage().Show();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            txtEmployeeEmail.Text = "";
            txtEmployeeMobileNumber.Text = "";
            txtEmployeePassword.Text = "";
            checkBoxAdminPrivilege.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var EmpAdminPrivelegeResult = 0;
            if (checkBoxAdminPrivilege.Checked)
                EmpAdminPrivelegeResult = 1;
            else
                EmpAdminPrivelegeResult = 0;
            var employee = new Employee()
            {
                EmpName = txtEmployeeName.Text,
                EmpEmail = txtEmployeeEmail.Text,
                EmpMobile = txtEmployeeMobileNumber.Text,
                EmpPassword = txtEmployeePassword.Text,
                EmpAdminPrivelege = EmpAdminPrivelegeResult
            };
            var res = _service.AddOneEmployee(employee);
            if (res > 0)
                MessageBox.Show("Added");  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtEmployeeId.Text);
            var employee = _service.SearchEmployee(id);
            txtEmployeeName.Text = employee.EmpName;
            txtEmployeeEmail.Text = employee.EmpEmail;
            txtEmployeeMobileNumber.Text = employee.EmpMobile;
            txtEmployeePassword.Text = employee.EmpPassword;
            if (employee.EmpAdminPrivelege == 1)
                checkBoxAdminPrivilege.Checked = true;
            if (employee.EmpAdminPrivelege == 0)
                checkBoxAdminPrivilege.Checked = false;
        }
    }
}
