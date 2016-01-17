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
    public partial class FormNTD : Form
    {
        public FormNTD()
        {
            InitializeComponent();
        }

        private void testDescriptionSetupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Save data to Database", "Test description", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    try
                    {
                        this.Validate();
                        this.testDescriptionSetupBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.databaseDataSet);
                        MessageBox.Show("Save to Database");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Not Saved!!! (" + exc.Message + ")");
                    }
                    break;
                case DialogResult.No:
                    break;
            }
            


        }

        private void FormNTD_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.TestDescriptionSetup' . Możesz go przenieść lub usunąć.
            this.testDescriptionSetupTableAdapter.Fill(this.databaseDataSet.TestDescriptionSetup);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Save data to Database", "Test description", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    try
                    {
                        this.Validate();
                        this.testDescriptionSetupBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.databaseDataSet);
                        MessageBox.Show("Save to Database");
                        this.Hide();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Not Saved!!! (" + exc.Message + ")");
                    }
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
        }
    }
}
