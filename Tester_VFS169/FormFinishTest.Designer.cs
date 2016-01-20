namespace Tester_VFS169
{
    partial class FormFinishTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinishTest));
            System.Windows.Forms.Label iD_TestInputLabel;
            System.Windows.Forms.Label testNameInputLabel;
            System.Windows.Forms.Label compressorPassLabel;
            System.Windows.Forms.Label finishDateLabel;
            System.Windows.Forms.Label commentsLabel;
            this.databaseDataSet = new Tester_VFS169.DatabaseDataSet();
            this.testDescriptionInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDescriptionInputTableAdapter = new Tester_VFS169.DatabaseDataSetTableAdapters.TestDescriptionInputTableAdapter();
            this.tableAdapterManager = new Tester_VFS169.DatabaseDataSetTableAdapters.TableAdapterManager();
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
            this.testDescriptionInputBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TestInputTextBox = new System.Windows.Forms.TextBox();
            this.testNameInputTextBox = new System.Windows.Forms.TextBox();
            this.compressorPassCheckBox = new System.Windows.Forms.CheckBox();
            this.finishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            iD_TestInputLabel = new System.Windows.Forms.Label();
            testNameInputLabel = new System.Windows.Forms.Label();
            compressorPassLabel = new System.Windows.Forms.Label();
            finishDateLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingNavigator)).BeginInit();
            this.testDescriptionInputBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.testDescriptionInputBindingNavigator.AddNewItem = null;
            this.testDescriptionInputBindingNavigator.BindingSource = this.testDescriptionInputBindingSource;
            this.testDescriptionInputBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testDescriptionInputBindingNavigator.DeleteItem = null;
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
            this.testDescriptionInputBindingNavigatorSaveItem});
            this.testDescriptionInputBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testDescriptionInputBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testDescriptionInputBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testDescriptionInputBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testDescriptionInputBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testDescriptionInputBindingNavigator.Name = "testDescriptionInputBindingNavigator";
            this.testDescriptionInputBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testDescriptionInputBindingNavigator.Size = new System.Drawing.Size(343, 25);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // testDescriptionInputBindingNavigatorSaveItem
            // 
            this.testDescriptionInputBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testDescriptionInputBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testDescriptionInputBindingNavigatorSaveItem.Image")));
            this.testDescriptionInputBindingNavigatorSaveItem.Name = "testDescriptionInputBindingNavigatorSaveItem";
            this.testDescriptionInputBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.testDescriptionInputBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.testDescriptionInputBindingNavigatorSaveItem.Click += new System.EventHandler(this.testDescriptionInputBindingNavigatorSaveItem_Click);
            // 
            // iD_TestInputLabel
            // 
            iD_TestInputLabel.AutoSize = true;
            iD_TestInputLabel.Location = new System.Drawing.Point(7, 35);
            iD_TestInputLabel.Name = "iD_TestInputLabel";
            iD_TestInputLabel.Size = new System.Drawing.Size(72, 13);
            iD_TestInputLabel.TabIndex = 1;
            iD_TestInputLabel.Text = "ID Test Input:";
            // 
            // iD_TestInputTextBox
            // 
            this.iD_TestInputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "ID_TestInput", true));
            this.iD_TestInputTextBox.Location = new System.Drawing.Point(134, 32);
            this.iD_TestInputTextBox.Name = "iD_TestInputTextBox";
            this.iD_TestInputTextBox.ReadOnly = true;
            this.iD_TestInputTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_TestInputTextBox.TabIndex = 2;
            // 
            // testNameInputLabel
            // 
            testNameInputLabel.AutoSize = true;
            testNameInputLabel.Location = new System.Drawing.Point(7, 61);
            testNameInputLabel.Name = "testNameInputLabel";
            testNameInputLabel.Size = new System.Drawing.Size(89, 13);
            testNameInputLabel.TabIndex = 3;
            testNameInputLabel.Text = "Test Name Input:";
            // 
            // testNameInputTextBox
            // 
            this.testNameInputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "TestNameInput", true));
            this.testNameInputTextBox.Location = new System.Drawing.Point(134, 58);
            this.testNameInputTextBox.Name = "testNameInputTextBox";
            this.testNameInputTextBox.ReadOnly = true;
            this.testNameInputTextBox.Size = new System.Drawing.Size(200, 20);
            this.testNameInputTextBox.TabIndex = 4;
            // 
            // compressorPassLabel
            // 
            compressorPassLabel.AutoSize = true;
            compressorPassLabel.Location = new System.Drawing.Point(7, 87);
            compressorPassLabel.Name = "compressorPassLabel";
            compressorPassLabel.Size = new System.Drawing.Size(91, 13);
            compressorPassLabel.TabIndex = 11;
            compressorPassLabel.Text = "Compressor Pass:";
            // 
            // compressorPassCheckBox
            // 
            this.compressorPassCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.testDescriptionInputBindingSource, "CompressorPass", true));
            this.compressorPassCheckBox.Location = new System.Drawing.Point(134, 82);
            this.compressorPassCheckBox.Name = "compressorPassCheckBox";
            this.compressorPassCheckBox.Size = new System.Drawing.Size(200, 24);
            this.compressorPassCheckBox.TabIndex = 12;
            this.compressorPassCheckBox.Text = "PASS";
            this.compressorPassCheckBox.UseVisualStyleBackColor = true;
            // 
            // finishDateLabel
            // 
            finishDateLabel.AutoSize = true;
            finishDateLabel.Location = new System.Drawing.Point(7, 116);
            finishDateLabel.Name = "finishDateLabel";
            finishDateLabel.Size = new System.Drawing.Size(63, 13);
            finishDateLabel.TabIndex = 13;
            finishDateLabel.Text = "Finish Date:";
            // 
            // finishDateDateTimePicker
            // 
            this.finishDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.testDescriptionInputBindingSource, "FinishDate", true));
            this.finishDateDateTimePicker.Location = new System.Drawing.Point(134, 112);
            this.finishDateDateTimePicker.Name = "finishDateDateTimePicker";
            this.finishDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.finishDateDateTimePicker.TabIndex = 14;
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(7, 141);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 15;
            commentsLabel.Text = "Comments:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionInputBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(134, 138);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(200, 77);
            this.commentsTextBox.TabIndex = 16;
            // 
            // FormFinishTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 222);
            this.Controls.Add(iD_TestInputLabel);
            this.Controls.Add(this.iD_TestInputTextBox);
            this.Controls.Add(testNameInputLabel);
            this.Controls.Add(this.testNameInputTextBox);
            this.Controls.Add(compressorPassLabel);
            this.Controls.Add(this.compressorPassCheckBox);
            this.Controls.Add(finishDateLabel);
            this.Controls.Add(this.finishDateDateTimePicker);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.testDescriptionInputBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFinishTest";
            this.Text = "Finish Test";
            this.Load += new System.EventHandler(this.FormFinishTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionInputBindingNavigator)).EndInit();
            this.testDescriptionInputBindingNavigator.ResumeLayout(false);
            this.testDescriptionInputBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource testDescriptionInputBindingSource;
        private DatabaseDataSetTableAdapters.TestDescriptionInputTableAdapter testDescriptionInputTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testDescriptionInputBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton testDescriptionInputBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_TestInputTextBox;
        private System.Windows.Forms.TextBox testNameInputTextBox;
        private System.Windows.Forms.CheckBox compressorPassCheckBox;
        private System.Windows.Forms.DateTimePicker finishDateDateTimePicker;
        private System.Windows.Forms.TextBox commentsTextBox;
    }
}