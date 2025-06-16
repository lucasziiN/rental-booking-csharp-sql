namespace EquipEase
{
    partial class Reports
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
            this.listBoxReports = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToStartPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireEquipmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxReports
            // 
            this.listBoxReports.FormattingEnabled = true;
            this.listBoxReports.Location = new System.Drawing.Point(57, 73);
            this.listBoxReports.Name = "listBoxReports";
            this.listBoxReports.Size = new System.Drawing.Size(691, 277);
            this.listBoxReports.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToStartPageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewRentalRecordsToolStripMenuItem,
            this.hireEquipmentToolStripMenuItem1,
            this.returnEquipmentToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // returnToStartPageToolStripMenuItem
            // 
            this.returnToStartPageToolStripMenuItem.Name = "returnToStartPageToolStripMenuItem";
            this.returnToStartPageToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.returnToStartPageToolStripMenuItem.Text = "Return to Start Page";
            this.returnToStartPageToolStripMenuItem.Click += new System.EventHandler(this.returnToStartPageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // viewRentalRecordsToolStripMenuItem
            // 
            this.viewRentalRecordsToolStripMenuItem.Name = "viewRentalRecordsToolStripMenuItem";
            this.viewRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.viewRentalRecordsToolStripMenuItem.Text = "Go to Records Page";
            this.viewRentalRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewRentalRecordsToolStripMenuItem_Click);
            // 
            // hireEquipmentToolStripMenuItem1
            // 
            this.hireEquipmentToolStripMenuItem1.Name = "hireEquipmentToolStripMenuItem1";
            this.hireEquipmentToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.hireEquipmentToolStripMenuItem1.Text = "Hire Equipment";
            this.hireEquipmentToolStripMenuItem1.Click += new System.EventHandler(this.hireEquipmentToolStripMenuItem1_Click);
            // 
            // returnEquipmentToolStripMenuItem
            // 
            this.returnEquipmentToolStripMenuItem.Name = "returnEquipmentToolStripMenuItem";
            this.returnEquipmentToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.returnEquipmentToolStripMenuItem.Text = "Return Equipment";
            this.returnEquipmentToolStripMenuItem.Click += new System.EventHandler(this.returnEquipmentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxReports);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports";
            this.Text = "Reports";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxReports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToStartPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEquipmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}