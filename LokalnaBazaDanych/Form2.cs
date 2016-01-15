using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LokalnaBazaDanych
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'adresyDataSet.Osoby' . Możesz go przenieść lub usunąć.
            this.osobyTableAdapter.Fill(this.adresyDataSet.Osoby);

        }
    }
}
