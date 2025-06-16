namespace EquipEase
{
    partial class HireEquipment
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
            this.comboBoxTypeEquip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.textBoxAvailability = new System.Windows.Forms.TextBox();
            this.buttonCustomerDetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToStartPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToReportsPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTypeEquip
            // 
            this.comboBoxTypeEquip.FormattingEnabled = true;
            this.comboBoxTypeEquip.Location = new System.Drawing.Point(297, 88);
            this.comboBoxTypeEquip.Name = "comboBoxTypeEquip";
            this.comboBoxTypeEquip.Size = new System.Drawing.Size(183, 21);
            this.comboBoxTypeEquip.TabIndex = 0;
            this.comboBoxTypeEquip.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeEquip_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type of Equipment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branch";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(297, 128);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(183, 21);
            this.comboBoxBranch.TabIndex = 9;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // textBoxAvailability
            // 
            this.textBoxAvailability.Location = new System.Drawing.Point(293, 219);
            this.textBoxAvailability.Name = "textBoxAvailability";
            this.textBoxAvailability.ReadOnly = true;
            this.textBoxAvailability.Size = new System.Drawing.Size(109, 20);
            this.textBoxAvailability.TabIndex = 12;
            // 
            // buttonCustomerDetails
            // 
            this.buttonCustomerDetails.Location = new System.Drawing.Point(279, 258);
            this.buttonCustomerDetails.Name = "buttonCustomerDetails";
            this.buttonCustomerDetails.Size = new System.Drawing.Size(138, 27);
            this.buttonCustomerDetails.TabIndex = 13;
            this.buttonCustomerDetails.Text = "Proceed to Details Page";
            this.buttonCustomerDetails.UseVisualStyleBackColor = true;
            this.buttonCustomerDetails.Click += new System.EventHandler(this.buttonCustomerDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hourly Rate";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(297, 182);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(109, 20);
            this.textBoxRate.TabIndex = 16;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(207, 222);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 17;
            this.Status.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToStartPageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewRentalRecordsToolStripMenuItem,
            this.returnEquipmentToolStripMenuItem,
            this.goToReportsPageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // goToStartPageToolStripMenuItem
            // 
            this.goToStartPageToolStripMenuItem.Name = "goToStartPageToolStripMenuItem";
            this.goToStartPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToStartPageToolStripMenuItem.Text = "Go to Start Page";
            this.goToStartPageToolStripMenuItem.Click += new System.EventHandler(this.goToStartPageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // viewRentalRecordsToolStripMenuItem
            // 
            this.viewRentalRecordsToolStripMenuItem.Name = "viewRentalRecordsToolStripMenuItem";
            this.viewRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewRentalRecordsToolStripMenuItem.Text = "View Rental Records";
            this.viewRentalRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewRentalRecordsToolStripMenuItem_Click);
            // 
            // returnEquipmentToolStripMenuItem
            // 
            this.returnEquipmentToolStripMenuItem.Name = "returnEquipmentToolStripMenuItem";
            this.returnEquipmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnEquipmentToolStripMenuItem.Text = "Return Equipment";
            this.returnEquipmentToolStripMenuItem.Click += new System.EventHandler(this.returnEquipmentToolStripMenuItem_Click);
            // 
            // goToReportsPageToolStripMenuItem
            // 
            this.goToReportsPageToolStripMenuItem.Name = "goToReportsPageToolStripMenuItem";
            this.goToReportsPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToReportsPageToolStripMenuItem.Text = "Go to Reports Page";
            this.goToReportsPageToolStripMenuItem.Click += new System.EventHandler(this.goToReportsPageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HireEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCustomerDetails);
            this.Controls.Add(this.textBoxAvailability);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeEquip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HireEquipment";
            this.Text = "HireEquipment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypeEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.TextBox textBoxAvailability;
        private System.Windows.Forms.Button buttonCustomerDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToStartPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToReportsPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}