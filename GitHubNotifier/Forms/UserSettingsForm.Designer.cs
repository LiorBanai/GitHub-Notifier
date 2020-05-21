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
            this.SuspendLayout();
            // 
            // chklstRepo
            // 
            this.chklstRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstRepo.FormattingEnabled = true;
            this.chklstRepo.Location = new System.Drawing.Point(2, 94);
            this.chklstRepo.Name = "chklstRepo";
            this.chklstRepo.Size = new System.Drawing.Size(642, 344);
            this.chklstRepo.TabIndex = 0;
            this.chklstRepo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstRepo_ItemCheck);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(664, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(12, 21);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(231, 17);
            this.lblRepo.TabIndex = 2;
            this.lblRepo.Text = "Repository name (as in User/Repo)";
            // 
            // lblRepoDisplayName
            // 
            this.lblRepoDisplayName.AutoSize = true;
            this.lblRepoDisplayName.Location = new System.Drawing.Point(12, 52);
            this.lblRepoDisplayName.Name = "lblRepoDisplayName";
            this.lblRepoDisplayName.Size = new System.Drawing.Size(99, 17);
            this.lblRepoDisplayName.TabIndex = 4;
            this.lblRepoDisplayName.Text = "Display Name:";
            // 
            // txtbRepoDisplayName
            // 
            this.txtbRepoDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRepoDisplayName.Location = new System.Drawing.Point(306, 21);
            this.txtbRepoDisplayName.Name = "txtbRepoDisplayName";
            this.txtbRepoDisplayName.Size = new System.Drawing.Size(338, 22);
            this.txtbRepoDisplayName.TabIndex = 5;
            // 
            // txtbRepoName
            // 
            this.txtbRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRepoName.Location = new System.Drawing.Point(306, 52);
            this.txtbRepoName.Name = "txtbRepoName";
            this.txtbRepoName.Size = new System.Drawing.Size(338, 22);
            this.txtbRepoName.TabIndex = 6;
            // 
            // btnAddRepo
            // 
            this.btnAddRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRepo.Location = new System.Drawing.Point(664, 27);
            this.btnAddRepo.Name = "btnAddRepo";
            this.btnAddRepo.Size = new System.Drawing.Size(158, 34);
            this.btnAddRepo.TabIndex = 7;
            this.btnAddRepo.Text = "Add Repository";
            this.btnAddRepo.UseVisualStyleBackColor = true;
            this.btnAddRepo.Click += new System.EventHandler(this.btnAddRepo_Click);
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.btnAddRepo);
            this.Controls.Add(this.txtbRepoName);
            this.Controls.Add(this.txtbRepoDisplayName);
            this.Controls.Add(this.lblRepoDisplayName);
            this.Controls.Add(this.lblRepo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chklstRepo);
            this.Name = "UserSettingsForm";
            this.Text = "User settings form";
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
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
    }
}

