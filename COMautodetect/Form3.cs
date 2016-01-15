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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void testDescriptionSetupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testDescriptionSetupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.TestDescriptionSetup' . Możesz go przenieść lub usunąć.
            this.testDescriptionSetupTableAdapter.Fill(this.database1DataSet.TestDescriptionSetup);

        }
    }
}
