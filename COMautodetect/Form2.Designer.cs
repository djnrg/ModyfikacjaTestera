namespace COMautodetect
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label iD_TestInputLabel;
            System.Windows.Forms.Label testNameInputLabel;
            System.Windows.Forms.Label test_IDLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label compressorDescriptionLabel;
            System.Windows.Forms.Label requesterLabel;
            System.Windows.Forms.Label compressorPassLabel;
            System.Windows.Forms.Label finishDateLabel;
            this.database1DataSet = new COMautodetect.Database1DataSet();
            this.testDescriptionInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDescriptionInputTableAdapter = new COMautodetect.Database1DataSetTableAdapters.TestDescriptionInputTableAdapter();
            this.tableAdapterManager = new COMautodetect.Database1DataSetTableAdapters.TableAdapterManager();
            this.testDescriptionInputBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.testDescriptionInputBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TestInputTextBox = new System.Windows.Forms.TextBox();
            this.testNameInputTextBox = new System.Windows.Forms.TextBox();
            this.test_IDTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.compressorDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.requesterTextBox = new System.Windows.Forms.TextBox();
            this.compressorPassCheckBox = new System.Windows.Forms.CheckBox();
            this.finishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testDescriptionSetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDescriptionSetupTableAdapter = new COMautodetect.Database1DataSetTableAdapters.TestDescriptionSetupTableAdapter();
            iD_TestInputLabel = new System.Windows.Forms.Label();
            testNameInputLabel = new System.Windows.Forms.Label();
            test_IDLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            compressorDescriptionLabel = new System.Windows.Forms.Label();
            requesterLabel = new System.Windows.Forms.Label();
            compressorPassLabel = new System.Windows.Forms.Label();
            finishDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingNavigator)).BeginInit();
            this.testDescriptionInputBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionSetupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDescriptionInputBindingSource
            // 
            this.testDescriptionInputBindingSource.DataMember = "TestDescriptionInput";
            this.testDescriptionInputBindingSource.DataSource = this.database1DataSet;
            // 
            // testDescriptionInputTableAdapter
            // 
            this.testDescriptionInputTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestDescriptionInputTableAdapter = this.testDescriptionInputTableAdapter;
            this.tableAdapterManager.TestDescriptionSetupTableAdapter = this.testDescriptionSetupTableAdapter;
            this.tableAdapterManager.TestParametersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COMautodetect.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testDescriptionInputBindingNavigator
            // 
            this.testDescriptionInputBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testDescriptionInputBindingNavigator.BindingSource = this.testDescriptionInputBindingSource;
            this.testDescriptionInputBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testDescriptionInputBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testDescriptionInputBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.testDescriptionInputBindingNavigatorSaveItem});
            this.testDescriptionInputBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testDescriptionInputBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testDescriptionInputBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testDescriptionInputBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testDescriptionInputBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testDescriptionInputBindingNavigator.Name = "testDescriptionInputBindingNavigator";
            this.testDescriptionInputBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testDescriptionInputBindingNavigator.Size = new System.Drawing.Size(352, 25);
            this.testDescriptionInputBindingNavigator.TabIndex = 0;
            this.testDescriptionInputBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // testDescriptionInputBindingNavigatorSaveItem
            // 
            this.testDescriptionInputBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testDescriptionInputBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testDescriptionInputBindingNavigatorSaveItem.Image")));
            this.testDescriptionInputBindingNavigatorSaveItem.Name = "testDescriptionInputBindingNavigatorSaveItem";
            this.testDescriptionInputBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.testDescriptionInputBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.testDescriptionInputBindingNavigatorSaveItem.Click += new System.EventHandler(this.testDescriptionInputBindingNavigatorSaveItem_Click);
            // 
            // iD_TestInputLabel
            // 
            iD_TestInputLabel.AutoSize = true;
            iD_TestInputLabel.Location = new System.Drawing.Point(12, 37);
            iD_TestInputLabel.Name = "iD_TestInputLabel";
            iD_TestInputLabel.Size = new System.Drawing.Size(72, 13);
            iD_TestInputLabel.TabIndex = 1;
            iD_TestInputLabel.Text = "ID Test Input:";
            // 
            // iD_TestInputTextBox
            // 
            this.iD_TestInputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "ID_TestInput", true));
            this.iD_TestInputTextBox.Location = new System.Drawing.Point(139, 34);
            this.iD_TestInputTextBox.Name = "iD_TestInputTextBox";
            this.iD_TestInputTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_TestInputTextBox.TabIndex = 2;
            // 
            // testNameInputLabel
            // 
            testNameInputLabel.AutoSize = true;
            testNameInputLabel.Location = new System.Drawing.Point(12, 63);
            testNameInputLabel.Name = "testNameInputLabel";
            testNameInputLabel.Size = new System.Drawing.Size(89, 13);
            testNameInputLabel.TabIndex = 3;
            testNameInputLabel.Text = "Test Name Input:";
            // 
            // testNameInputTextBox
            // 
            this.testNameInputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "TestNameInput", true));
            this.testNameInputTextBox.Location = new System.Drawing.Point(139, 60);
            this.testNameInputTextBox.Name = "testNameInputTextBox";
            this.testNameInputTextBox.Size = new System.Drawing.Size(200, 20);
            this.testNameInputTextBox.TabIndex = 4;
            // 
            // test_IDLabel
            // 
            test_IDLabel.AutoSize = true;
            test_IDLabel.Location = new System.Drawing.Point(12, 89);
            test_IDLabel.Name = "test_IDLabel";
            test_IDLabel.Size = new System.Drawing.Size(45, 13);
            test_IDLabel.TabIndex = 5;
            test_IDLabel.Text = "Test ID:";
            // 
            // test_IDTextBox
            // 
            this.test_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "Test_ID", true));
            this.test_IDTextBox.Location = new System.Drawing.Point(139, 86);
            this.test_IDTextBox.Name = "test_IDTextBox";
            this.test_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.test_IDTextBox.TabIndex = 6;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(12, 116);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 7;
            startDateLabel.Text = "Start Date:";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.testDescriptionInputBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(139, 112);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 8;
            // 
            // compressorDescriptionLabel
            // 
            compressorDescriptionLabel.AutoSize = true;
            compressorDescriptionLabel.Location = new System.Drawing.Point(12, 141);
            compressorDescriptionLabel.Name = "compressorDescriptionLabel";
            compressorDescriptionLabel.Size = new System.Drawing.Size(121, 13);
            compressorDescriptionLabel.TabIndex = 9;
            compressorDescriptionLabel.Text = "Compressor Description:";
            // 
            // compressorDescriptionTextBox
            // 
            this.compressorDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "CompressorDescription", true));
            this.compressorDescriptionTextBox.Location = new System.Drawing.Point(139, 138);
            this.compressorDescriptionTextBox.Name = "compressorDescriptionTextBox";
            this.compressorDescriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.compressorDescriptionTextBox.TabIndex = 10;
            // 
            // requesterLabel
            // 
            requesterLabel.AutoSize = true;
            requesterLabel.Location = new System.Drawing.Point(12, 167);
            requesterLabel.Name = "requesterLabel";
            requesterLabel.Size = new System.Drawing.Size(59, 13);
            requesterLabel.TabIndex = 11;
            requesterLabel.Text = "Requester:";
            // 
            // requesterTextBox
            // 
            this.requesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "Requester", true));
            this.requesterTextBox.Location = new System.Drawing.Point(139, 164);
            this.requesterTextBox.Name = "requesterTextBox";
            this.requesterTextBox.Size = new System.Drawing.Size(200, 20);
            this.requesterTextBox.TabIndex = 12;
            // 
            // compressorPassLabel
            // 
            compressorPassLabel.AutoSize = true;
            compressorPassLabel.Location = new System.Drawing.Point(12, 195);
            compressorPassLabel.Name = "compressorPassLabel";
            compressorPassLabel.Size = new System.Drawing.Size(91, 13);
            compressorPassLabel.TabIndex = 13;
            compressorPassLabel.Text = "Compressor Pass:";
            // 
            // compressorPassCheckBox
            // 
            this.compressorPassCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.testDescriptionInputBindingSource, "CompressorPass", true));
            this.compressorPassCheckBox.Location = new System.Drawing.Point(139, 190);
            this.compressorPassCheckBox.Name = "compressorPassCheckBox";
            this.compressorPassCheckBox.Size = new System.Drawing.Size(200, 24);
            this.compressorPassCheckBox.TabIndex = 14;
            this.compressorPassCheckBox.Text = "checkBox1";
            this.compressorPassCheckBox.UseVisualStyleBackColor = true;
            // 
            // finishDateLabel
            // 
            finishDateLabel.AutoSize = true;
            finishDateLabel.Location = new System.Drawing.Point(12, 224);
            finishDateLabel.Name = "finishDateLabel";
            finishDateLabel.Size = new System.Drawing.Size(63, 13);
            finishDateLabel.TabIndex = 15;
            finishDateLabel.Text = "Finish Date:";
            // 
            // finishDateDateTimePicker
            // 
            this.finishDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.testDescriptionInputBindingSource, "FinishDate", true));
            this.finishDateDateTimePicker.Location = new System.Drawing.Point(139, 220);
            this.finishDateDateTimePicker.Name = "finishDateDateTimePicker";
            this.finishDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.finishDateDateTimePicker.TabIndex = 16;
            // 
            // testDescriptionSetupBindingSource
            // 
            this.testDescriptionSetupBindingSource.DataMember = "TestDescriptionSetup";
            this.testDescriptionSetupBindingSource.DataSource = this.database1DataSet;
            // 
            // testDescriptionSetupTableAdapter
            // 
            this.testDescriptionSetupTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 246);
            this.Controls.Add(iD_TestInputLabel);
            this.Controls.Add(this.iD_TestInputTextBox);
            this.Controls.Add(testNameInputLabel);
            this.Controls.Add(this.testNameInputTextBox);
            this.Controls.Add(test_IDLabel);
            this.Controls.Add(this.test_IDTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(compressorDescriptionLabel);
            this.Controls.Add(this.compressorDescriptionTextBox);
            this.Controls.Add(requesterLabel);
            this.Controls.Add(this.requesterTextBox);
            this.Controls.Add(compressorPassLabel);
            this.Controls.Add(this.compressorPassCheckBox);
            this.Controls.Add(finishDateLabel);
            this.Controls.Add(this.finishDateDateTimePicker);
            this.Controls.Add(this.testDescriptionInputBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingNavigator)).EndInit();
            this.testDescriptionInputBindingNavigator.ResumeLayout(false);
            this.testDescriptionInputBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionSetupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource testDescriptionInputBindingSource;
        private Database1DataSetTableAdapters.TestDescriptionInputTableAdapter testDescriptionInputTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testDescriptionInputBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton testDescriptionInputBindingNavigatorSaveItem;
        private Database1DataSetTableAdapters.TestDescriptionSetupTableAdapter testDescriptionSetupTableAdapter;
        private System.Windows.Forms.TextBox iD_TestInputTextBox;
        private System.Windows.Forms.TextBox testNameInputTextBox;
        private System.Windows.Forms.TextBox test_IDTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.TextBox compressorDescriptionTextBox;
        private System.Windows.Forms.TextBox requesterTextBox;
        private System.Windows.Forms.CheckBox compressorPassCheckBox;
        private System.Windows.Forms.DateTimePicker finishDateDateTimePicker;
        private System.Windows.Forms.BindingSource testDescriptionSetupBindingSource;

    }
}