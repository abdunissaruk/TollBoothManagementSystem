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
            new frmDashboard().Show();
            Hide();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {
            if (txtLoginId.Text == "admin@toll.com" &&
               txtPassword.Text == "admin")
            {
                new frmAdminPage().Show();
                Hide();
            }
            else if (txtLoginId.Text == "staff@toll.com" &&
                     txtPassword.Text == "staff")
            {
                new frmDashboard().Show();
                Hide();
            }

        }
    }
}
