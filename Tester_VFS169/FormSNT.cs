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
    public partial class FormSNT : Form
    {
        public FormSNT()
        {
            InitializeComponent();
        }

        private void testDescriptionInputBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testDescriptionInputBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void testDescriptionInputBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.testDescriptionInputBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormSNT_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet1.TestDescriptionSetup' . Możesz go przenieść lub usunąć.
            this.testDescriptionSetupTableAdapter.Fill(this.databaseDataSet1.TestDescriptionSetup);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.TestParameters' . Możesz go przenieść lub usunąć.
            this.testParametersTableAdapter.Fill(this.databaseDataSet.TestParameters);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.TestDescriptionInput' . Możesz go przenieść lub usunąć.
            this.testDescriptionInputTableAdapter.Fill(this.databaseDataSet.TestDescriptionInput);

        }
    }
}
