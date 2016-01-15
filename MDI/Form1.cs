using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


//Otwiera tylko jedno okno wewnątrz formy
        Form2 F2;
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (F2 == null)
            {
                F2 = new Form2();
                F2.MdiParent = this;
                F2.FormClosed += new FormClosedEventHandler(F2_FormClosed);
                F2.Show();

            }

            else
            {
                F2.Activate();
            }
        }

        void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            F2 = null;
        }



//Otwiera wiele okien w formi

        Form3 F3;
        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F3 = new Form3();
            F3.MdiParent = this;
            F3.Show();
        }
        
        
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 AB = new AboutBox1();
            //AB.ShowDialog();
            AB.Show();
        }

        private void form3CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();

            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void close3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "Form3")
                {
                    form.Close();

                }
            }
        }

        private void closeAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

         }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }


    }
}
