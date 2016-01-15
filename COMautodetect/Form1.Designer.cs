namespace COMautodetect
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
            this.button1 = new System.Windows.Forms.Button();
            this.ComBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BaudCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.gauge1 = new NationalInstruments.UI.WindowsForms.Gauge();
            this.gauge2 = new NationalInstruments.UI.WindowsForms.Gauge();
            this.thermometer1 = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.tank1 = new NationalInstruments.UI.WindowsForms.Tank();
            this.meter1 = new NationalInstruments.UI.WindowsForms.Meter();
            this.label3 = new System.Windows.Forms.Label();
            this.led1 = new NationalInstruments.UI.WindowsForms.Led();
            this.switch1 = new NationalInstruments.UI.WindowsForms.Switch();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycaDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComBox
            // 
            this.ComBox.FormattingEnabled = true;
            this.ComBox.Location = new System.Drawing.Point(70, 9);
            this.ComBox.Name = "ComBox";
            this.ComBox.Size = new System.Drawing.Size(121, 21);
            this.ComBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com Port";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // COM
            // 
            this.COM.BaudRate = 115200;
            this.COM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnCom);
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(3, 73);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(64, 19);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Disconnect";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BaudCombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.ComBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 114);
            this.panel1.TabIndex = 4;
            // 
            // BaudCombo
            // 
            this.BaudCombo.FormattingEnabled = true;
            this.BaudCombo.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.BaudCombo.Location = new System.Drawing.Point(70, 43);
            this.BaudCombo.Name = "BaudCombo";
            this.BaudCombo.Size = new System.Drawing.Size(121, 21);
            this.BaudCombo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(228, 36);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(243, 20);
            this.txtSend.TabIndex = 6;
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(477, 33);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // gauge1
            // 
            this.gauge1.Location = new System.Drawing.Point(250, 62);
            this.gauge1.Name = "gauge1";
            this.gauge1.Range = new NationalInstruments.UI.Range(20D, 45D);
            this.gauge1.Size = new System.Drawing.Size(170, 150);
            this.gauge1.TabIndex = 8;
            this.gauge1.Value = 20D;
            // 
            // gauge2
            // 
            this.gauge2.Location = new System.Drawing.Point(246, 19);
            this.gauge2.Name = "gauge2";
            this.gauge2.Range = new NationalInstruments.UI.Range(2D, 16D);
            this.gauge2.Size = new System.Drawing.Size(234, 150);
            this.gauge2.TabIndex = 9;
            this.gauge2.Value = 2D;
            // 
            // thermometer1
            // 
            this.thermometer1.Location = new System.Drawing.Point(12, 153);
            this.thermometer1.Name = "thermometer1";
            this.thermometer1.Range = new NationalInstruments.UI.Range(0D, 15D);
            this.thermometer1.Size = new System.Drawing.Size(67, 152);
            this.thermometer1.TabIndex = 10;
            // 
            // tank1
            // 
            this.tank1.CoercionInterval = 5D;
            this.tank1.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions;
            this.tank1.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tank1.Location = new System.Drawing.Point(82, 153);
            this.tank1.Name = "tank1";
            this.tank1.Range = new NationalInstruments.UI.Range(0D, 30D);
            this.tank1.Size = new System.Drawing.Size(56, 145);
            this.tank1.TabIndex = 11;
            this.tank1.TankStyle = NationalInstruments.UI.TankStyle.Flat;
            // 
            // meter1
            // 
            this.meter1.CoercionInterval = 5D;
            this.meter1.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.meter1.Location = new System.Drawing.Point(6, 19);
            this.meter1.Name = "meter1";
            this.meter1.Range = new NationalInstruments.UI.Range(0D, 15D);
            this.meter1.Size = new System.Drawing.Size(214, 119);
            this.meter1.TabIndex = 12;
            this.meter1.Value = 15D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "150";
            // 
            // led1
            // 
            this.led1.BlinkMode = NationalInstruments.UI.LedBlinkMode.BlinkWhenOn;
            this.led1.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led1.Location = new System.Drawing.Point(228, 62);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(35, 37);
            this.led1.TabIndex = 14;
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(227, 101);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(36, 56);
            this.switch1.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switch1.TabIndex = 15;
            this.switch1.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch1_StateChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 205);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(100, 93);
            this.textBox1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edycaDBToolStripMenuItem,
            this.dBSetupToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dataBaseToolStripMenuItem.Text = "DataBase";
            // 
            // edycaDBToolStripMenuItem
            // 
            this.edycaDBToolStripMenuItem.Name = "edycaDBToolStripMenuItem";
            this.edycaDBToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.edycaDBToolStripMenuItem.Text = "DB Input";
            this.edycaDBToolStripMenuItem.Click += new System.EventHandler(this.edycaDBToolStripMenuItem_Click);
            // 
            // dBSetupToolStripMenuItem
            // 
            this.dBSetupToolStripMenuItem.Name = "dBSetupToolStripMenuItem";
            this.dBSetupToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.dBSetupToolStripMenuItem.Text = "DB Setup";
            this.dBSetupToolStripMenuItem.Click += new System.EventHandler(this.dBSetupToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gauge2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.meter1);
            this.groupBox1.Location = new System.Drawing.Point(426, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 172);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thermometer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.switch1);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.tank1);
            this.Controls.Add(this.gauge1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM Port Auto Detect";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox BaudCombo;
        private System.Windows.Forms.Label label2;
        private NationalInstruments.UI.WindowsForms.Gauge gauge1;
        private NationalInstruments.UI.WindowsForms.Gauge gauge2;
        private NationalInstruments.UI.WindowsForms.Thermometer thermometer1;
        private NationalInstruments.UI.WindowsForms.Tank tank1;
        private NationalInstruments.UI.WindowsForms.Meter meter1;
        private System.Windows.Forms.Label label3;
        private NationalInstruments.UI.WindowsForms.Led led1;
        private NationalInstruments.UI.WindowsForms.Switch switch1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycaDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBSetupToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

