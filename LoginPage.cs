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
    public partial class frmLoginPage : Form
    {
        public frmLoginPage()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtLoginId.Text == "1" &&
               txtPassword.Text == "1")
            {
                new frmAdminPage().Show();
                Hide();
            }
            else if (txtLoginId.Text == "2" &&
                     txtPassword.Text == "2")
            {
                new frmDashboardPage().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect");
            } 
        }

    }
}
