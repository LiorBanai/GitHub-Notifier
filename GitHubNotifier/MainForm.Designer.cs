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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new System.Windows.Forms.Panel();
            tabControl1 = new System.Windows.Forms.TabControl();
            tpRepo = new System.Windows.Forms.TabPage();
            panelRepositories = new System.Windows.Forms.Panel();
            tabControl2 = new System.Windows.Forms.TabControl();
            tpActive = new System.Windows.Forms.TabPage();
            tpNonActive = new System.Windows.Forms.TabPage();
            toolStrip2 = new System.Windows.Forms.ToolStrip();
            tsbtnCheckAllRepositories = new System.Windows.Forms.ToolStripButton();
            tpNotifications = new System.Windows.Forms.TabPage();
            lstNotifications = new System.Windows.Forms.ListBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsBtnCheckNotifications = new System.Windows.Forms.ToolStripButton();
            tsBtnClear = new System.Windows.Forms.ToolStripButton();
            tpUsefulForks = new System.Windows.Forms.TabPage();
            usefulForksCenterPanel = new System.Windows.Forms.Panel();
            usefulForksTopPanel = new System.Windows.Forms.Panel();
            pnlUsefulForkRoot = new System.Windows.Forms.Panel();
            btnUsefullForks = new System.Windows.Forms.Button();
            txtbUsefullForks = new System.Windows.Forms.TextBox();
            tpGitOperations = new System.Windows.Forms.TabPage();
            btnRemoveDeletedTags = new System.Windows.Forms.Button();
            btnPruneRemotes = new System.Windows.Forms.Button();
            btnCleanObjAndBinFolder = new System.Windows.Forms.Button();
            btnListFolders = new System.Windows.Forms.Button();
            btnCleanUntrack = new System.Windows.Forms.Button();
            chkbClearLog = new System.Windows.Forms.CheckBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tvRepositories = new System.Windows.Forms.TreeView();
            contextMenuStripRepository = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            tsmiFetchRepoHistory = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPullFolder = new System.Windows.Forms.ToolStripMenuItem();
            imageList1 = new System.Windows.Forms.ImageList(components);
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            btnPull = new System.Windows.Forms.Button();
            btnFetch = new System.Windows.Forms.Button();
            btnRepositoryBrowse = new System.Windows.Forms.Button();
            txtRepositoryRoot = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiExitForm = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            contextMenuStripNotifyBar = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsmiCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            tsslblAPILimit = new System.Windows.Forms.ToolStripStatusLabel();
            tsslblNotifications = new System.Windows.Forms.ToolStripStatusLabel();
            tsslError = new System.Windows.Forms.ToolStripStatusLabel();
            timerNotifications = new System.Windows.Forms.Timer(components);
            timerAPIRateCheck = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpRepo.SuspendLayout();
            panelRepositories.SuspendLayout();
            tabControl2.SuspendLayout();
            toolStrip2.SuspendLayout();
            tpNotifications.SuspendLayout();
            toolStrip1.SuspendLayout();
            tpUsefulForks.SuspendLayout();
            usefulForksTopPanel.SuspendLayout();
            tpGitOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuStripRepository.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStripNotifyBar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(tabControl1);
            panel1.Location = new System.Drawing.Point(0, 39);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1495, 700);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpRepo);
            tabControl1.Controls.Add(tpNotifications);
            tabControl1.Controls.Add(tpUsefulForks);
            tabControl1.Controls.Add(tpGitOperations);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 2;
            tabControl1.Size = new System.Drawing.Size(1495, 700);
            tabControl1.TabIndex = 0;
            // 
            // tpRepo
            // 
            tpRepo.AutoScroll = true;
            tpRepo.Controls.Add(panelRepositories);
            tpRepo.Controls.Add(toolStrip2);
            tpRepo.Location = new System.Drawing.Point(4, 29);
            tpRepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tpRepo.Name = "tpRepo";
            tpRepo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tpRepo.Size = new System.Drawing.Size(1487, 667);
            tpRepo.TabIndex = 0;
            tpRepo.Text = "Repositories";
            tpRepo.UseVisualStyleBackColor = true;
            // 
            // panelRepositories
            // 
            panelRepositories.Controls.Add(tabControl2);
            panelRepositories.Dock = System.Windows.Forms.DockStyle.Fill;
            panelRepositories.Location = new System.Drawing.Point(3, 29);
            panelRepositories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelRepositories.Name = "panelRepositories";
            panelRepositories.Size = new System.Drawing.Size(1481, 636);
            panelRepositories.TabIndex = 3;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tpActive);
            tabControl2.Controls.Add(tpNonActive);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl2.Location = new System.Drawing.Point(0, 0);
            tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(1481, 636);
            tabControl2.TabIndex = 0;
            // 
            // tpActive
            // 
            tpActive.Location = new System.Drawing.Point(4, 29);
            tpActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpActive.Name = "tpActive";
            tpActive.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpActive.Size = new System.Drawing.Size(1473, 603);
            tpActive.TabIndex = 0;
            tpActive.Text = "Actives";
            tpActive.UseVisualStyleBackColor = true;
            // 
            // tpNonActive
            // 
            tpNonActive.Location = new System.Drawing.Point(4, 29);
            tpNonActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpNonActive.Name = "tpNonActive";
            tpNonActive.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpNonActive.Size = new System.Drawing.Size(1473, 603);
            tpNonActive.TabIndex = 1;
            tpNonActive.Text = "Non Actives";
            tpNonActive.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbtnCheckAllRepositories });
            toolStrip2.Location = new System.Drawing.Point(3, 2);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new System.Drawing.Size(1481, 27);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnCheckAllRepositories
            // 
            tsbtnCheckAllRepositories.Image = Properties.Resources.Refresh;
            tsbtnCheckAllRepositories.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbtnCheckAllRepositories.Name = "tsbtnCheckAllRepositories";
            tsbtnCheckAllRepositories.Size = new System.Drawing.Size(107, 24);
            tsbtnCheckAllRepositories.Text = "Check Now";
            tsbtnCheckAllRepositories.Click += tsbtnCheckAllRepositories_Click;
            // 
            // tpNotifications
            // 
            tpNotifications.Controls.Add(lstNotifications);
            tpNotifications.Controls.Add(toolStrip1);
            tpNotifications.Location = new System.Drawing.Point(4, 29);
            tpNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tpNotifications.Name = "tpNotifications";
            tpNotifications.Size = new System.Drawing.Size(1487, 667);
            tpNotifications.TabIndex = 2;
            tpNotifications.Text = "Notifications";
            tpNotifications.UseVisualStyleBackColor = true;
            // 
            // lstNotifications
            // 
            lstNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            lstNotifications.FormattingEnabled = true;
            lstNotifications.ItemHeight = 20;
            lstNotifications.Location = new System.Drawing.Point(0, 27);
            lstNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lstNotifications.Name = "lstNotifications";
            lstNotifications.Size = new System.Drawing.Size(1487, 640);
            lstNotifications.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsBtnCheckNotifications, tsBtnClear });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1487, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnCheckNotifications
            // 
            tsBtnCheckNotifications.Image = Properties.Resources.Refresh;
            tsBtnCheckNotifications.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnCheckNotifications.Name = "tsBtnCheckNotifications";
            tsBtnCheckNotifications.Size = new System.Drawing.Size(107, 24);
            tsBtnCheckNotifications.Text = "Check Now";
            tsBtnCheckNotifications.Click += tsBtnCheckNotifications_Click;
            // 
            // tsBtnClear
            // 
            tsBtnClear.Image = Properties.Resources.Clear_16x16;
            tsBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnClear.Name = "tsBtnClear";
            tsBtnClear.Size = new System.Drawing.Size(67, 24);
            tsBtnClear.Text = "Clear";
            tsBtnClear.Click += tsBtnClear_Click;
            // 
            // tpUsefulForks
            // 
            tpUsefulForks.Controls.Add(usefulForksCenterPanel);
            tpUsefulForks.Controls.Add(usefulForksTopPanel);
            tpUsefulForks.Location = new System.Drawing.Point(4, 29);
            tpUsefulForks.Name = "tpUsefulForks";
            tpUsefulForks.Padding = new System.Windows.Forms.Padding(3);
            tpUsefulForks.Size = new System.Drawing.Size(1487, 667);
            tpUsefulForks.TabIndex = 4;
            tpUsefulForks.Text = "Useful Forks";
            tpUsefulForks.UseVisualStyleBackColor = true;
            // 
            // usefulForksCenterPanel
            // 
            usefulForksCenterPanel.AutoScroll = true;
            usefulForksCenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            usefulForksCenterPanel.Location = new System.Drawing.Point(3, 120);
            usefulForksCenterPanel.Name = "usefulForksCenterPanel";
            usefulForksCenterPanel.Size = new System.Drawing.Size(1481, 544);
            usefulForksCenterPanel.TabIndex = 3;
            // 
            // usefulForksTopPanel
            // 
            usefulForksTopPanel.Controls.Add(pnlUsefulForkRoot);
            usefulForksTopPanel.Controls.Add(btnUsefullForks);
            usefulForksTopPanel.Controls.Add(txtbUsefullForks);
            usefulForksTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            usefulForksTopPanel.Location = new System.Drawing.Point(3, 3);
            usefulForksTopPanel.Name = "usefulForksTopPanel";
            usefulForksTopPanel.Size = new System.Drawing.Size(1481, 117);
            usefulForksTopPanel.TabIndex = 2;
            // 
            // pnlUsefulForkRoot
            // 
            pnlUsefulForkRoot.Location = new System.Drawing.Point(6, 55);
            pnlUsefulForkRoot.Name = "pnlUsefulForkRoot";
            pnlUsefulForkRoot.Size = new System.Drawing.Size(1463, 55);
            pnlUsefulForkRoot.TabIndex = 2;
            // 
            // btnUsefullForks
            // 
            btnUsefullForks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnUsefullForks.Location = new System.Drawing.Point(1367, 3);
            btnUsefullForks.Name = "btnUsefullForks";
            btnUsefullForks.Size = new System.Drawing.Size(102, 28);
            btnUsefullForks.TabIndex = 1;
            btnUsefullForks.Text = "Get Forks";
            btnUsefullForks.UseVisualStyleBackColor = true;
            btnUsefullForks.Click += btnUsefulForks_Click;
            // 
            // txtbUsefullForks
            // 
            txtbUsefullForks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbUsefullForks.Location = new System.Drawing.Point(19, 3);
            txtbUsefullForks.Name = "txtbUsefullForks";
            txtbUsefullForks.Size = new System.Drawing.Size(1342, 27);
            txtbUsefullForks.TabIndex = 0;
            txtbUsefullForks.Text = "Analogy-LogViewer/Analogy.LogViewer";
            // 
            // tpGitOperations
            // 
            tpGitOperations.Controls.Add(btnRemoveDeletedTags);
            tpGitOperations.Controls.Add(btnPruneRemotes);
            tpGitOperations.Controls.Add(btnCleanObjAndBinFolder);
            tpGitOperations.Controls.Add(btnListFolders);
            tpGitOperations.Controls.Add(btnCleanUntrack);
            tpGitOperations.Controls.Add(chkbClearLog);
            tpGitOperations.Controls.Add(splitContainer1);
            tpGitOperations.Controls.Add(btnPull);
            tpGitOperations.Controls.Add(btnFetch);
            tpGitOperations.Controls.Add(btnRepositoryBrowse);
            tpGitOperations.Controls.Add(txtRepositoryRoot);
            tpGitOperations.Controls.Add(label1);
            tpGitOperations.Location = new System.Drawing.Point(4, 29);
            tpGitOperations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpGitOperations.Name = "tpGitOperations";
            tpGitOperations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpGitOperations.Size = new System.Drawing.Size(1487, 667);
            tpGitOperations.TabIndex = 3;
            tpGitOperations.Text = "Git Operations";
            tpGitOperations.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDeletedTags
            // 
            btnRemoveDeletedTags.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRemoveDeletedTags.Location = new System.Drawing.Point(1290, 47);
            btnRemoveDeletedTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnRemoveDeletedTags.Name = "btnRemoveDeletedTags";
            btnRemoveDeletedTags.Size = new System.Drawing.Size(188, 35);
            btnRemoveDeletedTags.TabIndex = 26;
            btnRemoveDeletedTags.Text = "Prune Deleted Tags";
            btnRemoveDeletedTags.UseVisualStyleBackColor = true;
            btnRemoveDeletedTags.Click += btnRemoveDeletedTags_Click;
            // 
            // btnPruneRemotes
            // 
            btnPruneRemotes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPruneRemotes.Location = new System.Drawing.Point(1292, 6);
            btnPruneRemotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnPruneRemotes.Name = "btnPruneRemotes";
            btnPruneRemotes.Size = new System.Drawing.Size(188, 35);
            btnPruneRemotes.TabIndex = 25;
            btnPruneRemotes.Text = "Prune Stalled Remotes";
            btnPruneRemotes.UseVisualStyleBackColor = true;
            btnPruneRemotes.Click += btnPruneRemotes_Click;
            // 
            // btnCleanObjAndBinFolder
            // 
            btnCleanObjAndBinFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCleanObjAndBinFolder.Location = new System.Drawing.Point(1080, 47);
            btnCleanObjAndBinFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCleanObjAndBinFolder.Name = "btnCleanObjAndBinFolder";
            btnCleanObjAndBinFolder.Size = new System.Drawing.Size(204, 35);
            btnCleanObjAndBinFolder.TabIndex = 24;
            btnCleanObjAndBinFolder.Text = "clean obj and bin folders";
            btnCleanObjAndBinFolder.UseVisualStyleBackColor = true;
            btnCleanObjAndBinFolder.Click += btnCleanObjAndBinFolder_Click;
            // 
            // btnListFolders
            // 
            btnListFolders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnListFolders.Location = new System.Drawing.Point(959, 47);
            btnListFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnListFolders.Name = "btnListFolders";
            btnListFolders.Size = new System.Drawing.Size(113, 35);
            btnListFolders.TabIndex = 23;
            btnListFolders.Text = "List Folders";
            btnListFolders.UseVisualStyleBackColor = true;
            btnListFolders.Click += btnListFolders_Click;
            // 
            // btnCleanUntrack
            // 
            btnCleanUntrack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCleanUntrack.Location = new System.Drawing.Point(1080, 6);
            btnCleanUntrack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCleanUntrack.Name = "btnCleanUntrack";
            btnCleanUntrack.Size = new System.Drawing.Size(204, 35);
            btnCleanUntrack.TabIndex = 22;
            btnCleanUntrack.Text = "Clean Untracked items";
            btnCleanUntrack.UseVisualStyleBackColor = true;
            btnCleanUntrack.Click += btnCleanUntrack_Click;
            // 
            // chkbClearLog
            // 
            chkbClearLog.AutoSize = true;
            chkbClearLog.Checked = true;
            chkbClearLog.CheckState = System.Windows.Forms.CheckState.Checked;
            chkbClearLog.Location = new System.Drawing.Point(8, 53);
            chkbClearLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chkbClearLog.Name = "chkbClearLog";
            chkbClearLog.Size = new System.Drawing.Size(234, 24);
            chkbClearLog.TabIndex = 21;
            chkbClearLog.Text = "Clear old log before operation";
            chkbClearLog.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Location = new System.Drawing.Point(11, 96);
            splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvRepositories);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBox1);
            splitContainer1.Size = new System.Drawing.Size(1470, 560);
            splitContainer1.SplitterDistance = 490;
            splitContainer1.TabIndex = 20;
            // 
            // tvRepositories
            // 
            tvRepositories.ContextMenuStrip = contextMenuStripRepository;
            tvRepositories.Dock = System.Windows.Forms.DockStyle.Fill;
            tvRepositories.ImageIndex = 0;
            tvRepositories.ImageList = imageList1;
            tvRepositories.Location = new System.Drawing.Point(0, 0);
            tvRepositories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tvRepositories.Name = "tvRepositories";
            tvRepositories.SelectedImageIndex = 0;
            tvRepositories.Size = new System.Drawing.Size(490, 560);
            tvRepositories.TabIndex = 0;
            tvRepositories.AfterSelect += tvRepositories_AfterSelect;
            // 
            // contextMenuStripRepository
            // 
            contextMenuStripRepository.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStripRepository.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiOpenFolder, tsmiFetchRepoHistory, tsmiPullFolder });
            contextMenuStripRepository.Name = "contextMenuStripRepository";
            contextMenuStripRepository.Size = new System.Drawing.Size(240, 76);
            // 
            // tsmiOpenFolder
            // 
            tsmiOpenFolder.Name = "tsmiOpenFolder";
            tsmiOpenFolder.Size = new System.Drawing.Size(239, 24);
            tsmiOpenFolder.Text = "Open Repository Folder";
            tsmiOpenFolder.Click += tsmiOpenFolder_Click;
            // 
            // tsmiFetchRepoHistory
            // 
            tsmiFetchRepoHistory.Name = "tsmiFetchRepoHistory";
            tsmiFetchRepoHistory.Size = new System.Drawing.Size(239, 24);
            tsmiFetchRepoHistory.Text = "Fetch Repository History";
            tsmiFetchRepoHistory.Click += tsmiFetchRepoHistory_Click;
            // 
            // tsmiPullFolder
            // 
            tsmiPullFolder.Name = "tsmiPullFolder";
            tsmiPullFolder.Size = new System.Drawing.Size(239, 24);
            tsmiPullFolder.Text = "Pull Repository";
            tsmiPullFolder.Click += tsmiPullFolder_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "IconBlack.png");
            imageList1.Images.SetKeyName(1, "IconColorful.png");
            imageList1.Images.SetKeyName(2, "iconGreen.png");
            imageList1.Images.SetKeyName(3, "IconRed.png");
            imageList1.Images.SetKeyName(4, "IconSetStars3_16x16.png");
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Location = new System.Drawing.Point(0, 0);
            richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(976, 560);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // btnPull
            // 
            btnPull.Location = new System.Drawing.Point(81, 5);
            btnPull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnPull.Name = "btnPull";
            btnPull.Size = new System.Drawing.Size(69, 35);
            btnPull.TabIndex = 17;
            btnPull.Text = "Pull";
            btnPull.UseVisualStyleBackColor = true;
            btnPull.Click += btnPull_Click;
            // 
            // btnFetch
            // 
            btnFetch.Location = new System.Drawing.Point(7, 5);
            btnFetch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new System.Drawing.Size(69, 35);
            btnFetch.TabIndex = 16;
            btnFetch.Text = "Fetch";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += btnFetch_Click;
            // 
            // btnRepositoryBrowse
            // 
            btnRepositoryBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRepositoryBrowse.Location = new System.Drawing.Point(959, 6);
            btnRepositoryBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnRepositoryBrowse.Name = "btnRepositoryBrowse";
            btnRepositoryBrowse.Size = new System.Drawing.Size(113, 35);
            btnRepositoryBrowse.TabIndex = 15;
            btnRepositoryBrowse.Text = "Browse";
            btnRepositoryBrowse.UseVisualStyleBackColor = true;
            btnRepositoryBrowse.Click += btnRepositoryBrowse_Click;
            // 
            // txtRepositoryRoot
            // 
            txtRepositoryRoot.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtRepositoryRoot.Location = new System.Drawing.Point(384, 10);
            txtRepositoryRoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtRepositoryRoot.Name = "txtRepositoryRoot";
            txtRepositoryRoot.Size = new System.Drawing.Size(568, 27);
            txtRepositoryRoot.TabIndex = 13;
            txtRepositoryRoot.TextChanged += txtRepositoryRoot_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(157, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(212, 20);
            label1.TabIndex = 14;
            label1.Text = "Folder of Repository (or many)";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, tsmiSettings });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1495, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiExitForm });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExitForm
            // 
            tsmiExitForm.Name = "tsmiExitForm";
            tsmiExitForm.Size = new System.Drawing.Size(116, 26);
            tsmiExitForm.Text = "Exit";
            tsmiExitForm.Click += tsmiExitForm_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiSettings
            // 
            tsmiSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsmiSettings.Name = "tsmiSettings";
            tsmiSettings.Size = new System.Drawing.Size(76, 24);
            tsmiSettings.Text = "Settings";
            tsmiSettings.Click += tsmiSettings_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuStripNotifyBar;
            notifyIcon.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "GitHub Notifier";
            notifyIcon.Visible = true;
            notifyIcon.MouseClick += notifyIcon_MouseClick;
            // 
            // contextMenuStripNotifyBar
            // 
            contextMenuStripNotifyBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStripNotifyBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiOpen, toolStripSeparator2, tsmiCheckAll, toolStripSeparator1, tsmiExit });
            contextMenuStripNotifyBar.Name = "contextMenuStripNotifyBar";
            contextMenuStripNotifyBar.Size = new System.Drawing.Size(140, 88);
            // 
            // tsmiOpen
            // 
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.Size = new System.Drawing.Size(139, 24);
            tsmiOpen.Text = "Open";
            tsmiOpen.Click += tsmiOpen_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmiCheckAll
            // 
            tsmiCheckAll.Name = "tsmiCheckAll";
            tsmiCheckAll.Size = new System.Drawing.Size(139, 24);
            tsmiCheckAll.Text = "Check All";
            tsmiCheckAll.Click += tsmiCheckAll_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new System.Drawing.Size(139, 24);
            tsmiExit.Text = "Exit";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsslblAPILimit, tsslblNotifications, tsslError });
            statusStrip1.Location = new System.Drawing.Point(0, 748);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            statusStrip1.Size = new System.Drawing.Size(1495, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslblAPILimit
            // 
            tsslblAPILimit.Name = "tsslblAPILimit";
            tsslblAPILimit.Size = new System.Drawing.Size(77, 20);
            tsslblAPILimit.Text = "API Limits:";
            // 
            // tsslblNotifications
            // 
            tsslblNotifications.Name = "tsslblNotifications";
            tsslblNotifications.Size = new System.Drawing.Size(97, 20);
            tsslblNotifications.Text = "Notifications:";
            // 
            // tsslError
            // 
            tsslError.Name = "tsslError";
            tsslError.Size = new System.Drawing.Size(58, 20);
            tsslError.Text = "ERROR:";
            tsslError.Visible = false;
            // 
            // timerNotifications
            // 
            timerNotifications.Enabled = true;
            timerNotifications.Interval = 900000;
            timerNotifications.Tick += timerNotifications_Tick;
            // 
            // timerAPIRateCheck
            // 
            timerAPIRateCheck.Enabled = true;
            timerAPIRateCheck.Interval = 900000;
            timerAPIRateCheck.Tick += timerAPIRateCheck_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1495, 774);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "GitHub Notifier";
            FormClosing += MainForm_FormClosing;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tpRepo.ResumeLayout(false);
            tpRepo.PerformLayout();
            panelRepositories.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tpNotifications.ResumeLayout(false);
            tpNotifications.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tpUsefulForks.ResumeLayout(false);
            usefulForksTopPanel.ResumeLayout(false);
            usefulForksTopPanel.PerformLayout();
            tpGitOperations.ResumeLayout(false);
            tpGitOperations.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenuStripRepository.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStripNotifyBar.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem tsmiFetchRepoHistory;
        private System.Windows.Forms.TabPage tpUsefulForks;
        private System.Windows.Forms.Button btnUsefullForks;
        private System.Windows.Forms.TextBox txtbUsefullForks;
        private System.Windows.Forms.Panel usefulForksCenterPanel;
        private System.Windows.Forms.Panel usefulForksTopPanel;
        private System.Windows.Forms.Panel pnlUsefulForkRoot;
        private System.Windows.Forms.Button btnPruneRemotes;
        private System.Windows.Forms.Button btnRemoveDeletedTags;
    }
}

