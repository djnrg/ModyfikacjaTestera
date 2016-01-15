namespace Stoper
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
            this.butSTART = new System.Windows.Forms.Button();
            this.butRESET = new System.Windows.Forms.Button();
            this.butKONIEC = new System.Windows.Forms.Button();
            this.labCZAS = new System.Windows.Forms.Label();
            this.labSTOPER = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // butSTART
            // 
            this.butSTART.Location = new System.Drawing.Point(12, 68);
            this.butSTART.Name = "butSTART";
            this.butSTART.Size = new System.Drawing.Size(75, 23);
            this.butSTART.TabIndex = 0;
            this.butSTART.Text = "START";
            this.butSTART.UseVisualStyleBackColor = true;
            this.butSTART.Click += new System.EventHandler(this.butSTART_Click);
            // 
            // butRESET
            // 
            this.butRESET.Location = new System.Drawing.Point(100, 68);
            this.butRESET.Name = "butRESET";
            this.butRESET.Size = new System.Drawing.Size(68, 23);
            this.butRESET.TabIndex = 2;
            this.butRESET.Text = "RESET";
            this.butRESET.UseVisualStyleBackColor = true;
            this.butRESET.Click += new System.EventHandler(this.butRESET_Click);
            // 
            // butKONIEC
            // 
            this.butKONIEC.Location = new System.Drawing.Point(12, 97);
            this.butKONIEC.Name = "butKONIEC";
            this.butKONIEC.Size = new System.Drawing.Size(156, 23);
            this.butKONIEC.TabIndex = 3;
            this.butKONIEC.Text = "KONIEC";
            this.butKONIEC.UseVisualStyleBackColor = true;
            this.butKONIEC.Click += new System.EventHandler(this.butKONIEC_Click);
            // 
            // labCZAS
            // 
            this.labCZAS.AutoSize = true;
            this.labCZAS.Location = new System.Drawing.Point(12, 9);
            this.labCZAS.Name = "labCZAS";
            this.labCZAS.Size = new System.Drawing.Size(35, 13);
            this.labCZAS.TabIndex = 4;
            this.labCZAS.Text = "CZAS";
            // 
            // labSTOPER
            // 
            this.labSTOPER.AutoSize = true;
            this.labSTOPER.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.labSTOPER.Font = new System.Drawing.Font("Proxy 6", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSTOPER.Location = new System.Drawing.Point(12, 28);
            this.labSTOPER.Name = "labSTOPER";
            this.labSTOPER.Size = new System.Drawing.Size(159, 37);
            this.labSTOPER.TabIndex = 5;
            this.labSTOPER.Text = "000:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(188, 136);
            this.Controls.Add(this.labSTOPER);
            this.Controls.Add(this.labCZAS);
            this.Controls.Add(this.butKONIEC);
            this.Controls.Add(this.butRESET);
            this.Controls.Add(this.butSTART);
            this.Name = "Form1";
            this.Text = "STOPER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSTART;
        private System.Windows.Forms.Button butRESET;
        private System.Windows.Forms.Button butKONIEC;
        private System.Windows.Forms.Label labCZAS;
        private System.Windows.Forms.Label labSTOPER;
        private System.Windows.Forms.Timer timer1;
    }
}

