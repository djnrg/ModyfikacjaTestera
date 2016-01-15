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
    public partial class Form1 : Form
    {

        private bool daneZmienne = false;

        public Form1()
        {
            InitializeComponent();
            new Form2().Show();
        }

        private void osobyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.osobyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adresyDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'adresyDataSet.Osoby' . Możesz go przenieść lub usunąć.
            this.osobyTableAdapter.Fill(this.adresyDataSet.Osoby);
            daneZmienne = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.osobyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adresyDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            daneZmienne = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!daneZmienne) return;
                
            switch(MessageBox.Show("Czy zapisac zmiany", "baza", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Cancel:
                    e.Cancel=true;
                    break;
                
                case DialogResult.Yes:
                try
                {
                    this.Validate();
                    this.osobyBindingSource.EndEdit();
                    this.osobyTableAdapter.Update(adresyDataSet.Osoby);

                }
                catch
                {
                    MessageBox.Show("Zapisuywanie nieudane!!!");
                }
                break;
                
                case DialogResult.No:
                break;
            }
        }
    }
}
