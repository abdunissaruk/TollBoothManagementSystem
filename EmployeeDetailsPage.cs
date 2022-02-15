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

        private void EmployeeGridDisplay()
        {
            var employeeDetails = _service.DisplayEmployee();
            GridViewEmployeeDetailsClear();
            if (employeeDetails != null)
            {
                dataGridViewEmployeeDetails.ReadOnly = true;
                dataGridViewEmployeeDetails.DataSource = employeeDetails;
            }
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            EmployeeGridDisplay();
        }

        private void GridViewEmployeeDetailsClear()
        {
            dataGridViewEmployeeDetails.Columns.Clear();
        }

        private void Clear()
        {
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            txtEmployeeEmail.Text = "";
            txtEmployeeMobileNumber.Text = "";
            txtEmployeePassword.Text = "";
            checkBoxAdminPrivilege.Checked = false;
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
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text == "")
            {
                Clear();
                return;
            }
            var id = Convert.ToInt32(txtEmployeeId.Text);
            var employee = _service.SearchEmployee(id);
            if (employee != null)
            {
                txtEmployeeName.Text = employee.EmpName;
                txtEmployeeEmail.Text = employee.EmpEmail;
                txtEmployeeMobileNumber.Text = employee.EmpMobile;
                txtEmployeePassword.Text = employee.EmpPassword;
                if (employee.EmpAdminPrivelege == 1)
                    checkBoxAdminPrivilege.Checked = true;
                if (employee.EmpAdminPrivelege == 0)
                    checkBoxAdminPrivilege.Checked = false;
            }
            else
                MessageBox.Show("No result found");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text == "")
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
                GridViewEmployeeDetailsClear();
                EmployeeGridDisplay();
            }
            else
            {
                var id = Convert.ToInt32(txtEmployeeId.Text);
                var employeeCheck = _service.SearchEmployee(id);
                if (employeeCheck == null)
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
                    GridViewEmployeeDetailsClear();
                    EmployeeGridDisplay();
                }
                else
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
                    var res = _service.UpdateEmployee(id, employee);
                    if (res > 0)
                        MessageBox.Show("Updated");
                    GridViewEmployeeDetailsClear();
                    EmployeeGridDisplay();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text == "")
            {
                Clear();
                return;
            }
            var id = Convert.ToInt32(txtEmployeeId.Text);
            var employeeCheck = _service.DeleteEmployee(id);
            if (employeeCheck > 0)
            {
                MessageBox.Show("Employee details Deleted");
                GridViewEmployeeDetailsClear();
                EmployeeGridDisplay();
            }
            else
                MessageBox.Show("Employee details not found");
        }
    }
}
