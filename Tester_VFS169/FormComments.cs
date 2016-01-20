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
    public partial class FormComments : Form
    {
        public FormComments()
        {
            InitializeComponent();
        }

        private void testCommentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testCommentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormComments_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.TestComments' . Możesz go przenieść lub usunąć.
            this.testCommentsTableAdapter.Fill(this.databaseDataSet.TestComments);

        }
    }
}
