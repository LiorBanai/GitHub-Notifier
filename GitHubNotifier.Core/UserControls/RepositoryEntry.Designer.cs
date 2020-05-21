namespace GitHubNotifier
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
            this.lblDownloads = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.btnCheckNow = new System.Windows.Forms.Button();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDownloads
            // 
            this.lblDownloads.AutoSize = true;
            this.lblDownloads.Location = new System.Drawing.Point(3, 50);
            this.lblDownloads.Name = "lblDownloads";
            this.lblDownloads.Size = new System.Drawing.Size(87, 20);
            this.lblDownloads.TabIndex = 0;
            this.lblDownloads.Text = "Downloads:";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(3, 79);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(44, 20);
            this.lblLikes.TabIndex = 1;
            this.lblLikes.Text = "Likes:";
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckNow.Location = new System.Drawing.Point(579, 5);
            this.btnCheckNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(140, 32);
            this.btnCheckNow.TabIndex = 2;
            this.btnCheckNow.Text = "Check Now";
            this.btnCheckNow.UseVisualStyleBackColor = true;
            this.btnCheckNow.Click += new System.EventHandler(this.btnCheckNow_Click);
            // 
            // lnkLabel
            // 
            this.lnkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLabel.Location = new System.Drawing.Point(6, 0);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(567, 38);
            this.lnkLabel.TabIndex = 3;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "N/A";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 900000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // RepositoryEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkLabel);
            this.Controls.Add(this.btnCheckNow);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblDownloads);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RepositoryEntry";
            this.Size = new System.Drawing.Size(722, 119);
            this.Load += new System.EventHandler(this.RepositoryEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDownloads;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Button btnCheckNow;
        private System.Windows.Forms.LinkLabel lnkLabel;
        private System.Windows.Forms.Timer timerUpdate;
    }
}
