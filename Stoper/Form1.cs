using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stoper
{
    public partial class Form1 : Form
    {

        private int i = 0;          //  sekundy
        private int s1 = 0;         //  minuty
        private int s2 = 0;         //  godiny
        private bool dzialanie = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            
            if (i >= 60)
            {
                i = 0;
                s1++;
            }


            if (s1 >= 60)
            {
                s1 = 0;
                s2++;
            }

            this.labSTOPER.Text = String.Format("{0:D3}:{1:D2}:{2:d2}", s2, s1, i);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            timer1.Interval = 1000;
        }

        private void butSTART_Click(object sender, EventArgs e)
        {
            if (dzialanie == false)
            {
                this.timer1.Enabled = true;
                butSTART.Text = "PAUSE";
                dzialanie = true;

            }
            else
            {
                this.timer1.Enabled = false;
                butSTART.Text = "START";
                dzialanie = false;

            }

        }

        private void butRESET_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            s2 = 0; s1 = 0; i = 0;
            labSTOPER.Text = "000:00:00";
            butSTART.Text = "START";
            dzialanie = false;
        }

        private void butKONIEC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
