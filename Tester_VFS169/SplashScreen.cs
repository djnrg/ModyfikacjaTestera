using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tester_VFS169
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hide();
            timerSplashScreen.Enabled = false;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timerSplashScreen.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
