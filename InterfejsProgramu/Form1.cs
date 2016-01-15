using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfejsProgramu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formCom = new Form2();
            formCom.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formCom2 = new Form2();
            formCom2.Close();
        }

        private void knob1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            gauge1.Value = knob1.Value;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
