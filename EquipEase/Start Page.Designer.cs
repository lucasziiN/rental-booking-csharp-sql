namespace EquipEase
{
    partial class StartPage
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
            this.buttonRecords = new System.Windows.Forms.Button();
            this.buttonHire = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRecords
            // 
            this.buttonRecords.Location = new System.Drawing.Point(52, 120);
            this.buttonRecords.Name = "button1";
            this.buttonRecords.Size = new System.Drawing.Size(105, 26);
            this.buttonRecords.TabIndex = 0;
            this.buttonRecords.Text = "View Records";
            this.buttonRecords.UseVisualStyleBackColor = true;
            this.buttonRecords.Click += new System.EventHandler(this.buttonRecords_Click);
            // 
            // buttonHire
            // 
            this.buttonHire.Location = new System.Drawing.Point(274, 120);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(105, 26);
            this.buttonHire.TabIndex = 1;
            this.buttonHire.Text = "Hire Equipment";
            this.buttonHire.UseVisualStyleBackColor = true;
            this.buttonHire.Click += new System.EventHandler(this.buttonHire_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(163, 120);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(105, 26);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Return Equipment";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(151, 167);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(131, 26);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "View Summary Reports";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(151, 217);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 26);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit Application";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 332);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonHire);
            this.Controls.Add(this.buttonRecords);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRecords;
        private System.Windows.Forms.Button buttonHire;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonExit;
    }
}

