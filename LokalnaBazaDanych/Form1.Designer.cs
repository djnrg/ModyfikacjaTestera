namespace LokalnaBazaDanych
{
    partial class Form1
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
            this.adresyDataSet = new LokalnaBazaDanych.AdresyDataSet();
            this.osobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobyTableAdapter = new LokalnaBazaDanych.AdresyDataSetTableAdapters.OsobyTableAdapter();
            this.tableAdapterManager = new LokalnaBazaDanych.AdresyDataSetTableAdapters.TableAdapterManager();
            this.osobyTableAdapter1 = new LokalnaBazaDanych.AdresyDataSetTableAdapters.OsobyTableAdapter();
            this.view3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view3TableAdapter = new LokalnaBazaDanych.AdresyDataSetTableAdapters.View3TableAdapter();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view2TableAdapter = new LokalnaBazaDanych.AdresyDataSetTableAdapters.View2TableAdapter();
            this.fKKontaktOsoby2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontaktTableAdapter = new LokalnaBazaDanych.AdresyDataSetTableAdapters.KontaktTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDomuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adresyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKontaktOsoby2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adresyDataSet
            // 
            this.adresyDataSet.DataSetName = "AdresyDataSet";
            this.adresyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osobyBindingSource
            // 
            this.osobyBindingSource.DataMember = "Osoby";
            this.osobyBindingSource.DataSource = this.adresyDataSet;
            // 
            // osobyTableAdapter
            // 
            this.osobyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KontaktTableAdapter = null;
            this.tableAdapterManager.OsobyTableAdapter = this.osobyTableAdapter;
            this.tableAdapterManager.UpdateOrder = LokalnaBazaDanych.AdresyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // osobyTableAdapter1
            // 
            this.osobyTableAdapter1.ClearBeforeFill = true;
            // 
            // view3BindingSource
            // 
            this.view3BindingSource.DataMember = "View3";
            this.view3BindingSource.DataSource = this.adresyDataSet;
            // 
            // view3TableAdapter
            // 
            this.view3TableAdapter.ClearBeforeFill = true;
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "View2";
            this.view2BindingSource.DataSource = this.adresyDataSet;
            // 
            // view2TableAdapter
            // 
            this.view2TableAdapter.ClearBeforeFill = true;
            // 
            // fKKontaktOsoby2BindingSource
            // 
            this.fKKontaktOsoby2BindingSource.DataMember = "FK_Kontakt_Osoby2";
            this.fKKontaktOsoby2BindingSource.DataSource = this.osobyBindingSource;
            // 
            // kontaktTableAdapter
            // 
            this.kontaktTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.nrDomuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.osobyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // nrDomuDataGridViewTextBoxColumn
            // 
            this.nrDomuDataGridViewTextBoxColumn.DataPropertyName = "Nr domu";
            this.nrDomuDataGridViewTextBoxColumn.HeaderText = "Nr domu";
            this.nrDomuDataGridViewTextBoxColumn.Name = "nrDomuDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 387);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adresyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKontaktOsoby2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdresyDataSet adresyDataSet;
        private System.Windows.Forms.BindingSource osobyBindingSource;
        private AdresyDataSetTableAdapters.OsobyTableAdapter osobyTableAdapter;
        private AdresyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AdresyDataSetTableAdapters.OsobyTableAdapter osobyTableAdapter1;
        private System.Windows.Forms.BindingSource view3BindingSource;
        private AdresyDataSetTableAdapters.View3TableAdapter view3TableAdapter;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private AdresyDataSetTableAdapters.View2TableAdapter view2TableAdapter;
        private System.Windows.Forms.BindingSource fKKontaktOsoby2BindingSource;
        private AdresyDataSetTableAdapters.KontaktTableAdapter kontaktTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDomuDataGridViewTextBoxColumn;
    }
}

