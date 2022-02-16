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

            if (employee == null)
            {
                MessageBox.Show("No result found");
                return;
            }

            txtEmployeeName.Text = employee.EmpName;
            txtEmployeeEmail.Text = employee.EmpEmail;
            txtEmployeeMobileNumber.Text = employee.EmpMobile;
            txtEmployeePassword.Text = employee.EmpPassword;
            if (employee.EmpAdminPrivelege == 1)
                checkBoxAdminPrivilege.Checked = true;
            if (employee.EmpAdminPrivelege == 0)
                checkBoxAdminPrivilege.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "" || txtEmployeeEmail.Text == "" || txtEmployeeMobileNumber.Text == "" || txtEmployeePassword.Text == "")
            {
                MessageBox.Show("All field requred");
                return;
            }
            var email = txtEmployeeEmail.Text;
            var password = txtEmployeePassword.Text;
            var checkEmployeeExist = _service.CheckEmployeeExist(email, password);

            if (txtEmployeeId.Text == "")
            {
                if (checkEmployeeExist != null)
                {
                    MessageBox.Show("Email and Password alredy exist");
                    return;
                }
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
                    EmpAdminPrivelege = (Byte)EmpAdminPrivelegeResult
                };
                var res = _service.AddOneEmployee(employee);
                if (res > 0)
                    MessageBox.Show("Employee details added");
                GridViewEmployeeDetailsClear();
                EmployeeGridDisplay();
            }
            else
            {
                var id = Convert.ToInt32(txtEmployeeId.Text);
                var employeeIdCheck = _service.SearchEmployee(id);

                if (employeeIdCheck != null)
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
                        EmpAdminPrivelege = (Byte)EmpAdminPrivelegeResult
                    };
                    var res = _service.UpdateEmployee(id, employee);
                    if (res > 0)
                        MessageBox.Show("Employee details updated");
                    GridViewEmployeeDetailsClear();
                    EmployeeGridDisplay();
                }
                else
                {
                    MessageBox.Show("Clear Id to add new employee details");
                    return;
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

            if (employeeCheck == 0)
            {
                MessageBox.Show("Employee details not found");
            }
                
            MessageBox.Show("Employee details Deleted");
            GridViewEmployeeDetailsClear();
            EmployeeGridDisplay();
        }
    }
}
