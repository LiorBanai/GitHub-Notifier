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
            this.panelRepositories = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpActive = new System.Windows.Forms.TabPage();
            this.tpNonActive = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnCheckAllRepositories = new System.Windows.Forms.ToolStripButton();
            this.tpNotifications = new System.Windows.Forms.TabPage();
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnCheckNotifications = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClear = new System.Windows.Forms.ToolStripButton();
            this.tpGitOperations = new System.Windows.Forms.TabPage();
            this.btnListFolders = new System.Windows.Forms.Button();
            this.btnCleanUntrack = new System.Windows.Forms.Button();
            this.chkbClearLog = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvRepositories = new System.Windows.Forms.TreeView();
            this.contextMenuStripRepository = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPullFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPull = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnRepositoryBrowse = new System.Windows.Forms.Button();
            this.txtRepositoryRoot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblAPILimit = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblNotifications = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslError = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerNotifications = new System.Windows.Forms.Timer(this.components);
            this.timerAPIRateCheck = new System.Windows.Forms.Timer(this.components);
            this.btnCleanObjAndBinFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpRepo.SuspendLayout();
            this.panelRepositories.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tpNotifications.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tpGitOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripRepository.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 700);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRepo);
            this.tabControl1.Controls.Add(this.tpNotifications);
            this.tabControl1.Controls.Add(this.tpGitOperations);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(1495, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRepo
            // 
            this.tpRepo.AutoScroll = true;
            this.tpRepo.Controls.Add(this.panelRepositories);
            this.tpRepo.Controls.Add(this.toolStrip2);
            this.tpRepo.Location = new System.Drawing.Point(4, 29);
            this.tpRepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRepo.Name = "tpRepo";
            this.tpRepo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRepo.Size = new System.Drawing.Size(1487, 667);
            this.tpRepo.TabIndex = 0;
            this.tpRepo.Text = "Repositories";
            this.tpRepo.UseVisualStyleBackColor = true;
            // 
            // panelRepositories
            // 
            this.panelRepositories.Controls.Add(this.tabControl2);
            this.panelRepositories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRepositories.Location = new System.Drawing.Point(3, 29);
            this.panelRepositories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRepositories.Name = "panelRepositories";
            this.panelRepositories.Size = new System.Drawing.Size(1481, 636);
            this.panelRepositories.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpActive);
            this.tabControl2.Controls.Add(this.tpNonActive);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1481, 636);
            this.tabControl2.TabIndex = 0;
            // 
            // tpActive
            // 
            this.tpActive.Location = new System.Drawing.Point(4, 29);
            this.tpActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpActive.Name = "tpActive";
            this.tpActive.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpActive.Size = new System.Drawing.Size(1473, 603);
            this.tpActive.TabIndex = 0;
            this.tpActive.Text = "Actives";
            this.tpActive.UseVisualStyleBackColor = true;
            // 
            // tpNonActive
            // 
            this.tpNonActive.Location = new System.Drawing.Point(4, 29);
            this.tpNonActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpNonActive.Name = "tpNonActive";
            this.tpNonActive.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpNonActive.Size = new System.Drawing.Size(1473, 603);
            this.tpNonActive.TabIndex = 1;
            this.tpNonActive.Text = "Non Actives";
            this.tpNonActive.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCheckAllRepositories});
            this.toolStrip2.Location = new System.Drawing.Point(3, 2);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1481, 27);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnCheckAllRepositories
            // 
            this.tsbtnCheckAllRepositories.Image = global::GitHubNotifier.Properties.Resources.Refresh;
            this.tsbtnCheckAllRepositories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckAllRepositories.Name = "tsbtnCheckAllRepositories";
            this.tsbtnCheckAllRepositories.Size = new System.Drawing.Size(107, 24);
            this.tsbtnCheckAllRepositories.Text = "Check Now";
            this.tsbtnCheckAllRepositories.Click += new System.EventHandler(this.tsbtnCheckAllRepositories_Click);
            // 
            // tpNotifications
            // 
            this.tpNotifications.Controls.Add(this.lstNotifications);
            this.tpNotifications.Controls.Add(this.toolStrip1);
            this.tpNotifications.Location = new System.Drawing.Point(4, 29);
            this.tpNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpNotifications.Name = "tpNotifications";
            this.tpNotifications.Size = new System.Drawing.Size(1487, 667);
            this.tpNotifications.TabIndex = 2;
            this.tpNotifications.Text = "Notifications";
            this.tpNotifications.UseVisualStyleBackColor = true;
            // 
            // lstNotifications
            // 
            this.lstNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNotifications.FormattingEnabled = true;
            this.lstNotifications.ItemHeight = 20;
            this.lstNotifications.Location = new System.Drawing.Point(0, 27);
            this.lstNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstNotifications.Name = "lstNotifications";
            this.lstNotifications.Size = new System.Drawing.Size(1487, 640);
            this.lstNotifications.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnCheckNotifications,
            this.tsBtnClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1487, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnCheckNotifications
            // 
            this.tsBtnCheckNotifications.Image = global::GitHubNotifier.Properties.Resources.Refresh;
            this.tsBtnCheckNotifications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCheckNotifications.Name = "tsBtnCheckNotifications";
            this.tsBtnCheckNotifications.Size = new System.Drawing.Size(107, 24);
            this.tsBtnCheckNotifications.Text = "Check Now";
            this.tsBtnCheckNotifications.Click += new System.EventHandler(this.tsBtnCheckNotifications_Click);
            // 
            // tsBtnClear
            // 
            this.tsBtnClear.Image = global::GitHubNotifier.Properties.Resources.Clear_16x16;
            this.tsBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClear.Name = "tsBtnClear";
            this.tsBtnClear.Size = new System.Drawing.Size(67, 24);
            this.tsBtnClear.Text = "Clear";
            this.tsBtnClear.Click += new System.EventHandler(this.tsBtnClear_Click);
            // 
            // tpGitOperations
            // 
            this.tpGitOperations.Controls.Add(this.btnCleanObjAndBinFolder);
            this.tpGitOperations.Controls.Add(this.btnListFolders);
            this.tpGitOperations.Controls.Add(this.btnCleanUntrack);
            this.tpGitOperations.Controls.Add(this.chkbClearLog);
            this.tpGitOperations.Controls.Add(this.splitContainer1);
            this.tpGitOperations.Controls.Add(this.btnPull);
            this.tpGitOperations.Controls.Add(this.btnFetch);
            this.tpGitOperations.Controls.Add(this.btnRepositoryBrowse);
            this.tpGitOperations.Controls.Add(this.txtRepositoryRoot);
            this.tpGitOperations.Controls.Add(this.label1);
            this.tpGitOperations.Location = new System.Drawing.Point(4, 29);
            this.tpGitOperations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpGitOperations.Name = "tpGitOperations";
            this.tpGitOperations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpGitOperations.Size = new System.Drawing.Size(1487, 667);
            this.tpGitOperations.TabIndex = 3;
            this.tpGitOperations.Text = "Git Operations";
            this.tpGitOperations.UseVisualStyleBackColor = true;
            // 
            // btnListFolders
            // 
            this.btnListFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListFolders.Location = new System.Drawing.Point(1160, 7);
            this.btnListFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListFolders.Name = "btnListFolders";
            this.btnListFolders.Size = new System.Drawing.Size(113, 35);
            this.btnListFolders.TabIndex = 23;
            this.btnListFolders.Text = "List Folders";
            this.btnListFolders.UseVisualStyleBackColor = true;
            this.btnListFolders.Click += new System.EventHandler(this.btnListFolders_Click);
            // 
            // btnCleanUntrack
            // 
            this.btnCleanUntrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanUntrack.Location = new System.Drawing.Point(1274, 7);
            this.btnCleanUntrack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCleanUntrack.Name = "btnCleanUntrack";
            this.btnCleanUntrack.Size = new System.Drawing.Size(204, 35);
            this.btnCleanUntrack.TabIndex = 22;
            this.btnCleanUntrack.Text = "Clean Untracked items";
            this.btnCleanUntrack.UseVisualStyleBackColor = true;
            this.btnCleanUntrack.Click += new System.EventHandler(this.btnCleanUntrack_Click);
            // 
            // chkbClearLog
            // 
            this.chkbClearLog.AutoSize = true;
            this.chkbClearLog.Checked = true;
            this.chkbClearLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbClearLog.Location = new System.Drawing.Point(8, 49);
            this.chkbClearLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbClearLog.Name = "chkbClearLog";
            this.chkbClearLog.Size = new System.Drawing.Size(234, 24);
            this.chkbClearLog.TabIndex = 21;
            this.chkbClearLog.Text = "Clear old log before operation";
            this.chkbClearLog.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 96);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvRepositories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1470, 560);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 20;
            // 
            // tvRepositories
            // 
            this.tvRepositories.ContextMenuStrip = this.contextMenuStripRepository;
            this.tvRepositories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRepositories.ImageIndex = 0;
            this.tvRepositories.ImageList = this.imageList1;
            this.tvRepositories.Location = new System.Drawing.Point(0, 0);
            this.tvRepositories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvRepositories.Name = "tvRepositories";
            this.tvRepositories.SelectedImageIndex = 0;
            this.tvRepositories.Size = new System.Drawing.Size(490, 560);
            this.tvRepositories.TabIndex = 0;
            this.tvRepositories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRepositories_AfterSelect);
            // 
            // contextMenuStripRepository
            // 
            this.contextMenuStripRepository.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRepository.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFolder,
            this.tsmiPullFolder});
            this.contextMenuStripRepository.Name = "contextMenuStripRepository";
            this.contextMenuStripRepository.Size = new System.Drawing.Size(236, 52);
            // 
            // tsmiOpenFolder
            // 
            this.tsmiOpenFolder.Name = "tsmiOpenFolder";
            this.tsmiOpenFolder.Size = new System.Drawing.Size(235, 24);
            this.tsmiOpenFolder.Text = "Open Repository Folder";
            this.tsmiOpenFolder.Click += new System.EventHandler(this.tsmiOpenFolder_Click);
            // 
            // tsmiPullFolder
            // 
            this.tsmiPullFolder.Name = "tsmiPullFolder";
            this.tsmiPullFolder.Size = new System.Drawing.Size(235, 24);
            this.tsmiPullFolder.Text = "Pull Repository";
            this.tsmiPullFolder.Click += new System.EventHandler(this.tsmiPullFolder_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "IconBlack.png");
            this.imageList1.Images.SetKeyName(1, "IconColorful.png");
            this.imageList1.Images.SetKeyName(2, "iconGreen.png");
            this.imageList1.Images.SetKeyName(3, "IconRed.png");
            this.imageList1.Images.SetKeyName(4, "IconSetStars3_16x16.png");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(976, 560);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(81, 5);
            this.btnPull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(69, 35);
            this.btnPull.TabIndex = 17;
            this.btnPull.Text = "Pull";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(7, 5);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(69, 35);
            this.btnFetch.TabIndex = 16;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnRepositoryBrowse
            // 
            this.btnRepositoryBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepositoryBrowse.Location = new System.Drawing.Point(1083, 7);
            this.btnRepositoryBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRepositoryBrowse.Name = "btnRepositoryBrowse";
            this.btnRepositoryBrowse.Size = new System.Drawing.Size(69, 35);
            this.btnRepositoryBrowse.TabIndex = 15;
            this.btnRepositoryBrowse.Text = "Browse";
            this.btnRepositoryBrowse.UseVisualStyleBackColor = true;
            this.btnRepositoryBrowse.Click += new System.EventHandler(this.btnRepositoryBrowse_Click);
            // 
            // txtRepositoryRoot
            // 
            this.txtRepositoryRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepositoryRoot.Location = new System.Drawing.Point(384, 10);
            this.txtRepositoryRoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepositoryRoot.Name = "txtRepositoryRoot";
            this.txtRepositoryRoot.Size = new System.Drawing.Size(692, 27);
            this.txtRepositoryRoot.TabIndex = 13;
            this.txtRepositoryRoot.TextChanged += new System.EventHandler(this.txtRepositoryRoot_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Folder of Repository (or many)";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1495, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExitForm});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExitForm
            // 
            this.tsmiExitForm.Name = "tsmiExitForm";
            this.tsmiExitForm.Size = new System.Drawing.Size(116, 26);
            this.tsmiExitForm.Text = "Exit";
            this.tsmiExitForm.Click += new System.EventHandler(this.tsmiExitForm_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(76, 24);
            this.tsmiSettings.Text = "Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotifyBar;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "GitHub Notifier";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStripNotifyBar
            // 
            this.contextMenuStripNotifyBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNotifyBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.toolStripSeparator2,
            this.tsmiCheckAll,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.contextMenuStripNotifyBar.Name = "contextMenuStripNotifyBar";
            this.contextMenuStripNotifyBar.Size = new System.Drawing.Size(140, 88);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(139, 24);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmiCheckAll
            // 
            this.tsmiCheckAll.Name = "tsmiCheckAll";
            this.tsmiCheckAll.Size = new System.Drawing.Size(139, 24);
            this.tsmiCheckAll.Text = "Check All";
            this.tsmiCheckAll.Click += new System.EventHandler(this.tsmiCheckAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(139, 24);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblAPILimit,
            this.tsslblNotifications,
            this.tsslError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 748);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1495, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblAPILimit
            // 
            this.tsslblAPILimit.Name = "tsslblAPILimit";
            this.tsslblAPILimit.Size = new System.Drawing.Size(77, 20);
            this.tsslblAPILimit.Text = "API Limits:";
            // 
            // tsslblNotifications
            // 
            this.tsslblNotifications.Name = "tsslblNotifications";
            this.tsslblNotifications.Size = new System.Drawing.Size(97, 20);
            this.tsslblNotifications.Text = "Notifications:";
            // 
            // tsslError
            // 
            this.tsslError.Name = "tsslError";
            this.tsslError.Size = new System.Drawing.Size(58, 20);
            this.tsslError.Text = "ERROR:";
            this.tsslError.Visible = false;
            // 
            // timerNotifications
            // 
            this.timerNotifications.Enabled = true;
            this.timerNotifications.Interval = 900000;
            this.timerNotifications.Tick += new System.EventHandler(this.timerNotifications_Tick);
            // 
            // timerAPIRateCheck
            // 
            this.timerAPIRateCheck.Enabled = true;
            this.timerAPIRateCheck.Interval = 900000;
            this.timerAPIRateCheck.Tick += new System.EventHandler(this.timerAPIRateCheck_Tick);
            // 
            // btnCleanObjAndBinFolder
            // 
            this.btnCleanObjAndBinFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanObjAndBinFolder.Location = new System.Drawing.Point(1274, 43);
            this.btnCleanObjAndBinFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCleanObjAndBinFolder.Name = "btnCleanObjAndBinFolder";
            this.btnCleanObjAndBinFolder.Size = new System.Drawing.Size(204, 35);
            this.btnCleanObjAndBinFolder.TabIndex = 24;
            this.btnCleanObjAndBinFolder.Text = "clean obj and bin folders";
            this.btnCleanObjAndBinFolder.UseVisualStyleBackColor = true;
            this.btnCleanObjAndBinFolder.Click += new System.EventHandler(this.btnCleanObjAndBinFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 774);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "GitHub Notifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRepo.ResumeLayout(false);
            this.tpRepo.PerformLayout();
            this.panelRepositories.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tpNotifications.ResumeLayout(false);
            this.tpNotifications.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tpGitOperations.ResumeLayout(false);
            this.tpGitOperations.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripRepository.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton tsBtnCheckNotifications;
        private System.Windows.Forms.ToolStripStatusLabel tsslblNotifications;
        private System.Windows.Forms.Timer timerAPIRateCheck;
        private System.Windows.Forms.ToolStripButton tsBtnClear;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnCheckAllRepositories;
        private System.Windows.Forms.Panel panelRepositories;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpActive;
        private System.Windows.Forms.TabPage tpNonActive;
        private System.Windows.Forms.ToolStripStatusLabel tsslError;
        private System.Windows.Forms.TabPage tpGitOperations;
        private System.Windows.Forms.Button btnRepositoryBrowse;
        private System.Windows.Forms.TextBox txtRepositoryRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvRepositories;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox chkbClearLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRepository;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFolder;
        private System.Windows.Forms.Button btnCleanUntrack;
        private System.Windows.Forms.Button btnListFolders;
        private System.Windows.Forms.ToolStripMenuItem tsmiPullFolder;
        private System.Windows.Forms.Button btnCleanObjAndBinFolder;
    }
}

