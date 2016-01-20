namespace Tester_VFS169
{
    partial class FormComments
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
            System.Windows.Forms.Label iD_CommentsLabel;
            System.Windows.Forms.Label iD_TestInputLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label commentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComments));
            this.databaseDataSet = new Tester_VFS169.DatabaseDataSet();
            this.testCommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testCommentsTableAdapter = new Tester_VFS169.DatabaseDataSetTableAdapters.TestCommentsTableAdapter();
            this.tableAdapterManager = new Tester_VFS169.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.testCommentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.testCommentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CommentsTextBox = new System.Windows.Forms.TextBox();
            this.iD_TestInputTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            iD_CommentsLabel = new System.Windows.Forms.Label();
            iD_TestInputLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCommentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCommentsBindingNavigator)).BeginInit();
            this.testCommentsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_CommentsLabel
            // 
            iD_CommentsLabel.AutoSize = true;
            iD_CommentsLabel.Location = new System.Drawing.Point(5, 31);
            iD_CommentsLabel.Name = "iD_CommentsLabel";
            iD_CommentsLabel.Size = new System.Drawing.Size(73, 13);
            iD_CommentsLabel.TabIndex = 1;
            iD_CommentsLabel.Text = "ID Comments:";
            // 
            // iD_TestInputLabel
            // 
            iD_TestInputLabel.AutoSize = true;
            iD_TestInputLabel.Location = new System.Drawing.Point(5, 57);
            iD_TestInputLabel.Name = "iD_TestInputLabel";
            iD_TestInputLabel.Size = new System.Drawing.Size(72, 13);
            iD_TestInputLabel.TabIndex = 3;
            iD_TestInputLabel.Text = "ID Test Input:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(5, 84);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(5, 109);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 7;
            commentsLabel.Text = "Comments:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testCommentsBindingSource
            // 
            this.testCommentsBindingSource.DataMember = "TestComments";
            this.testCommentsBindingSource.DataSource = this.databaseDataSet;
            // 
            // testCommentsTableAdapter
            // 
            this.testCommentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestCommentsTableAdapter = this.testCommentsTableAdapter;
            this.tableAdapterManager.TestDescriptionInputTableAdapter = null;
            this.tableAdapterManager.TestDescriptionSetupTableAdapter = null;
            this.tableAdapterManager.TestParametersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tester_VFS169.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testCommentsBindingNavigator
            // 
            this.testCommentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testCommentsBindingNavigator.BindingSource = this.testCommentsBindingSource;
            this.testCommentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testCommentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testCommentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.testCommentsBindingNavigatorSaveItem});
            this.testCommentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testCommentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testCommentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testCommentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testCommentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testCommentsBindingNavigator.Name = "testCommentsBindingNavigator";
            this.testCommentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testCommentsBindingNavigator.Size = new System.Drawing.Size(297, 25);
            this.testCommentsBindingNavigator.TabIndex = 0;
            this.testCommentsBindingNavigator.Text = "bindingNavigator1";
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
            // testCommentsBindingNavigatorSaveItem
            // 
            this.testCommentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testCommentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testCommentsBindingNavigatorSaveItem.Image")));
            this.testCommentsBindingNavigatorSaveItem.Name = "testCommentsBindingNavigatorSaveItem";
            this.testCommentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.testCommentsBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.testCommentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.testCommentsBindingNavigatorSaveItem_Click);
            // 
            // iD_CommentsTextBox
            // 
            this.iD_CommentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testCommentsBindingSource, "ID_Comments", true));
            this.iD_CommentsTextBox.Location = new System.Drawing.Point(84, 28);
            this.iD_CommentsTextBox.Name = "iD_CommentsTextBox";
            this.iD_CommentsTextBox.ReadOnly = true;
            this.iD_CommentsTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_CommentsTextBox.TabIndex = 2;
            // 
            // iD_TestInputTextBox
            // 
            this.iD_TestInputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testCommentsBindingSource, "ID_TestInput", true));
            this.iD_TestInputTextBox.Location = new System.Drawing.Point(84, 54);
            this.iD_TestInputTextBox.Name = "iD_TestInputTextBox";
            this.iD_TestInputTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_TestInputTextBox.TabIndex = 4;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.testCommentsBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(84, 80);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 6;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testCommentsBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(84, 106);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(200, 108);
            this.commentsTextBox.TabIndex = 8;
            // 
            // FormComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 226);
            this.Controls.Add(iD_CommentsLabel);
            this.Controls.Add(this.iD_CommentsTextBox);
            this.Controls.Add(iD_TestInputLabel);
            this.Controls.Add(this.iD_TestInputTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.testCommentsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormComments";
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.FormComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCommentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCommentsBindingNavigator)).EndInit();
            this.testCommentsBindingNavigator.ResumeLayout(false);
            this.testCommentsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource testCommentsBindingSource;
        private DatabaseDataSetTableAdapters.TestCommentsTableAdapter testCommentsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testCommentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testCommentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CommentsTextBox;
        private System.Windows.Forms.TextBox iD_TestInputTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox commentsTextBox;
    }
}