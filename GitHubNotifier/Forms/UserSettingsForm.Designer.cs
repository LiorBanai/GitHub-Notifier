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
            this.chkbStars = new System.Windows.Forms.CheckBox();
            this.chkbDownloads = new System.Windows.Forms.CheckBox();
            this.chkbViews = new System.Windows.Forms.CheckBox();
            this.chkbOpenIssues = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSelectedRepoName = new System.Windows.Forms.TextBox();
            this.txtSelectedRepoDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbClones = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkbDoNotShowDecrementPopups = new System.Windows.Forms.CheckBox();
            this.chkbStartMinimized = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkbShowNotificationsOnlyOnce = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifications)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chklstRepo
            // 
            this.chklstRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstRepo.FormattingEnabled = true;
            this.chklstRepo.Location = new System.Drawing.Point(11, 195);
            this.chklstRepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chklstRepo.Name = "chklstRepo";
            this.chklstRepo.Size = new System.Drawing.Size(1031, 290);
            this.chklstRepo.TabIndex = 0;
            this.chklstRepo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstRepo_ItemCheck);
            this.chklstRepo.SelectedIndexChanged += new System.EventHandler(this.chklstRepo_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1063, 218);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(7, 72);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(239, 20);
            this.lblRepo.TabIndex = 2;
            this.lblRepo.Text = "Repository name (as in User/Repo)";
            // 
            // lblRepoDisplayName
            // 
            this.lblRepoDisplayName.AutoSize = true;
            this.lblRepoDisplayName.Location = new System.Drawing.Point(7, 114);
            this.lblRepoDisplayName.Name = "lblRepoDisplayName";
            this.lblRepoDisplayName.Size = new System.Drawing.Size(105, 20);
            this.lblRepoDisplayName.TabIndex = 4;
            this.lblRepoDisplayName.Text = "Display Name:";
            // 
            // txtbRepoDisplayName
            // 
            this.txtbRepoDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRepoDisplayName.Location = new System.Drawing.Point(317, 106);
            this.txtbRepoDisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbRepoDisplayName.Name = "txtbRepoDisplayName";
            this.txtbRepoDisplayName.Size = new System.Drawing.Size(727, 27);
            this.txtbRepoDisplayName.TabIndex = 5;
            // 
            // txtbRepoName
            // 
            this.txtbRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRepoName.Location = new System.Drawing.Point(317, 72);
            this.txtbRepoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbRepoName.Name = "txtbRepoName";
            this.txtbRepoName.Size = new System.Drawing.Size(727, 27);
            this.txtbRepoName.TabIndex = 6;
            // 
            // btnAddRepo
            // 
            this.btnAddRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRepo.Location = new System.Drawing.Point(1063, 75);
            this.btnAddRepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRepo.Name = "btnAddRepo";
            this.btnAddRepo.Size = new System.Drawing.Size(157, 42);
            this.btnAddRepo.TabIndex = 7;
            this.btnAddRepo.Text = "Add Repository";
            this.btnAddRepo.UseVisualStyleBackColor = true;
            this.btnAddRepo.Click += new System.EventHandler(this.btnAddRepo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Interval check (minutes):";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinutes.Location = new System.Drawing.Point(912, 152);
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
            this.nudMinutes.Size = new System.Drawing.Size(131, 27);
            this.nudMinutes.TabIndex = 9;
            this.nudMinutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nudNotifications
            // 
            this.nudNotifications.Location = new System.Drawing.Point(317, 15);
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
            this.nudNotifications.Size = new System.Drawing.Size(131, 27);
            this.nudNotifications.TabIndex = 11;
            this.nudNotifications.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Location = new System.Drawing.Point(9, 15);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(216, 20);
            this.lblNotifications.TabIndex = 10;
            this.lblNotifications.Text = "Notifications Interval (minutes):";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1223, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "GitHub limits number of API call to 60 per hour. Add Environment Variable with ke" +
    "y \"GitHubNotifier_Token\" with valid token to get 5000 calls per hour";
            // 
            // chkbStars
            // 
            this.chkbStars.AutoSize = true;
            this.chkbStars.Location = new System.Drawing.Point(9, 29);
            this.chkbStars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbStars.Name = "chkbStars";
            this.chkbStars.Size = new System.Drawing.Size(155, 24);
            this.chkbStars.TabIndex = 12;
            this.chkbStars.Text = "Enable Stars Count";
            this.chkbStars.UseVisualStyleBackColor = true;
            this.chkbStars.CheckedChanged += new System.EventHandler(this.chkbStars_CheckedChanged);
            // 
            // chkbDownloads
            // 
            this.chkbDownloads.AutoSize = true;
            this.chkbDownloads.Location = new System.Drawing.Point(9, 62);
            this.chkbDownloads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbDownloads.Name = "chkbDownloads";
            this.chkbDownloads.Size = new System.Drawing.Size(192, 24);
            this.chkbDownloads.TabIndex = 13;
            this.chkbDownloads.Text = "Enable Download Count";
            this.chkbDownloads.UseVisualStyleBackColor = true;
            this.chkbDownloads.CheckedChanged += new System.EventHandler(this.chkbDownloads_CheckedChanged);
            // 
            // chkbViews
            // 
            this.chkbViews.AutoSize = true;
            this.chkbViews.Location = new System.Drawing.Point(9, 129);
            this.chkbViews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbViews.Name = "chkbViews";
            this.chkbViews.Size = new System.Drawing.Size(161, 24);
            this.chkbViews.TabIndex = 15;
            this.chkbViews.Text = "Enable Views Count";
            this.chkbViews.UseVisualStyleBackColor = true;
            this.chkbViews.CheckedChanged += new System.EventHandler(this.chkbViews_CheckedChanged);
            // 
            // chkbOpenIssues
            // 
            this.chkbOpenIssues.AutoSize = true;
            this.chkbOpenIssues.Location = new System.Drawing.Point(9, 95);
            this.chkbOpenIssues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbOpenIssues.Name = "chkbOpenIssues";
            this.chkbOpenIssues.Size = new System.Drawing.Size(201, 24);
            this.chkbOpenIssues.TabIndex = 14;
            this.chkbOpenIssues.Text = "Enable Open Issues Count";
            this.chkbOpenIssues.UseVisualStyleBackColor = true;
            this.chkbOpenIssues.CheckedChanged += new System.EventHandler(this.chkbOpenIssues_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSelectedRepoName);
            this.groupBox1.Controls.Add(this.txtSelectedRepoDisplayName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkbClones);
            this.groupBox1.Controls.Add(this.chkbStars);
            this.groupBox1.Controls.Add(this.chkbViews);
            this.groupBox1.Controls.Add(this.chkbDownloads);
            this.groupBox1.Controls.Add(this.chkbOpenIssues);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(4, 522);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1223, 218);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected:";
            // 
            // txtSelectedRepoName
            // 
            this.txtSelectedRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedRepoName.Location = new System.Drawing.Point(922, 25);
            this.txtSelectedRepoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectedRepoName.Name = "txtSelectedRepoName";
            this.txtSelectedRepoName.Size = new System.Drawing.Size(295, 27);
            this.txtSelectedRepoName.TabIndex = 20;
            this.txtSelectedRepoName.TextChanged += new System.EventHandler(this.txtSelectedRepoName_TextChanged);
            // 
            // txtSelectedRepoDisplayName
            // 
            this.txtSelectedRepoDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedRepoDisplayName.Location = new System.Drawing.Point(922, 59);
            this.txtSelectedRepoDisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectedRepoDisplayName.Name = "txtSelectedRepoDisplayName";
            this.txtSelectedRepoDisplayName.Size = new System.Drawing.Size(295, 27);
            this.txtSelectedRepoDisplayName.TabIndex = 19;
            this.txtSelectedRepoDisplayName.TextChanged += new System.EventHandler(this.txtSelectedRepoDisplayName_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Display Name:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Repository name (as in User/Repo)";
            // 
            // chkbClones
            // 
            this.chkbClones.AutoSize = true;
            this.chkbClones.Location = new System.Drawing.Point(9, 162);
            this.chkbClones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbClones.Name = "chkbClones";
            this.chkbClones.Size = new System.Drawing.Size(167, 24);
            this.chkbClones.TabIndex = 16;
            this.chkbClones.Text = "Enable Clones Count";
            this.chkbClones.UseVisualStyleBackColor = true;
            this.chkbClones.CheckedChanged += new System.EventHandler(this.chkbClones_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1239, 778);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkbDoNotShowDecrementPopups);
            this.tabPage1.Controls.Add(this.chkbStartMinimized);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1231, 745);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkbDoNotShowDecrementPopups
            // 
            this.chkbDoNotShowDecrementPopups.AutoSize = true;
            this.chkbDoNotShowDecrementPopups.Location = new System.Drawing.Point(9, 72);
            this.chkbDoNotShowDecrementPopups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbDoNotShowDecrementPopups.Name = "chkbDoNotShowDecrementPopups";
            this.chkbDoNotShowDecrementPopups.Size = new System.Drawing.Size(339, 24);
            this.chkbDoNotShowDecrementPopups.TabIndex = 14;
            this.chkbDoNotShowDecrementPopups.Text = "Do not Show Popup On decrement of counters";
            this.chkbDoNotShowDecrementPopups.UseVisualStyleBackColor = true;
            this.chkbDoNotShowDecrementPopups.CheckedChanged += new System.EventHandler(this.chkbDoNotShowDecrementPopups_CheckedChanged);
            // 
            // chkbStartMinimized
            // 
            this.chkbStartMinimized.AutoSize = true;
            this.chkbStartMinimized.Location = new System.Drawing.Point(9, 41);
            this.chkbStartMinimized.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbStartMinimized.Name = "chkbStartMinimized";
            this.chkbStartMinimized.Size = new System.Drawing.Size(240, 24);
            this.chkbStartMinimized.TabIndex = 13;
            this.chkbStartMinimized.Text = "Start the application Minimized";
            this.chkbStartMinimized.UseVisualStyleBackColor = true;
            this.chkbStartMinimized.CheckedChanged += new System.EventHandler(this.chkbStartMinimized_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1223, 62);
            this.label5.TabIndex = 3;
            this.label5.Text = "GitHub limits number of API call to 60 per hour. Add Environment Variable with ke" +
    "y \"GitHubNotifier_Token\" with valid token to get 5000 calls per hour";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnImport);
            this.tabPage2.Controls.Add(this.btnExport);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblRepo);
            this.tabPage2.Controls.Add(this.lblRepoDisplayName);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.nudMinutes);
            this.tabPage2.Controls.Add(this.chklstRepo);
            this.tabPage2.Controls.Add(this.txtbRepoName);
            this.tabPage2.Controls.Add(this.btnAddRepo);
            this.tabPage2.Controls.Add(this.txtbRepoDisplayName);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1231, 745);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Repositories";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(1040, 2);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(87, 42);
            this.btnImport.TabIndex = 18;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(1133, 2);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 42);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkbShowNotificationsOnlyOnce);
            this.tabPage3.Controls.Add(this.lblNotifications);
            this.tabPage3.Controls.Add(this.nudNotifications);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1231, 745);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User Notifications";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkbShowNotificationsOnlyOnce
            // 
            this.chkbShowNotificationsOnlyOnce.AutoSize = true;
            this.chkbShowNotificationsOnlyOnce.Location = new System.Drawing.Point(13, 71);
            this.chkbShowNotificationsOnlyOnce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbShowNotificationsOnlyOnce.Name = "chkbShowNotificationsOnlyOnce";
            this.chkbShowNotificationsOnlyOnce.Size = new System.Drawing.Size(224, 24);
            this.chkbShowNotificationsOnlyOnce.TabIndex = 13;
            this.chkbShowNotificationsOnlyOnce.Text = "Show Notifications only once";
            this.chkbShowNotificationsOnlyOnce.UseVisualStyleBackColor = true;
            this.chkbShowNotificationsOnlyOnce.CheckedChanged += new System.EventHandler(this.chkbShowNotificationsOnlyOnce_CheckedChanged);
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 778);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox chkbStars;
        private System.Windows.Forms.CheckBox chkbDownloads;
        private System.Windows.Forms.CheckBox chkbViews;
        private System.Windows.Forms.CheckBox chkbOpenIssues;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkbClones;
        private System.Windows.Forms.TextBox txtSelectedRepoName;
        private System.Windows.Forms.TextBox txtSelectedRepoDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkbStartMinimized;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkbShowNotificationsOnlyOnce;
        private System.Windows.Forms.CheckBox chkbDoNotShowDecrementPopups;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}

