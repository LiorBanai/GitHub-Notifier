﻿namespace GitHubNotifier.UserControls
{
    partial class RepositoryEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCheckNow = new System.Windows.Forms.Button();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblNext = new System.Windows.Forms.Label();
            this.lblViews = new System.Windows.Forms.Label();
            this.lnklblIssues = new System.Windows.Forms.LinkLabel();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblDownloads = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckNow.Location = new System.Drawing.Point(1136, 11);
            this.btnCheckNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(124, 26);
            this.btnCheckNow.TabIndex = 2;
            this.btnCheckNow.Text = "Check Now";
            this.btnCheckNow.UseVisualStyleBackColor = true;
            this.btnCheckNow.Click += new System.EventHandler(this.btnCheckNow_Click);
            // 
            // lnkLabel
            // 
            this.lnkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLabel.Location = new System.Drawing.Point(5, 1);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(192, 44);
            this.lnkLabel.TabIndex = 3;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "N/A";
            this.lnkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabel_LinkClicked);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 900000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // lblNext
            // 
            this.lblNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNext.Location = new System.Drawing.Point(913, 1);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(217, 44);
            this.lblNext.TabIndex = 4;
            this.lblNext.Text = "Next Check:";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblViews
            // 
            this.lblViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViews.Image = global::GitHubNotifier.Properties.Resources.Show_32x32;
            this.lblViews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblViews.Location = new System.Drawing.Point(743, 2);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(164, 44);
            this.lblViews.TabIndex = 7;
            this.lblViews.Text = "Views:";
            this.lblViews.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnklblIssues
            // 
            this.lnklblIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklblIssues.Image = global::GitHubNotifier.Properties.Resources.Issue_32x32;
            this.lnklblIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnklblIssues.Location = new System.Drawing.Point(549, 1);
            this.lnklblIssues.Name = "lnklblIssues";
            this.lnklblIssues.Size = new System.Drawing.Size(188, 44);
            this.lnklblIssues.TabIndex = 6;
            this.lnklblIssues.TabStop = true;
            this.lnklblIssues.Text = "Open Issues:";
            this.lnklblIssues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklblIssues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblIssues_LinkClicked);
            // 
            // lblLikes
            // 
            this.lblLikes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLikes.Image = global::GitHubNotifier.Properties.Resources.Feature_32x32;
            this.lblLikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLikes.Location = new System.Drawing.Point(203, 1);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(151, 44);
            this.lblLikes.TabIndex = 1;
            this.lblLikes.Text = "Likes:";
            this.lblLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDownloads
            // 
            this.lblDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDownloads.Image = global::GitHubNotifier.Properties.Resources.Download_32x32;
            this.lblDownloads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDownloads.Location = new System.Drawing.Point(360, 1);
            this.lblDownloads.Name = "lblDownloads";
            this.lblDownloads.Size = new System.Drawing.Size(183, 44);
            this.lblDownloads.TabIndex = 0;
            this.lblDownloads.Text = "Downloads:";
            this.lblDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepositoryEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblViews);
            this.Controls.Add(this.lnklblIssues);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lnkLabel);
            this.Controls.Add(this.btnCheckNow);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblDownloads);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RepositoryEntry";
            this.Size = new System.Drawing.Size(1263, 48);
            this.Load += new System.EventHandler(this.RepositoryEntry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDownloads;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Button btnCheckNow;
        private System.Windows.Forms.LinkLabel lnkLabel;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.LinkLabel lnklblIssues;
        private System.Windows.Forms.Label lblViews;
    }
}
