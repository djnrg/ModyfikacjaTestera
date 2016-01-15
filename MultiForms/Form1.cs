using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.TextBox textBox1;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.frm1 = this;
            frm.Show();
        }
    }
}
