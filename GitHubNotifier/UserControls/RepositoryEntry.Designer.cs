namespace GitHubNotifier.UserControls
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
            this.cmsIssues = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblClones = new System.Windows.Forms.Label();
            this.lblViews = new System.Windows.Forms.Label();
            this.lnklblIssues = new System.Windows.Forms.LinkLabel();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblDownloads = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckNow.Location = new System.Drawing.Point(982, 0);
            this.btnCheckNow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(93, 21);
            this.btnCheckNow.TabIndex = 2;
            this.btnCheckNow.Text = "Check Now";
            this.btnCheckNow.UseVisualStyleBackColor = true;
            this.btnCheckNow.Click += new System.EventHandler(this.btnCheckNow_Click);
            // 
            // lnkLabel
            // 
            this.lnkLabel.Location = new System.Drawing.Point(4, 1);
            this.lnkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(144, 36);
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
            this.lblNext.Location = new System.Drawing.Point(878, 22);
            this.lblNext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(194, 15);
            this.lblNext.TabIndex = 4;
            this.lblNext.Text = "Next Check:";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmsIssues
            // 
            this.cmsIssues.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsIssues.Name = "cmsIssues";
            this.cmsIssues.Size = new System.Drawing.Size(61, 4);
            // 
            // lblClones
            // 
            this.lblClones.Image = global::GitHubNotifier.Properties.Resources.NewDataSource_32x32;
            this.lblClones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClones.Location = new System.Drawing.Point(724, 2);
            this.lblClones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClones.Name = "lblClones";
            this.lblClones.Size = new System.Drawing.Size(169, 36);
            this.lblClones.TabIndex = 8;
            this.lblClones.Text = "Clones:";
            this.lblClones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblViews
            // 
            this.lblViews.Image = global::GitHubNotifier.Properties.Resources.Show_32x32;
            this.lblViews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblViews.Location = new System.Drawing.Point(597, 2);
            this.lblViews.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(123, 36);
            this.lblViews.TabIndex = 7;
            this.lblViews.Text = "Views:";
            this.lblViews.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnklblIssues
            // 
            this.lnklblIssues.ContextMenuStrip = this.cmsIssues;
            this.lnklblIssues.Image = global::GitHubNotifier.Properties.Resources.Issue_32x32;
            this.lnklblIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnklblIssues.Location = new System.Drawing.Point(432, 1);
            this.lnklblIssues.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblIssues.Name = "lnklblIssues";
            this.lnklblIssues.Size = new System.Drawing.Size(161, 36);
            this.lnklblIssues.TabIndex = 6;
            this.lnklblIssues.TabStop = true;
            this.lnklblIssues.Text = "Open Issues:";
            this.lnklblIssues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklblIssues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblIssues_LinkClicked);
            // 
            // lblLikes
            // 
            this.lblLikes.Image = global::GitHubNotifier.Properties.Resources.Feature_32x32;
            this.lblLikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLikes.Location = new System.Drawing.Point(152, 1);
            this.lblLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(113, 36);
            this.lblLikes.TabIndex = 1;
            this.lblLikes.Text = "Likes:";
            this.lblLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDownloads
            // 
            this.lblDownloads.Image = global::GitHubNotifier.Properties.Resources.Download_32x32;
            this.lblDownloads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDownloads.Location = new System.Drawing.Point(270, 1);
            this.lblDownloads.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDownloads.Name = "lblDownloads";
            this.lblDownloads.Size = new System.Drawing.Size(158, 36);
            this.lblDownloads.TabIndex = 0;
            this.lblDownloads.Text = "Downloads:";
            this.lblDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepositoryEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClones);
            this.Controls.Add(this.lblViews);
            this.Controls.Add(this.lnklblIssues);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lnkLabel);
            this.Controls.Add(this.btnCheckNow);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblDownloads);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RepositoryEntry";
            this.Size = new System.Drawing.Size(1075, 39);
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
        private System.Windows.Forms.ContextMenuStrip cmsIssues;
        private System.Windows.Forms.Label lblClones;
    }
}
