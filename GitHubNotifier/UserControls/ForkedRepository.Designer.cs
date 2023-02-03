namespace GitHubNotifier.UserControls
{
    partial class ForkedRepository
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
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.lblLatestCommit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkLabel
            // 
            this.lnkLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkLabel.Location = new System.Drawing.Point(0, 0);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(290, 39);
            this.lnkLabel.TabIndex = 5;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "N/A";
            this.lnkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabel_LinkClicked);
            // 
            // lblLikes
            // 
            this.lblLikes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLikes.Image = global::GitHubNotifier.Properties.Resources.Feature_32x32;
            this.lblLikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLikes.Location = new System.Drawing.Point(290, 0);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(151, 39);
            this.lblLikes.TabIndex = 4;
            this.lblLikes.Text = "Stars:";
            this.lblLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdated
            // 
            this.lblUpdated.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUpdated.Image = global::GitHubNotifier.Properties.Resources.Suggestion_32x32;
            this.lblUpdated.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUpdated.Location = new System.Drawing.Point(441, 0);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(427, 39);
            this.lblUpdated.TabIndex = 6;
            this.lblUpdated.Text = "Updated:";
            this.lblUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatestCommit
            // 
            this.lblLatestCommit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLatestCommit.Image = global::GitHubNotifier.Properties.Resources.Suggestion_32x32;
            this.lblLatestCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLatestCommit.Location = new System.Drawing.Point(868, 0);
            this.lblLatestCommit.Name = "lblLatestCommit";
            this.lblLatestCommit.Size = new System.Drawing.Size(427, 39);
            this.lblLatestCommit.TabIndex = 7;
            this.lblLatestCommit.Text = "Newest Commit:";
            this.lblLatestCommit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForkedRepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLatestCommit);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lnkLabel);
            this.Name = "ForkedRepository";
            this.Size = new System.Drawing.Size(1200, 39);
            this.Load += new System.EventHandler(this.ForkedRepository_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLabel;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label lblLatestCommit;
    }
}
