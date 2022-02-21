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
    public partial class FrmSplashScreen : Form
    {
        public static FrmLoginPage frmLoginPageObj;
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            TransparencyKey = BackColor;
        }

        private void TimerSplashScreen_Tick(object sender, EventArgs e)//Run after 3 seconds
        {
            timerSplashScreen.Stop();
            frmLoginPageObj = new FrmLoginPage();
            frmLoginPageObj.Show();
            this.Hide();
        }

        
    }
}
