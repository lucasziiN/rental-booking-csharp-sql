namespace EquipEase
{
    partial class RentalRecords
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
            this.Search = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToStartPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.hireEquipmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToReportsPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(204, 45);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(85, 45);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(88, 21);
            this.comboBoxStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter by:";
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(24, 100);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(835, 342);
            this.listViewDisplay.TabIndex = 5;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToStartPageToolStripMenuItem,
            this.hireEquipmentToolStripMenuItem,
            this.hireEquipmentToolStripMenuItem1,
            this.returnEquipmentToolStripMenuItem,
            this.goToReportsPageToolStripMenuItem,
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
            // hireEquipmentToolStripMenuItem
            // 
            this.hireEquipmentToolStripMenuItem.Name = "hireEquipmentToolStripMenuItem";
            this.hireEquipmentToolStripMenuItem.Size = new System.Drawing.Size(176, 6);
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
            // goToReportsPageToolStripMenuItem
            // 
            this.goToReportsPageToolStripMenuItem.Name = "goToReportsPageToolStripMenuItem";
            this.goToReportsPageToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.goToReportsPageToolStripMenuItem.Text = "Go to Reports Page";
            this.goToReportsPageToolStripMenuItem.Click += new System.EventHandler(this.goToReportsPageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // RentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 494);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.Search);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RentalRecords";
            this.Text = "RentalRecords";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToStartPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator hireEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEquipmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToReportsPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}