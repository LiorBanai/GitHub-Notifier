﻿namespace GitHubNotifier.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsForm));
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
            this.chkbLikes = new System.Windows.Forms.CheckBox();
            this.chkbDownloads = new System.Windows.Forms.CheckBox();
            this.chkbViews = new System.Windows.Forms.CheckBox();
            this.chkbOpenIssues = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifications)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chklstRepo
            // 
            this.chklstRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstRepo.FormattingEnabled = true;
            this.chklstRepo.Location = new System.Drawing.Point(3, 162);
            this.chklstRepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chklstRepo.Name = "chklstRepo";
            this.chklstRepo.Size = new System.Drawing.Size(733, 259);
            this.chklstRepo.TabIndex = 0;
            this.chklstRepo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstRepo_ItemCheck);
            this.chklstRepo.SelectedIndexChanged += new System.EventHandler(this.chklstRepo_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(755, 169);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(12, 63);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(231, 17);
            this.lblRepo.TabIndex = 2;
            this.lblRepo.Text = "Repository name (as in User/Repo)";
            // 
            // lblRepoDisplayName
            // 
            this.lblRepoDisplayName.AutoSize = true;
            this.lblRepoDisplayName.Location = new System.Drawing.Point(12, 94);
            this.lblRepoDisplayName.Name = "lblRepoDisplayName";
            this.lblRepoDisplayName.Size = new System.Drawing.Size(99, 17);
            this.lblRepoDisplayName.TabIndex = 4;
            this.lblRepoDisplayName.Text = "Display Name:";
            // 
            // txtbRepoDisplayName
            // 
            this.txtbRepoDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRepoDisplayName.Location = new System.Drawing.Point(307, 94);
            this.txtbRepoDisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbRepoDisplayName.Name = "txtbRepoDisplayName";
            this.txtbRepoDisplayName.Size = new System.Drawing.Size(429, 22);
            this.txtbRepoDisplayName.TabIndex = 5;
            // 
            // txtbRepoName
            // 
            this.txtbRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRepoName.Location = new System.Drawing.Point(307, 66);
            this.txtbRepoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbRepoName.Name = "txtbRepoName";
            this.txtbRepoName.Size = new System.Drawing.Size(429, 22);
            this.txtbRepoName.TabIndex = 6;
            // 
            // btnAddRepo
            // 
            this.btnAddRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRepo.Location = new System.Drawing.Point(755, 69);
            this.btnAddRepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRepo.Name = "btnAddRepo";
            this.btnAddRepo.Size = new System.Drawing.Size(157, 34);
            this.btnAddRepo.TabIndex = 7;
            this.btnAddRepo.Text = "Add Repository";
            this.btnAddRepo.UseVisualStyleBackColor = true;
            this.btnAddRepo.Click += new System.EventHandler(this.btnAddRepo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Interval check (minutes):";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinutes.Location = new System.Drawing.Point(604, 130);
            this.nudMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nudMinutes.Size = new System.Drawing.Size(131, 22);
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
            this.nudNotifications.Location = new System.Drawing.Point(604, 579);
            this.nudNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nudNotifications.Size = new System.Drawing.Size(131, 22);
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
            this.lblNotifications.Location = new System.Drawing.Point(12, 579);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(202, 17);
            this.lblNotifications.TabIndex = 10;
            this.lblNotifications.Text = "Notifications Interval (minutes):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(893, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "GitHub limits number of API call to 60 per hour. Add Environment Variable with ke" +
    "y \"GitHubNotifier_Token\" with valid token to get 5000 calls per hour";
            // 
            // chkbLikes
            // 
            this.chkbLikes.AutoSize = true;
            this.chkbLikes.Location = new System.Drawing.Point(9, 23);
            this.chkbLikes.Name = "chkbLikes";
            this.chkbLikes.Size = new System.Drawing.Size(152, 21);
            this.chkbLikes.TabIndex = 12;
            this.chkbLikes.Text = "Enable Likes Count";
            this.chkbLikes.UseVisualStyleBackColor = true;
            this.chkbLikes.CheckedChanged += new System.EventHandler(this.chkbLikes_CheckedChanged);
            // 
            // chkbDownloads
            // 
            this.chkbDownloads.AutoSize = true;
            this.chkbDownloads.Location = new System.Drawing.Point(9, 50);
            this.chkbDownloads.Name = "chkbDownloads";
            this.chkbDownloads.Size = new System.Drawing.Size(181, 21);
            this.chkbDownloads.TabIndex = 13;
            this.chkbDownloads.Text = "Enable Download Count";
            this.chkbDownloads.UseVisualStyleBackColor = true;
            this.chkbDownloads.CheckedChanged += new System.EventHandler(this.chkbDownloads_CheckedChanged);
            // 
            // chkbViews
            // 
            this.chkbViews.AutoSize = true;
            this.chkbViews.Location = new System.Drawing.Point(9, 103);
            this.chkbViews.Name = "chkbViews";
            this.chkbViews.Size = new System.Drawing.Size(155, 21);
            this.chkbViews.TabIndex = 15;
            this.chkbViews.Text = "Enable Views Count";
            this.chkbViews.UseVisualStyleBackColor = true;
            this.chkbViews.CheckedChanged += new System.EventHandler(this.chkbViews_CheckedChanged);
            // 
            // chkbOpenIssues
            // 
            this.chkbOpenIssues.AutoSize = true;
            this.chkbOpenIssues.Location = new System.Drawing.Point(9, 76);
            this.chkbOpenIssues.Name = "chkbOpenIssues";
            this.chkbOpenIssues.Size = new System.Drawing.Size(198, 21);
            this.chkbOpenIssues.TabIndex = 14;
            this.chkbOpenIssues.Text = "Enable Open Issues Count";
            this.chkbOpenIssues.UseVisualStyleBackColor = true;
            this.chkbOpenIssues.CheckedChanged += new System.EventHandler(this.chkbOpenIssues_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkbLikes);
            this.groupBox1.Controls.Add(this.chkbViews);
            this.groupBox1.Controls.Add(this.chkbDownloads);
            this.groupBox1.Controls.Add(this.chkbOpenIssues);
            this.groupBox1.Location = new System.Drawing.Point(3, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 136);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected:";
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 621);
            this.Controls.Add(this.groupBox1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserSettingsForm";
            this.Text = "User Settings ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifications)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkbLikes;
        private System.Windows.Forms.CheckBox chkbDownloads;
        private System.Windows.Forms.CheckBox chkbViews;
        private System.Windows.Forms.CheckBox chkbOpenIssues;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

