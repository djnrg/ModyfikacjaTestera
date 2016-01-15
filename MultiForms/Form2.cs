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
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Label label1;
        public Form1 frm1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = ((Form1)frm1).textBox1.Text;
        }
    }
}
