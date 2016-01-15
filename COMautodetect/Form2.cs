using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMautodetect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void testDescriptionInputBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testDescriptionInputBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.TestDescriptionSetup' . Możesz go przenieść lub usunąć.
            this.testDescriptionSetupTableAdapter.Fill(this.database1DataSet.TestDescriptionSetup);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.TestDescriptionInput' . Możesz go przenieść lub usunąć.
            this.testDescriptionInputTableAdapter.Fill(this.database1DataSet.TestDescriptionInput);

        }
    }
}
