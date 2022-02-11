using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollBoothManagementSystem
{
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
