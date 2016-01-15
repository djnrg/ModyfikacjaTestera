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
    public partial class FormStartNewTest : Form
    {
        ////public DatabaseDataSetTableAdapters.TestDescriptionSetupTableAdapter tabTd = new DatabaseDataSetTableAdapters.TestDescriptionSetupTableAdapter();
        ////public DatabaseDataSetTableAdapters.TestDescriptionInputTableAdapter tabTi = new DatabaseDataSetTableAdapters.TestDescriptionInputTableAdapter();
        
        //public FormStartNewTest()
        //{
        //    InitializeComponent();
        //    LoadTs();
        //}

        //private void testDescriptionInputBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    //this.testDescriptionInputBindingSource.EndEdit();
        //    //this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        //}

        //private void LoadTs()
        //{
        //    var specList = tabTd.GetData();
        //    cbTestSpec.DataSource = specList;
        //    cbTestSpec.DisplayMember = "TestName";
        //    cbTestSpec.ValueMember = "ID_TestSetup";
        //    cbTestSpec.SelectedIndex = -1;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var a = tabTi.InsertNewTest(textBox1.Text, DateTime.Now, "VS16", "DB", true, DateTime.Now, "jui", Convert.ToInt32(cbTestSpec.SelectedValue));
        //}
    }
}
