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
    public partial class FormTemperature : Form
    {
        public FormTemperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
        }

        private void checkTopT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTopT.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

    }
}
