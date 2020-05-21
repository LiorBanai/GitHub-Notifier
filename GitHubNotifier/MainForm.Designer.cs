namespace GitHubNotifier
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRepo = new System.Windows.Forms.TabPage();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.tpNotifications = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripNotifyBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 347);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRepo);
            this.tabControl1.Controls.Add(this.tpUser);
            this.tabControl1.Controls.Add(this.tpNotifications);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRepo
            // 
            this.tpRepo.Location = new System.Drawing.Point(4, 25);
            this.tpRepo.Name = "tpRepo";
            this.tpRepo.Padding = new System.Windows.Forms.Padding(3);
            this.tpRepo.Size = new System.Drawing.Size(780, 318);
            this.tpRepo.TabIndex = 0;
            this.tpRepo.Text = "Repositories";
            this.tpRepo.UseVisualStyleBackColor = true;
            // 
            // tpUser
            // 
            this.tpUser.Location = new System.Drawing.Point(4, 25);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUser.Size = new System.Drawing.Size(780, 318);
            this.tpUser.TabIndex = 1;
            this.tpUser.Text = "User";
            this.tpUser.UseVisualStyleBackColor = true;
            // 
            // tpNotifications
            // 
            this.tpNotifications.Location = new System.Drawing.Point(4, 25);
            this.tpNotifications.Name = "tpNotifications";
            this.tpNotifications.Size = new System.Drawing.Size(780, 318);
            this.tpNotifications.TabIndex = 2;
            this.tpNotifications.Text = "Notifications";
            this.tpNotifications.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotifyBar;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Analogy";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStripNotifyBar
            // 
            this.contextMenuStripNotifyBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNotifyBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.contextMenuStripNotifyBar.Name = "contextMenuStripNotifyBar";
            this.contextMenuStripNotifyBar.Size = new System.Drawing.Size(103, 28);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(102, 24);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "GitHub Notifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripNotifyBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRepo;
        private System.Windows.Forms.TabPage tpUser;
        private System.Windows.Forms.TabPage tpNotifications;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyBar;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

