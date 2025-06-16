namespace EquipEase
{
    partial class ReturnEquipment
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
            this.comboBoxEquipId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxReturnBranch = new System.Windows.Forms.ComboBox();
            this.listViewDispRentInfo = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToStartPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.goToRecordsPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToReportsPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEquipId
            // 
            this.comboBoxEquipId.FormattingEnabled = true;
            this.comboBoxEquipId.Location = new System.Drawing.Point(211, 71);
            this.comboBoxEquipId.Name = "comboBoxEquipId";
            this.comboBoxEquipId.Size = new System.Drawing.Size(182, 21);
            this.comboBoxEquipId.TabIndex = 0;
            this.comboBoxEquipId.SelectedIndexChanged += new System.EventHandler(this.comboBoxEquipId_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Return Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.CustomFormat = "";
            this.dateTimePickerReturn.Location = new System.Drawing.Point(201, 295);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(192, 20);
            this.dateTimePickerReturn.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Equipment ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Return To:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxReturnBranch
            // 
            this.comboBoxReturnBranch.FormattingEnabled = true;
            this.comboBoxReturnBranch.Location = new System.Drawing.Point(201, 251);
            this.comboBoxReturnBranch.Name = "comboBoxReturnBranch";
            this.comboBoxReturnBranch.Size = new System.Drawing.Size(162, 21);
            this.comboBoxReturnBranch.TabIndex = 54;
            this.comboBoxReturnBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxReturnBranch_SelectedIndexChanged);
            // 
            // listViewDispRentInfo
            // 
            this.listViewDispRentInfo.HideSelection = false;
            this.listViewDispRentInfo.Location = new System.Drawing.Point(79, 164);
            this.listViewDispRentInfo.Name = "listViewDispRentInfo";
            this.listViewDispRentInfo.Size = new System.Drawing.Size(474, 81);
            this.listViewDispRentInfo.TabIndex = 56;
            this.listViewDispRentInfo.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Customer Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(211, 109);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(182, 21);
            this.comboBoxEmail.TabIndex = 57;
            this.comboBoxEmail.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmail_SelectedIndexChanged);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(224, 336);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(108, 23);
            this.buttonReturn.TabIndex = 59;
            this.buttonReturn.Text = "Process Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToStartPageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.goToRecordsPageToolStripMenuItem,
            this.hireEquipmentToolStripMenuItem,
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
            // goToRecordsPageToolStripMenuItem
            // 
            this.goToRecordsPageToolStripMenuItem.Name = "goToRecordsPageToolStripMenuItem";
            this.goToRecordsPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToRecordsPageToolStripMenuItem.Text = "View Rental Records";
            this.goToRecordsPageToolStripMenuItem.Click += new System.EventHandler(this.goToRecordsPageToolStripMenuItem_Click);
            // 
            // hireEquipmentToolStripMenuItem
            // 
            this.hireEquipmentToolStripMenuItem.Name = "hireEquipmentToolStripMenuItem";
            this.hireEquipmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hireEquipmentToolStripMenuItem.Text = "Hire Equipment";
            this.hireEquipmentToolStripMenuItem.Click += new System.EventHandler(this.hireEquipmentToolStripMenuItem_Click);
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
            // ReturnEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.listViewDispRentInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxReturnBranch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerReturn);
            this.Controls.Add(this.comboBoxEquipId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReturnEquipment";
            this.Text = "ReturnEquipment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEquipId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxReturnBranch;
        private System.Windows.Forms.ListView listViewDispRentInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToStartPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goToRecordsPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToReportsPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}