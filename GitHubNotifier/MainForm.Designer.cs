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
            this.tpNotifications = new System.Windows.Forms.TabPage();
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stBtnCheckNotifications = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblAPILimit = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerNotifications = new System.Windows.Forms.Timer(this.components);
            this.tsslblNotifications = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerAPIRateCheck = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpNotifications.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripNotifyBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 545);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRepo);
            this.tabControl1.Controls.Add(this.tpNotifications);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(692, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRepo
            // 
            this.tpRepo.AutoScroll = true;
            this.tpRepo.Location = new System.Drawing.Point(4, 22);
            this.tpRepo.Margin = new System.Windows.Forms.Padding(2);
            this.tpRepo.Name = "tpRepo";
            this.tpRepo.Padding = new System.Windows.Forms.Padding(2);
            this.tpRepo.Size = new System.Drawing.Size(672, 383);
            this.tpRepo.TabIndex = 0;
            this.tpRepo.Text = "Repositories";
            this.tpRepo.UseVisualStyleBackColor = true;
            // 
            // tpNotifications
            // 
            this.tpNotifications.Controls.Add(this.lstNotifications);
            this.tpNotifications.Controls.Add(this.toolStrip1);
            this.tpNotifications.Location = new System.Drawing.Point(4, 22);
            this.tpNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.tpNotifications.Name = "tpNotifications";
            this.tpNotifications.Size = new System.Drawing.Size(684, 519);
            this.tpNotifications.TabIndex = 2;
            this.tpNotifications.Text = "Notifications";
            this.tpNotifications.UseVisualStyleBackColor = true;
            // 
            // lstNotifications
            // 
            this.lstNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNotifications.FormattingEnabled = true;
            this.lstNotifications.Location = new System.Drawing.Point(0, 25);
            this.lstNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.lstNotifications.Name = "lstNotifications";
            this.lstNotifications.Size = new System.Drawing.Size(684, 494);
            this.lstNotifications.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stBtnCheckNotifications});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stBtnCheckNotifications
            // 
            this.stBtnCheckNotifications.Image = global::GitHubNotifier.Properties.Resources.Refresh;
            this.stBtnCheckNotifications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stBtnCheckNotifications.Name = "stBtnCheckNotifications";
            this.stBtnCheckNotifications.Size = new System.Drawing.Size(88, 22);
            this.stBtnCheckNotifications.Text = "Check Now";
            this.stBtnCheckNotifications.Click += new System.EventHandler(this.stBtnCheckNotifications_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.tsmiSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExitForm});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExitForm
            // 
            this.tsmiExitForm.Name = "tsmiExitForm";
            this.tsmiExitForm.Size = new System.Drawing.Size(93, 22);
            this.tsmiExitForm.Text = "Exit";
            this.tsmiExitForm.Click += new System.EventHandler(this.tsmiExitForm_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(61, 20);
            this.tsmiSettings.Text = "Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
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
            this.contextMenuStripNotifyBar.Size = new System.Drawing.Size(94, 26);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(93, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblAPILimit,
            this.tsslblNotifications});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(692, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblAPILimit
            // 
            this.tsslblAPILimit.Name = "tsslblAPILimit";
            this.tsslblAPILimit.Size = new System.Drawing.Size(63, 17);
            this.tsslblAPILimit.Text = "API Limits:";
            // 
            // timerNotifications
            // 
            this.timerNotifications.Interval = 900000;
            this.timerNotifications.Tick += new System.EventHandler(this.timerNotifications_Tick);
            // 
            // tsslblNotifications
            // 
            this.tsslblNotifications.Name = "tsslblNotifications";
            this.tsslblNotifications.Size = new System.Drawing.Size(78, 17);
            this.tsslblNotifications.Text = "Notifications:";
            // 
            // timerAPIRateCheck
            // 
            this.timerAPIRateCheck.Interval = 900000;
            this.timerAPIRateCheck.Tick += new System.EventHandler(this.timerAPIRateCheck_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 593);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "GitHub Notifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpNotifications.ResumeLayout(false);
            this.tpNotifications.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripNotifyBar.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRepo;
        private System.Windows.Forms.TabPage tpNotifications;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyBar;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblAPILimit;
        private System.Windows.Forms.ListBox lstNotifications;
        private System.Windows.Forms.Timer timerNotifications;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitForm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stBtnCheckNotifications;
        private System.Windows.Forms.ToolStripStatusLabel tsslblNotifications;
        private System.Windows.Forms.Timer timerAPIRateCheck;
    }
}

