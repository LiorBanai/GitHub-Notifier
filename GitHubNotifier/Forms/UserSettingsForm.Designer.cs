namespace GitHubNotifier.Forms
{
    partial class UserSettingsForm
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
            this.chklstRepo = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRepo = new System.Windows.Forms.Label();
            this.lblRepoDisplayName = new System.Windows.Forms.Label();
            this.txtbRepoDisplayName = new System.Windows.Forms.TextBox();
            this.txtbRepoName = new System.Windows.Forms.TextBox();
            this.btnAddRepo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudNotifications = new System.Windows.Forms.NumericUpDown();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // chklstRepo
            // 
            this.chklstRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstRepo.FormattingEnabled = true;
            this.chklstRepo.Location = new System.Drawing.Point(2, 132);
            this.chklstRepo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chklstRepo.Name = "chklstRepo";
            this.chklstRepo.Size = new System.Drawing.Size(482, 184);
            this.chklstRepo.TabIndex = 0;
            this.chklstRepo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstRepo_ItemCheck);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(497, 236);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(9, 51);
            this.lblRepo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(173, 13);
            this.lblRepo.TabIndex = 2;
            this.lblRepo.Text = "Repository name (as in User/Repo)";
            // 
            // lblRepoDisplayName
            // 
            this.lblRepoDisplayName.AutoSize = true;
            this.lblRepoDisplayName.Location = new System.Drawing.Point(9, 76);
            this.lblRepoDisplayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepoDisplayName.Name = "lblRepoDisplayName";
            this.lblRepoDisplayName.Size = new System.Drawing.Size(75, 13);
            this.lblRepoDisplayName.TabIndex = 4;
            this.lblRepoDisplayName.Text = "Display Name:";
            // 
            // txtbRepoDisplayName
            // 
            this.txtbRepoDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRepoDisplayName.Location = new System.Drawing.Point(230, 76);
            this.txtbRepoDisplayName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbRepoDisplayName.Name = "txtbRepoDisplayName";
            this.txtbRepoDisplayName.Size = new System.Drawing.Size(254, 20);
            this.txtbRepoDisplayName.TabIndex = 5;
            // 
            // txtbRepoName
            // 
            this.txtbRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRepoName.Location = new System.Drawing.Point(230, 54);
            this.txtbRepoName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbRepoName.Name = "txtbRepoName";
            this.txtbRepoName.Size = new System.Drawing.Size(254, 20);
            this.txtbRepoName.TabIndex = 6;
            // 
            // btnAddRepo
            // 
            this.btnAddRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRepo.Location = new System.Drawing.Point(497, 56);
            this.btnAddRepo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRepo.Name = "btnAddRepo";
            this.btnAddRepo.Size = new System.Drawing.Size(118, 28);
            this.btnAddRepo.TabIndex = 7;
            this.btnAddRepo.Text = "Add Repository";
            this.btnAddRepo.UseVisualStyleBackColor = true;
            this.btnAddRepo.Click += new System.EventHandler(this.btnAddRepo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Interval check (minutes):";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinutes.Location = new System.Drawing.Point(384, 106);
            this.nudMinutes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudMinutes.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMinutes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(98, 20);
            this.nudMinutes.TabIndex = 9;
            this.nudMinutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nudNotifications
            // 
            this.nudNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNotifications.Location = new System.Drawing.Point(384, 344);
            this.nudNotifications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNotifications.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudNotifications.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNotifications.Name = "nudNotifications";
            this.nudNotifications.Size = new System.Drawing.Size(98, 20);
            this.nudNotifications.TabIndex = 11;
            this.nudNotifications.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblNotifications
            // 
            this.lblNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Location = new System.Drawing.Point(9, 344);
            this.lblNotifications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(151, 13);
            this.lblNotifications.TabIndex = 10;
            this.lblNotifications.Text = "Notifications Interval (minutes):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "GitHub limits number of API call to 60 per hour. Add Environment Variable with ke" +
    "y \"GitHubNotifier_Token\" with valid token to get 5000 calls per hour";
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 366);
            this.Controls.Add(this.nudNotifications);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRepo);
            this.Controls.Add(this.txtbRepoName);
            this.Controls.Add(this.txtbRepoDisplayName);
            this.Controls.Add(this.lblRepoDisplayName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRepo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chklstRepo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserSettingsForm";
            this.Text = "User settings form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstRepo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRepo;
        private System.Windows.Forms.Label lblRepoDisplayName;
        private System.Windows.Forms.TextBox txtbRepoDisplayName;
        private System.Windows.Forms.TextBox txtbRepoName;
        private System.Windows.Forms.Button btnAddRepo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.NumericUpDown nudNotifications;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Label label2;
    }
}

