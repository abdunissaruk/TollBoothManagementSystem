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
            frmLoginPage.frmAdminPageObj.Show();
            frmAdminPage.frmEmployeeDetailsObj.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text == "")
            {
                MessageBox.Show("Enter id to search", "Enter id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtEmployeeId.Text);
            var employee = _service.SearchEmployee(id);

            if (employee == null)
            {
                MessageBox.Show("No result found", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("All details are required", "Fill all required details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var passwordLength = txtEmployeePassword.Text.Length;
            if (passwordLength < 4)
            {
                MessageBox.Show("The password must have atleast 4 characters long.", "Retype password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var email = txtEmployeeEmail.Text;
            var password = txtEmployeePassword.Text;
            var checkEmployeeExist = _service.CheckEmployeeExist(email, password);

            if (txtEmployeeId.Text == "")
            {
                if (checkEmployeeExist != null)
                {
                    MessageBox.Show("Email and Password alredy exist", "Already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Employee details added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridViewEmployeeDetailsClear();
                EmployeeGridDisplay();
            }
            else
            {
                var id = Convert.ToInt32(txtEmployeeId.Text);
                var employeeIdCheck = _service.SearchEmployee(id);

                if (employeeIdCheck != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to update ?","Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                        return;
                    if (dialogResult == DialogResult.Cancel)
                        return;
                    if (dialogResult == DialogResult.Yes)
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
                            MessageBox.Show("Employee details updated","Updated", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        GridViewEmployeeDetailsClear();
                        EmployeeGridDisplay();
                    }
                }
                else
                {
                    MessageBox.Show("Clear Id to add new employee details", "Clear id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text == "")
            {
                MessageBox.Show("Enter id to delete", "Enter id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtEmployeeId.Text);
            var employeeCheck = _service.DeleteEmployee(id);
            if (employeeCheck == 0)
            {
                MessageBox.Show("Employee details not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to delete ?", "Please Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
                return;
            if (dialogResult == DialogResult.Cancel)
                return;
            if (dialogResult == DialogResult.Yes)
            {
                var employeeDeleteCheck = _service.DeleteEmployee(id);
                MessageBox.Show("Employee details Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridViewEmployeeDetailsClear();
                EmployeeGridDisplay();
            }   
        }

        private void frmEmployeeDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLoginPage.frmAdminPageObj.Show();
        }
    }
}
