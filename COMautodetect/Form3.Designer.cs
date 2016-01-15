namespace COMautodetect
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label iD_TestSetupLabel;
            System.Windows.Forms.Label testNameLabel;
            System.Windows.Forms.Label stepLabel;
            System.Windows.Forms.Label pressureDischargeSetupLabel;
            System.Windows.Forms.Label pressureSuctionSetupLabel;
            System.Windows.Forms.Label hotBoxTemperatureLabel;
            System.Windows.Forms.Label rPMLabel;
            System.Windows.Forms.Label requestedTimeLabel;
            System.Windows.Forms.Label eCVOnLabel;
            System.Windows.Forms.Label eCVOffLabel;
            System.Windows.Forms.Label coilOnLabel;
            System.Windows.Forms.Label coilOffLabel;
            this.database1DataSet = new COMautodetect.Database1DataSet();
            this.testDescriptionSetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDescriptionSetupTableAdapter = new COMautodetect.Database1DataSetTableAdapters.TestDescriptionSetupTableAdapter();
            this.tableAdapterManager = new COMautodetect.Database1DataSetTableAdapters.TableAdapterManager();
            this.testDescriptionSetupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.testDescriptionSetupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TestSetupTextBox = new System.Windows.Forms.TextBox();
            this.testNameTextBox = new System.Windows.Forms.TextBox();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.pressureDischargeSetupTextBox = new System.Windows.Forms.TextBox();
            this.pressureSuctionSetupTextBox = new System.Windows.Forms.TextBox();
            this.hotBoxTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.rPMTextBox = new System.Windows.Forms.TextBox();
            this.requestedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eCVOnTextBox = new System.Windows.Forms.TextBox();
            this.eCVOffTextBox = new System.Windows.Forms.TextBox();
            this.coilOnTextBox = new System.Windows.Forms.TextBox();
            this.coilOffTextBox = new System.Windows.Forms.TextBox();
            iD_TestSetupLabel = new System.Windows.Forms.Label();
            testNameLabel = new System.Windows.Forms.Label();
            stepLabel = new System.Windows.Forms.Label();
            pressureDischargeSetupLabel = new System.Windows.Forms.Label();
            pressureSuctionSetupLabel = new System.Windows.Forms.Label();
            hotBoxTemperatureLabel = new System.Windows.Forms.Label();
            rPMLabel = new System.Windows.Forms.Label();
            requestedTimeLabel = new System.Windows.Forms.Label();
            eCVOnLabel = new System.Windows.Forms.Label();
            eCVOffLabel = new System.Windows.Forms.Label();
            coilOnLabel = new System.Windows.Forms.Label();
            coilOffLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionSetupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionSetupBindingNavigator)).BeginInit();
            this.testDescriptionSetupBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestDescriptionInputTableAdapter = null;
            this.tableAdapterManager.TestDescriptionSetupTableAdapter = this.testDescriptionSetupTableAdapter;
            this.tableAdapterManager.TestParametersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COMautodetect.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testDescriptionSetupBindingNavigator
            // 
            this.testDescriptionSetupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testDescriptionSetupBindingNavigator.BindingSource = this.testDescriptionSetupBindingSource;
            this.testDescriptionSetupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testDescriptionSetupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testDescriptionSetupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.testDescriptionSetupBindingNavigatorSaveItem});
            this.testDescriptionSetupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testDescriptionSetupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testDescriptionSetupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testDescriptionSetupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testDescriptionSetupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testDescriptionSetupBindingNavigator.Name = "testDescriptionSetupBindingNavigator";
            this.testDescriptionSetupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testDescriptionSetupBindingNavigator.Size = new System.Drawing.Size(399, 25);
            this.testDescriptionSetupBindingNavigator.TabIndex = 0;
            this.testDescriptionSetupBindingNavigator.Text = "bindingNavigator1";
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
            // testDescriptionSetupBindingNavigatorSaveItem
            // 
            this.testDescriptionSetupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testDescriptionSetupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testDescriptionSetupBindingNavigatorSaveItem.Image")));
            this.testDescriptionSetupBindingNavigatorSaveItem.Name = "testDescriptionSetupBindingNavigatorSaveItem";
            this.testDescriptionSetupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.testDescriptionSetupBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.testDescriptionSetupBindingNavigatorSaveItem.Click += new System.EventHandler(this.testDescriptionSetupBindingNavigatorSaveItem_Click);
            // 
            // iD_TestSetupLabel
            // 
            iD_TestSetupLabel.AutoSize = true;
            iD_TestSetupLabel.Location = new System.Drawing.Point(40, 43);
            iD_TestSetupLabel.Name = "iD_TestSetupLabel";
            iD_TestSetupLabel.Size = new System.Drawing.Size(76, 13);
            iD_TestSetupLabel.TabIndex = 1;
            iD_TestSetupLabel.Text = "ID Test Setup:";
            // 
            // iD_TestSetupTextBox
            // 
            this.iD_TestSetupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "ID_TestSetup", true));
            this.iD_TestSetupTextBox.Location = new System.Drawing.Point(179, 40);
            this.iD_TestSetupTextBox.Name = "iD_TestSetupTextBox";
            this.iD_TestSetupTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_TestSetupTextBox.TabIndex = 2;
            // 
            // testNameLabel
            // 
            testNameLabel.AutoSize = true;
            testNameLabel.Location = new System.Drawing.Point(40, 69);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new System.Drawing.Size(62, 13);
            testNameLabel.TabIndex = 3;
            testNameLabel.Text = "Test Name:";
            // 
            // testNameTextBox
            // 
            this.testNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "TestName", true));
            this.testNameTextBox.Location = new System.Drawing.Point(179, 66);
            this.testNameTextBox.Name = "testNameTextBox";
            this.testNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.testNameTextBox.TabIndex = 4;
            // 
            // stepLabel
            // 
            stepLabel.AutoSize = true;
            stepLabel.Location = new System.Drawing.Point(40, 95);
            stepLabel.Name = "stepLabel";
            stepLabel.Size = new System.Drawing.Size(32, 13);
            stepLabel.TabIndex = 5;
            stepLabel.Text = "Step:";
            // 
            // stepTextBox
            // 
            this.stepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "Step", true));
            this.stepTextBox.Location = new System.Drawing.Point(179, 92);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(200, 20);
            this.stepTextBox.TabIndex = 6;
            // 
            // pressureDischargeSetupLabel
            // 
            pressureDischargeSetupLabel.AutoSize = true;
            pressureDischargeSetupLabel.Location = new System.Drawing.Point(40, 121);
            pressureDischargeSetupLabel.Name = "pressureDischargeSetupLabel";
            pressureDischargeSetupLabel.Size = new System.Drawing.Size(133, 13);
            pressureDischargeSetupLabel.TabIndex = 7;
            pressureDischargeSetupLabel.Text = "Pressure Discharge Setup:";
            // 
            // pressureDischargeSetupTextBox
            // 
            this.pressureDischargeSetupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "PressureDischargeSetup", true));
            this.pressureDischargeSetupTextBox.Location = new System.Drawing.Point(179, 118);
            this.pressureDischargeSetupTextBox.Name = "pressureDischargeSetupTextBox";
            this.pressureDischargeSetupTextBox.Size = new System.Drawing.Size(200, 20);
            this.pressureDischargeSetupTextBox.TabIndex = 8;
            // 
            // pressureSuctionSetupLabel
            // 
            pressureSuctionSetupLabel.AutoSize = true;
            pressureSuctionSetupLabel.Location = new System.Drawing.Point(40, 147);
            pressureSuctionSetupLabel.Name = "pressureSuctionSetupLabel";
            pressureSuctionSetupLabel.Size = new System.Drawing.Size(121, 13);
            pressureSuctionSetupLabel.TabIndex = 9;
            pressureSuctionSetupLabel.Text = "Pressure Suction Setup:";
            // 
            // pressureSuctionSetupTextBox
            // 
            this.pressureSuctionSetupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "PressureSuctionSetup", true));
            this.pressureSuctionSetupTextBox.Location = new System.Drawing.Point(179, 144);
            this.pressureSuctionSetupTextBox.Name = "pressureSuctionSetupTextBox";
            this.pressureSuctionSetupTextBox.Size = new System.Drawing.Size(200, 20);
            this.pressureSuctionSetupTextBox.TabIndex = 10;
            // 
            // hotBoxTemperatureLabel
            // 
            hotBoxTemperatureLabel.AutoSize = true;
            hotBoxTemperatureLabel.Location = new System.Drawing.Point(40, 173);
            hotBoxTemperatureLabel.Name = "hotBoxTemperatureLabel";
            hotBoxTemperatureLabel.Size = new System.Drawing.Size(111, 13);
            hotBoxTemperatureLabel.TabIndex = 11;
            hotBoxTemperatureLabel.Text = "Hot Box Temperature:";
            // 
            // hotBoxTemperatureTextBox
            // 
            this.hotBoxTemperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "HotBoxTemperature", true));
            this.hotBoxTemperatureTextBox.Location = new System.Drawing.Point(179, 170);
            this.hotBoxTemperatureTextBox.Name = "hotBoxTemperatureTextBox";
            this.hotBoxTemperatureTextBox.Size = new System.Drawing.Size(200, 20);
            this.hotBoxTemperatureTextBox.TabIndex = 12;
            // 
            // rPMLabel
            // 
            rPMLabel.AutoSize = true;
            rPMLabel.Location = new System.Drawing.Point(40, 199);
            rPMLabel.Name = "rPMLabel";
            rPMLabel.Size = new System.Drawing.Size(34, 13);
            rPMLabel.TabIndex = 13;
            rPMLabel.Text = "RPM:";
            // 
            // rPMTextBox
            // 
            this.rPMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "RPM", true));
            this.rPMTextBox.Location = new System.Drawing.Point(179, 196);
            this.rPMTextBox.Name = "rPMTextBox";
            this.rPMTextBox.Size = new System.Drawing.Size(200, 20);
            this.rPMTextBox.TabIndex = 14;
            // 
            // requestedTimeLabel
            // 
            requestedTimeLabel.AutoSize = true;
            requestedTimeLabel.Location = new System.Drawing.Point(40, 226);
            requestedTimeLabel.Name = "requestedTimeLabel";
            requestedTimeLabel.Size = new System.Drawing.Size(88, 13);
            requestedTimeLabel.TabIndex = 15;
            requestedTimeLabel.Text = "Requested Time:";
            // 
            // requestedTimeDateTimePicker
            // 
            this.requestedTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.testDescriptionSetupBindingSource, "RequestedTime", true));
            this.requestedTimeDateTimePicker.Location = new System.Drawing.Point(179, 222);
            this.requestedTimeDateTimePicker.Name = "requestedTimeDateTimePicker";
            this.requestedTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.requestedTimeDateTimePicker.TabIndex = 16;
            // 
            // eCVOnLabel
            // 
            eCVOnLabel.AutoSize = true;
            eCVOnLabel.Location = new System.Drawing.Point(40, 251);
            eCVOnLabel.Name = "eCVOnLabel";
            eCVOnLabel.Size = new System.Drawing.Size(45, 13);
            eCVOnLabel.TabIndex = 17;
            eCVOnLabel.Text = "ECVOn:";
            // 
            // eCVOnTextBox
            // 
            this.eCVOnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "ECVOn", true));
            this.eCVOnTextBox.Location = new System.Drawing.Point(179, 248);
            this.eCVOnTextBox.Name = "eCVOnTextBox";
            this.eCVOnTextBox.Size = new System.Drawing.Size(200, 20);
            this.eCVOnTextBox.TabIndex = 18;
            // 
            // eCVOffLabel
            // 
            eCVOffLabel.AutoSize = true;
            eCVOffLabel.Location = new System.Drawing.Point(40, 277);
            eCVOffLabel.Name = "eCVOffLabel";
            eCVOffLabel.Size = new System.Drawing.Size(45, 13);
            eCVOffLabel.TabIndex = 19;
            eCVOffLabel.Text = "ECVOff:";
            // 
            // eCVOffTextBox
            // 
            this.eCVOffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "ECVOff", true));
            this.eCVOffTextBox.Location = new System.Drawing.Point(179, 274);
            this.eCVOffTextBox.Name = "eCVOffTextBox";
            this.eCVOffTextBox.Size = new System.Drawing.Size(200, 20);
            this.eCVOffTextBox.TabIndex = 20;
            // 
            // coilOnLabel
            // 
            coilOnLabel.AutoSize = true;
            coilOnLabel.Location = new System.Drawing.Point(40, 303);
            coilOnLabel.Name = "coilOnLabel";
            coilOnLabel.Size = new System.Drawing.Size(44, 13);
            coilOnLabel.TabIndex = 21;
            coilOnLabel.Text = "Coil On:";
            // 
            // coilOnTextBox
            // 
            this.coilOnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "CoilOn", true));
            this.coilOnTextBox.Location = new System.Drawing.Point(179, 300);
            this.coilOnTextBox.Name = "coilOnTextBox";
            this.coilOnTextBox.Size = new System.Drawing.Size(200, 20);
            this.coilOnTextBox.TabIndex = 22;
            // 
            // coilOffLabel
            // 
            coilOffLabel.AutoSize = true;
            coilOffLabel.Location = new System.Drawing.Point(40, 329);
            coilOffLabel.Name = "coilOffLabel";
            coilOffLabel.Size = new System.Drawing.Size(44, 13);
            coilOffLabel.TabIndex = 23;
            coilOffLabel.Text = "Coil Off:";
            // 
            // coilOffTextBox
            // 
            this.coilOffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testDescriptionSetupBindingSource, "CoilOff", true));
            this.coilOffTextBox.Location = new System.Drawing.Point(179, 326);
            this.coilOffTextBox.Name = "coilOffTextBox";
            this.coilOffTextBox.Size = new System.Drawing.Size(200, 20);
            this.coilOffTextBox.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 366);
            this.Controls.Add(iD_TestSetupLabel);
            this.Controls.Add(this.iD_TestSetupTextBox);
            this.Controls.Add(testNameLabel);
            this.Controls.Add(this.testNameTextBox);
            this.Controls.Add(stepLabel);
            this.Controls.Add(this.stepTextBox);
            this.Controls.Add(pressureDischargeSetupLabel);
            this.Controls.Add(this.pressureDischargeSetupTextBox);
            this.Controls.Add(pressureSuctionSetupLabel);
            this.Controls.Add(this.pressureSuctionSetupTextBox);
            this.Controls.Add(hotBoxTemperatureLabel);
            this.Controls.Add(this.hotBoxTemperatureTextBox);
            this.Controls.Add(rPMLabel);
            this.Controls.Add(this.rPMTextBox);
            this.Controls.Add(requestedTimeLabel);
            this.Controls.Add(this.requestedTimeDateTimePicker);
            this.Controls.Add(eCVOnLabel);
            this.Controls.Add(this.eCVOnTextBox);
            this.Controls.Add(eCVOffLabel);
            this.Controls.Add(this.eCVOffTextBox);
            this.Controls.Add(coilOnLabel);
            this.Controls.Add(this.coilOnTextBox);
            this.Controls.Add(coilOffLabel);
            this.Controls.Add(this.coilOffTextBox);
            this.Controls.Add(this.testDescriptionSetupBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionSetupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDescriptionSetupBindingNavigator)).EndInit();
            this.testDescriptionSetupBindingNavigator.ResumeLayout(false);
            this.testDescriptionSetupBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource testDescriptionSetupBindingSource;
        private Database1DataSetTableAdapters.TestDescriptionSetupTableAdapter testDescriptionSetupTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testDescriptionSetupBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testDescriptionSetupBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_TestSetupTextBox;
        private System.Windows.Forms.TextBox testNameTextBox;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.TextBox pressureDischargeSetupTextBox;
        private System.Windows.Forms.TextBox pressureSuctionSetupTextBox;
        private System.Windows.Forms.TextBox hotBoxTemperatureTextBox;
        private System.Windows.Forms.TextBox rPMTextBox;
        private System.Windows.Forms.DateTimePicker requestedTimeDateTimePicker;
        private System.Windows.Forms.TextBox eCVOnTextBox;
        private System.Windows.Forms.TextBox eCVOffTextBox;
        private System.Windows.Forms.TextBox coilOnTextBox;
        private System.Windows.Forms.TextBox coilOffTextBox;
    }
}