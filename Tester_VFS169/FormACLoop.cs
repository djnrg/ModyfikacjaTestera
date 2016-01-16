using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Tester_VFS169
{
    public partial class FormACLoop : Form
    {
        
        public FormACLoop()
        {
            InitializeComponent();
            
        }



        private void FormACLoop_Load(object sender, EventArgs e)
        {
            labelDATA.Text = DateTime.Now.ToShortDateString();

            TBAirIn.Text = "20,4";



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTopA.Checked == true)
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
