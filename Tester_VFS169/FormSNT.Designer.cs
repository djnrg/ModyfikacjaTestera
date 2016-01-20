namespace Tester_VFS169
{
    partial class FormSNT
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
            System.Windows.Forms.Label iD_TestInputLabel;
            System.Windows.Forms.Label testNameInputLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label compressorDescriptionLabel;
            System.Windows.Forms.Label requesterLabel;
            System.Windows.Forms.Label iD_TestDescSetupLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSNT));
            this.databaseDataSet = new Tester_VFS169.DatabaseDataSet();
            this.testDescriptionInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDescriptionInputTableAdapter = new Tester_VFS169.DatabaseDataSetTableAdapters.TestDescriptionInputTableAdapter();
            this.tableAdapterManager = new Tester_VFS169.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.testDescriptionInputBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.testDescriptionInputBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fKTestParametersTestDescriptionInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testParametersTableAdapter = new Tester_VFS169.DatabaseDataSetTableAdapters.TestParametersTableAdapter();
            this.iD_TestInputTextBox = new System.Windows.Forms.TextBox();
            this.testNameInputTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.compressorDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.requesterTextBox = new System.Windows.Forms.TextBox();
            this.iD_TestDescSetupComboBox = new System.Windows.Forms.ComboBox();
            this.testDescriptionSetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new Tester_VFS169.DatabaseDataSet();
            this.testDescriptionSetupTableAdapter = new Tester_VFS169.DatabaseDataSetTableAdapters.TestDescriptionSetupTableAdapter();
            iD_TestInputLabel = new System.Windows.Forms.Label();
            testNameInputLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            compressorDescriptionLabel = new System.Windows.Forms.Label();
            requesterLabel = new System.Windows.Forms.Label();
            iD_TestDescSetupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingNavigator)).BeginInit();
            this.testDescriptionInputBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKTestParametersTestDescriptionInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionSetupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TestInputLabel
            // 
            iD_TestInputLabel.AutoSize = true;
            iD_TestInputLabel.Location = new System.Drawing.Point(12, 35);
            iD_TestInputLabel.Name = "iD_TestInputLabel";
            iD_TestInputLabel.Size = new System.Drawing.Size(72, 13);
            iD_TestInputLabel.TabIndex = 1;
            iD_TestInputLabel.Text = "ID Test Input:";
            // 
            // testNameInputLabel
            // 
            testNameInputLabel.AutoSize = true;
            testNameInputLabel.Location = new System.Drawing.Point(12, 61);
            testNameInputLabel.Name = "testNameInputLabel";
            testNameInputLabel.Size = new System.Drawing.Size(89, 13);
            testNameInputLabel.TabIndex = 3;
            testNameInputLabel.Text = "Test Name Input:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(12, 88);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 5;
            startDateLabel.Text = "Start Date:";
            // 
            // compressorDescriptionLabel
            // 
            compressorDescriptionLabel.AutoSize = true;
            compressorDescriptionLabel.Location = new System.Drawing.Point(12, 113);
            compressorDescriptionLabel.Name = "compressorDescriptionLabel";
            compressorDescriptionLabel.Size = new System.Drawing.Size(121, 13);
            compressorDescriptionLabel.TabIndex = 7;
            compressorDescriptionLabel.Text = "Compressor Description:";
            // 
            // requesterLabel
            // 
            requesterLabel.AutoSize = true;
            requesterLabel.Location = new System.Drawing.Point(12, 139);
            requesterLabel.Name = "requesterLabel";
            requesterLabel.Size = new System.Drawing.Size(59, 13);
            requesterLabel.TabIndex = 9;
            requesterLabel.Text = "Requester:";
            // 
            // iD_TestDescSetupLabel
            // 
            iD_TestDescSetupLabel.AutoSize = true;
            iD_TestDescSetupLabel.Location = new System.Drawing.Point(12, 167);
            iD_TestDescSetupLabel.Name = "iD_TestDescSetupLabel";
            iD_TestDescSetupLabel.Size = new System.Drawing.Size(104, 13);
            iD_TestDescSetupLabel.TabIndex = 17;
            iD_TestDescSetupLabel.Text = "ID Test Desc Setup:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDescriptionInputBindingSource
            // 
            this.testDescriptionInputBindingSource.DataMember = "TestDescriptionInput";
            this.testDescriptionInputBindingSource.DataSource = this.databaseDataSet;
            // 
            // testDescriptionInputTableAdapter
            // 
            this.testDescriptionInputTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestCommentsTableAdapter = null;
            this.tableAdapterManager.TestDescriptionInputTableAdapter = this.testDescriptionInputTableAdapter;
            this.tableAdapterManager.TestDescriptionSetupTableAdapter = null;
            this.tableAdapterManager.TestParametersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tester_VFS169.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.testDescriptionInputBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.testDescriptionInputBindingNavigator.TabIndex = 0;
            this.testDescriptionInputBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // testDescriptionInputBindingNavigatorSaveItem
            // 
            this.testDescriptionInputBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testDescriptionInputBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testDescriptionInputBindingNavigatorSaveItem.Image")));
            this.testDescriptionInputBindingNavigatorSaveItem.Name = "testDescriptionInputBindingNavigatorSaveItem";
            this.testDescriptionInputBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.testDescriptionInputBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.testDescriptionInputBindingNavigatorSaveItem.Click += new System.EventHandler(this.testDescriptionInputBindingNavigatorSaveItem_Click_1);
            // 
            // fKTestParametersTestDescriptionInputBindingSource
            // 
            this.fKTestParametersTestDescriptionInputBindingSource.DataMember = "FK_TestParameters_TestDescriptionInput";
            this.fKTestParametersTestDescriptionInputBindingSource.DataSource = this.testDescriptionInputBindingSource;
            // 
            // testParametersTableAdapter
            // 
            this.testParametersTableAdapter.ClearBeforeFill = true;
            // 
            // iD_TestInputTextBox
            // 
            this.iD_TestInputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "ID_TestInput", true));
            this.iD_TestInputTextBox.Location = new System.Drawing.Point(139, 32);
            this.iD_TestInputTextBox.Name = "iD_TestInputTextBox";
            this.iD_TestInputTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_TestInputTextBox.TabIndex = 2;
            // 
            // testNameInputTextBox
            // 
            this.testNameInputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "TestNameInput", true));
            this.testNameInputTextBox.Location = new System.Drawing.Point(139, 58);
            this.testNameInputTextBox.Name = "testNameInputTextBox";
            this.testNameInputTextBox.Size = new System.Drawing.Size(200, 20);
            this.testNameInputTextBox.TabIndex = 4;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.testDescriptionInputBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(139, 84);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 6;
            // 
            // compressorDescriptionTextBox
            // 
            this.compressorDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "CompressorDescription", true));
            this.compressorDescriptionTextBox.Location = new System.Drawing.Point(139, 110);
            this.compressorDescriptionTextBox.Name = "compressorDescriptionTextBox";
            this.compressorDescriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.compressorDescriptionTextBox.TabIndex = 8;
            // 
            // requesterTextBox
            // 
            this.requesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "Requester", true));
            this.requesterTextBox.Location = new System.Drawing.Point(139, 136);
            this.requesterTextBox.Name = "requesterTextBox";
            this.requesterTextBox.Size = new System.Drawing.Size(200, 20);
            this.requesterTextBox.TabIndex = 10;
            // 
            // iD_TestDescSetupComboBox
            // 
            this.iD_TestDescSetupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "ID_TestDescSetup", true));
            this.iD_TestDescSetupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.testDescriptionSetupBindingSource, "ID_TestSetup", true));
            this.iD_TestDescSetupComboBox.FormattingEnabled = true;
            this.iD_TestDescSetupComboBox.Location = new System.Drawing.Point(139, 163);
            this.iD_TestDescSetupComboBox.Name = "iD_TestDescSetupComboBox";
            this.iD_TestDescSetupComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_TestDescSetupComboBox.TabIndex = 18;
            // 
            // testDescriptionSetupBindingSource
            // 
            this.testDescriptionSetupBindingSource.DataMember = "TestDescriptionSetup";
            this.testDescriptionSetupBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDescriptionSetupTableAdapter
            // 
            this.testDescriptionSetupTableAdapter.ClearBeforeFill = true;
            // 
            // FormSNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(347, 195);
            this.Controls.Add(this.iD_TestDescSetupComboBox);
            this.Controls.Add(iD_TestInputLabel);
            this.Controls.Add(this.iD_TestInputTextBox);
            this.Controls.Add(testNameInputLabel);
            this.Controls.Add(this.testNameInputTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(compressorDescriptionLabel);
            this.Controls.Add(this.compressorDescriptionTextBox);
            this.Controls.Add(requesterLabel);
            this.Controls.Add(this.requesterTextBox);
            this.Controls.Add(iD_TestDescSetupLabel);
            this.Controls.Add(this.testDescriptionInputBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSNT";
            this.Text = "FormSNT";
            this.Load += new System.EventHandler(this.FormSNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingNavigator)).EndInit();
            this.testDescriptionInputBindingNavigator.ResumeLayout(false);
            this.testDescriptionInputBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKTestParametersTestDescriptionInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionSetupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource testDescriptionInputBindingSource;
        private DatabaseDataSetTableAdapters.TestDescriptionInputTableAdapter testDescriptionInputTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.BindingSource fKTestParametersTestDescriptionInputBindingSource;
        private DatabaseDataSetTableAdapters.TestParametersTableAdapter testParametersTableAdapter;
        private System.Windows.Forms.TextBox iD_TestInputTextBox;
        private System.Windows.Forms.TextBox testNameInputTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.TextBox compressorDescriptionTextBox;
        private System.Windows.Forms.TextBox requesterTextBox;
        private System.Windows.Forms.ComboBox iD_TestDescSetupComboBox;
        private DatabaseDataSet databaseDataSet1;
        private System.Windows.Forms.BindingSource testDescriptionSetupBindingSource;
        private DatabaseDataSetTableAdapters.TestDescriptionSetupTableAdapter testDescriptionSetupTableAdapter;

    }
}