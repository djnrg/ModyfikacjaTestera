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
    public partial class FormFinishTest : Form
    {
        public FormFinishTest()
        {
            InitializeComponent();
        }

        private void testDescriptionInputBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testDescriptionInputBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormFinishTest_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.TestDescriptionInput' . Możesz go przenieść lub usunąć.
            this.testDescriptionInputTableAdapter.Fill(this.databaseDataSet.TestDescriptionInput);

        }
    }
}
