using GitHubNotifier.DataTypes;
using GitHubNotifier.Forms;
using GitHubNotifier.Managers;
using GitHubNotifier.UserControls;
using GitHubNotifier.Utils;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GitHubNotifier
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<string>> _output = new Dictionary<string, List<string>>(0);
        List<RepositoryEntry> repos = new List<RepositoryEntry>();
        private UserSettingsManager Settings => UserSettingsManager.Instance;
        private bool preventExit = true;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            txtRepositoryRoot.Text = Settings.RepositoryRoot;
            await CheckAPILimits();
            await CheckNotifications();
            LoadRepositories();
            tabControl1.SelectedIndex = 0;
            tabControl2.SelectedIndex = 0;
            timerNotifications.Interval = Settings.NotificationsIntervalCheck * 60 * 1000;
            if (Settings.StartMinimized)
            {
                Hide();
            }

            Settings.RepositoriesChanged += Settings_RepositoriesChanged;
        }

        private void Settings_RepositoriesChanged(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(LoadRepositories));
        }

        private void LoadRepositories()
        {
            repos.Clear();
            tpActive.Controls.Clear();
            tpNonActive.Controls.Clear();
            foreach (RepositorySettings repo in Settings.Repositories)
            {
                AddRepo(repo, repo.Active ? tpActive : tpNonActive);
            }


        }

        private async Task CheckAPILimits()
        {
            try
            {

                var result = await GitHubUtils.GetRateLimit(Settings.GitHubToken);
                tsslblAPILimit.Text = "API Limits:" + result?.Rate;
            }
            catch (Exception e)
            {
                tsslblAPILimit.Text = $"API Limits: Check Error: {e.Message}";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (preventExit && e.CloseReason == CloseReason.UserClosing)
            {

                e.Cancel = true;
                Hide();
                var popupNotifier = new NotificationWindow.PopupNotifier
                {
                    TitleText = "GitHub Notifier",
                    ContentText = "Still here. Right click and exit to close",
                    IsRightToLeft = false,
                    Image = Properties.Resources.Feature_32x32,
                    IgnoreWhenFullScreen = true,
                    AutoContentHeight = true
                };
                popupNotifier.Popup();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSettingsManager.Instance.Save();
        }


        private void AddRepo(RepositorySettings repo, TabPage page)
        {
            RepositoryEntry ar1 = new RepositoryEntry(repo);
            repos.Add(ar1);
            page.Controls.Add(ar1);
            ar1.Dock = DockStyle.Top;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            ExitAndClose();
        }

        private void ExitAndClose()
        {
            preventExit = false;
            Close();
            Application.Exit();
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            UserSettingsForm form = new UserSettingsForm();
            form.Show(this);
        }

        private async void timerNotifications_Tick(object sender, EventArgs e)
        {
            await CheckNotifications();
        }

        private async Task CheckNotifications(bool forceCheck = false)
        {
            if (forceCheck || DateTime.Now >=
                Settings.LastReadUserNotification.AddMinutes(Settings.NotificationsIntervalCheck))
            {
                var (newData, notifications) = await GitHubUtils.GetAsync<GitHubUserNotification[]>(
                    "https://api.github.com/notifications", UserSettingsManager.Instance.GitHubToken,
                    UserSettingsManager.Instance.LastReadUserNotification);
                Settings.LastReadUserNotification = DateTime.Now;
                if (newData)
                {
                    Settings.LastReadUserNotification = DateTime.Now;
                    Settings.LastUnReadUserNotifications = notifications.Where(n => n.Unread).ToList();
                    foreach (var notification in notifications)
                    {
                        using (var popupNotifier = new NotificationWindow.PopupNotifier())
                        {
                            {
                                popupNotifier.TitleText = notification.Repository.FullName;
                                popupNotifier.ContentText = notification.Subject.Title;
                                popupNotifier.IsRightToLeft = false;
                                popupNotifier.Image = Properties.Resources.Question_32x32;
                                popupNotifier.IgnoreWhenFullScreen = true;
                                popupNotifier.AutoContentHeight = true;
                            }
                            popupNotifier.Popup();
                        }
                    }
                }
            }


            if (Settings.LastUnReadUserNotifications.Any())
            {
                lstNotifications.Items.Clear();
                lstNotifications.Items.AddRange(Settings.LastUnReadUserNotifications
                    .Select(n => $"{n.Repository.FullName}:  {n.Subject.Title}").ToArray());
            }

            tsslblNotifications.Text =
                $"Notification: {Settings.LastUnReadUserNotifications.Count}. Last Update: {Settings.LastReadUserNotification}";

        }



        private void tsmiExitForm_Click(object sender, EventArgs e)
        {
            ExitAndClose();
        }

        private async void tsBtnCheckNotifications_Click(object sender, EventArgs e)
        {
            await CheckNotifications(true);
        }

        private async void timerAPIRateCheck_Tick(object sender, EventArgs e)
        {
            await CheckAPILimits();
        }

        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            Settings.LastUnReadUserNotifications.Clear();
            lstNotifications.Items.Clear();
        }

        private async void tsbtnCheckAllRepositories_Click(object sender, EventArgs e)
        {
            await CheckAll();
        }

        public async Task CheckAll()
        {
            try
            {
                await Task.WhenAll(repos.Where(r => r.Active()).Select(r => r.Check(true)));
            }
            catch (Exception)
            {
                //ignore
            }
        }

        private void btnRepositoryBrowse_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog() { ShowNewFolderButton = false })
            {
                DialogResult result = folderBrowserDialog.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    txtRepositoryRoot.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void txtRepositoryRoot_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepositoryRoot.Text) && Directory.Exists(txtRepositoryRoot.Text))
            {
                Settings.RepositoryRoot = txtRepositoryRoot.Text;
            }
        }

        private async void btnFetch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepositoryRoot.Text) && Directory.Exists(txtRepositoryRoot.Text))
            {
                tvRepositories.Nodes.Clear();
                _output.Clear();
                bool currentFolderIsGit = CheckIfCurrentFolderIsGet(txtRepositoryRoot.Text);
                var dirs = !currentFolderIsGit
                    ? Directory.GetDirectories(txtRepositoryRoot.Text)
                    : new[] { txtRepositoryRoot.Text };

                List<TreeNode> nodes = new List<TreeNode>();
                foreach (var dir in dirs)
                {

                    GitNode gn = new GitNode(dir, GetBranchName(dir));
                    var node = new TreeNode(gn.DisplayName, 0, 0) { Tag = gn };
                    nodes.Add(node);
                }

                tvRepositories.Nodes.AddRange(nodes.ToArray());
                for (var index = 0; index < dirs.Length; index++)
                {
                    string dir = dirs[index];
                    var dirName = Path.GetFileName(dir);
                    _output[dirName] = new List<string>();
                    PrintToUi(
                        $"{Environment.NewLine}{Environment.NewLine}{DateTime.Now.ToShortTimeString()}:Fetching repository: " +
                        dir);
                    nodes[index].SelectedImageIndex = 1;
                    await ExecuteGitCommand("fetch", dir, dirName);
                    nodes[index].SelectedImageIndex = 2;
                    PrintToUi(
                        $"{DateTime.Now.ToShortTimeString()}:End Fetching repository: {dir}:{Environment.NewLine}{Environment.NewLine}");
                }
            }
        }

        private bool CheckIfCurrentFolderIsGet(string directory)
        {
            bool inside = false;
            try
            {
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = "git.exe",
                    Arguments = "rev-parse --is-inside-work-tree",
                    WorkingDirectory = Path.Combine(directory),
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                };
                var checkCmd = new Process();

                checkCmd.ErrorDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        PrintToUi(e.Data);
                    }
                };
                checkCmd.StartInfo = start;
                checkCmd.OutputDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        inside = e.Data.Contains("true");
                    }
                };

                checkCmd.EnableRaisingEvents = true;
                checkCmd.Start();
                checkCmd.BeginOutputReadLine();
                checkCmd.BeginErrorReadLine();
                checkCmd.WaitForExit();
            }
            catch (Exception e)
            {
                string msg =
                    $"{DateTime.Now.ToShortTimeString()}:######## ERROR: Git operation Ended for command rev-parse --is-inside-work-tree";
                PrintToUi(msg);
            }

            return inside;
        }
        private string GetBranchName(string directory)
        {
            string name = "";
            try
            {
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = "git.exe",
                    Arguments = "branch --show-current",
                    WorkingDirectory = Path.Combine(directory),
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                };
                var checkCmd = new Process();

                checkCmd.ErrorDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        PrintToUi(e.Data);
                    }
                };
                checkCmd.StartInfo = start;
                checkCmd.OutputDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        name = e.Data;
                    }
                };

                checkCmd.EnableRaisingEvents = true;
                checkCmd.Start();
                checkCmd.BeginOutputReadLine();
                checkCmd.BeginErrorReadLine();
                checkCmd.WaitForExit();
            }
            catch (Exception e)
            {
                string msg =
                    $"{DateTime.Now.ToShortTimeString()}:######## ERROR: Git operation Ended for command rev-parse --is-inside-work-tree";
                PrintToUi(msg);
            }

            return name;
        }

        private async void btnPull_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepositoryRoot.Text) && Directory.Exists(txtRepositoryRoot.Text))
            {
                if (chkbClearLog.Checked)
                {
                    richTextBox1.Text = "";
                }

                tvRepositories.Nodes.Clear();
                _output.Clear();
                bool currentFolderIsGit = CheckIfCurrentFolderIsGet(txtRepositoryRoot.Text);
                var dirs = !currentFolderIsGit
                    ? Directory.GetDirectories(txtRepositoryRoot.Text)
                    : new[] { txtRepositoryRoot.Text };

                List<TreeNode> nodes = new List<TreeNode>();
                foreach (var dir in dirs)
                {
                    GitNode gn = new GitNode(dir, GetBranchName(dir));
                    var node = new TreeNode(gn.DisplayName, 0, 0) { Tag = gn };
                    nodes.Add(node);
                }

                tvRepositories.Nodes.AddRange(nodes.ToArray());
                for (var index = 0; index < dirs.Length; index++)
                {
                    string dir = dirs[index];
                    await PullRepo(dir, index);
                }
            }
        }

        private async Task PullRepo(string dir, int index)
        {
            var dirName = Path.GetFileName(dir);
            _output[dirName] = new List<string>();
            PrintToUi($"{DateTime.Now.ToShortTimeString()}: Pulling repository: " + dir);
            tvRepositories.Nodes[index].ImageIndex = tvRepositories.Nodes[index].SelectedImageIndex = 1;
            await ExecuteGitCommand("pull", dir, dirName);
            tvRepositories.Nodes[index].ImageIndex = _output[dirName][0].Contains("Already up to date")
                ? tvRepositories.Nodes[index].SelectedImageIndex = 2
                : tvRepositories.Nodes[index].SelectedImageIndex = 4;
            PrintToUi(
                $"{DateTime.Now.ToShortTimeString()}: End pulling repository: {dir}{Environment.NewLine}{Environment.NewLine}");

        }

        private Task ExecuteGitCommand(string command, string repoPath, string dirName)
        {
            return Task.Run(() =>
            {
                try
                {
                    ProcessStartInfo start = new ProcessStartInfo
                    {
                        FileName = "git.exe",
                        Arguments = command,
                        WorkingDirectory = Path.Combine(repoPath),
                        WindowStyle = ProcessWindowStyle.Hidden,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                    };
                    var publishCmd = new Process();
                    publishCmd.OutputDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            _output[dirName].Add(e.Data);
                            PrintToUi(e.Data);
                        }
                    };
                    publishCmd.ErrorDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            _output[dirName].Add(e.Data);
                            PrintToUi(e.Data);
                        }
                    };
                    publishCmd.StartInfo = start;
                    publishCmd.Exited += (_, e) =>
                    {
                        string msg = $"{DateTime.Now.ToShortTimeString()}: Git operation Ended for command: {command}";
                        _output[dirName].Add(msg);
                        PrintToUi(msg);
                    };
                    publishCmd.EnableRaisingEvents = true;
                    publishCmd.Start();
                    publishCmd.BeginOutputReadLine();
                    publishCmd.BeginErrorReadLine();
                    publishCmd.WaitForExit();

                }
                catch (Exception e)
                {
                    string msg =
                        $"{DateTime.Now.ToShortTimeString()}:######## ERROR: Git operation Ended for command: {command}: {e.Message}";
                    _output[dirName].Add(msg);
                    PrintToUi(msg);
                }
            });

        }

        private void PrintToUi(string data)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                richTextBox1.Text += Environment.NewLine + data;
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }));
        }

        private async void tsmiCheckAll_Click(object sender, EventArgs e)
        {
            await CheckAll();
        }

        private async void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Visible)
                {
                    Hide();
                }
                else
                {
                    Show();
                    BringToFront();
                    Focus();
                    TopMost = true;
                    TopMost = false;
                    tabControl1.SelectedIndex = 0;
                    await CheckNotifications(true);
                    await CheckAll();
                }
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            Show();
            BringToFront();
            Focus();
        }

        private void tvRepositories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is GitNode gt && _output.TryGetValue(gt.DirectoryName, out var items))
            {
                richTextBox1.Text = string.Join(Environment.NewLine, items);
            }

        }

        private void tsmiOpenFolder_Click(object sender, EventArgs e)
        {
            if (tvRepositories.SelectedNode?.Tag is GitNode gt)
            {
                OpenFolder(gt.LocalFolder);
            }
        }

        private void OpenFolder(string folder)
        {
            try
            {
                Process.Start("explorer.exe", " \"" + folder + "\"");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Opening file location", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnCleanUntrack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepositoryRoot.Text) && Directory.Exists(txtRepositoryRoot.Text))
            {
                if (chkbClearLog.Checked)
                {
                    richTextBox1.Text = "";
                }

                tvRepositories.Nodes.Clear();
                _output.Clear();
                bool currentFolderIsGit = CheckIfCurrentFolderIsGet(txtRepositoryRoot.Text);
                var dirs = !currentFolderIsGit
                    ? Directory.GetDirectories(txtRepositoryRoot.Text)
                    : new[] { txtRepositoryRoot.Text };

                List<TreeNode> nodes = new List<TreeNode>();
                foreach (var dir in dirs)
                {
                    var dirName = Path.GetFileName(dir);
                    var node = new TreeNode(dirName, 0, 0) { Tag = dir };
                    nodes.Add(node);
                }

                tvRepositories.Nodes.AddRange(nodes.ToArray());
                for (var index = 0; index < dirs.Length; index++)
                {
                    string dir = dirs[index];
                    var dirName = Path.GetFileName(dir);
                    _output[dirName] = new List<string>();
                    PrintToUi(
                        $"{Environment.NewLine}{Environment.NewLine}{DateTime.Now.ToShortTimeString()}: executing git.exe clean -d -fx on repository: " +
                        dir);
                    nodes[index].ImageIndex = nodes[index].SelectedImageIndex = 1;
                    await ExecuteGitCommand("clean -d -fx", dir, dirName);
                    nodes[index].ImageIndex = nodes[index].SelectedImageIndex = 2;
                    PrintToUi(
                        $"{DateTime.Now.ToShortTimeString()}: Done git.exe clean -d -fx on repository: {dir}{Environment.NewLine}{Environment.NewLine}");
                }
            }
        }

        private void btnListFolders_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepositoryRoot.Text) && Directory.Exists(txtRepositoryRoot.Text))
            {
                if (chkbClearLog.Checked)
                {
                    richTextBox1.Text = "";
                }

                tvRepositories.Nodes.Clear();
                _output.Clear();
                bool currentFolderIsGit = CheckIfCurrentFolderIsGet(txtRepositoryRoot.Text);
                var dirs = !currentFolderIsGit
                    ? Directory.GetDirectories(txtRepositoryRoot.Text)
                    : new[] { txtRepositoryRoot.Text };

                List<TreeNode> nodes = new List<TreeNode>();
                foreach (var dir in dirs)
                {
                    var dirName = Path.GetFileName(dir);
                    var node = new TreeNode(dirName, 0, 0) { Tag = dir };
                    nodes.Add(node);
                }

                tvRepositories.Nodes.AddRange(nodes.ToArray());
            }
        }

        private async void tsmiPullFolder_Click(object sender, EventArgs e)
        {
            if (tvRepositories.SelectedNode?.Tag is GitNode gt)
            {
                await PullRepo(gt.LocalFolder, tvRepositories.Nodes.IndexOf(tvRepositories.SelectedNode));
            }
        }

        private void btnCleanObjAndBinFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepositoryRoot.Text) && Directory.Exists(txtRepositoryRoot.Text))
            {
                var BinDirs = Directory.GetDirectories(txtRepositoryRoot.Text, "bin", SearchOption.AllDirectories);
                var ObjDirs = Directory.GetDirectories(txtRepositoryRoot.Text, "obj", SearchOption.AllDirectories);
                var dirs = BinDirs.ToList();
                dirs.AddRange(ObjDirs);
                foreach (var dir in dirs)
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        PrintToUi($"deleted: {dir}");

                    }
                    catch (Exception exception)
                    {
                        PrintToUi($"Error delete {dir}:{exception.Message}");
                    }
                }
            }
        }

        private void tsmiFetchRepoHistory_Click(object sender, EventArgs e)
        {
            if (tvRepositories.SelectedNode?.Tag is GitNode gt)
            {
                FetchRepoHistory(gt.LocalFolder);
            }
        }

        private void FetchRepoHistory(string repoPath)
        {
            using (var repo = new Repository(repoPath))
            {
                var RFC2822Format = "ddd dd MMM HH:mm:ss yyyy K";
                IEnumerable<Commit> commits;
                commits = repo.Commits.Take(10);
                StringBuilder sb = new StringBuilder($"Repo: {repoPath}" + Environment.NewLine);
                foreach (Commit c in commits)
                {
                    string msg = $"{(c.Parents.Any() ? $"{c.Message} Merge: {string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray())}" : c.Message)} (Committer: {c.Committer.Name} {c.Committer.Email}). Author: {c.Author.Name} ({c.Author.Email})";
                    sb.AppendLine(msg.Replace("\n", ""));
                }
                PrintToUi(sb.ToString());
            }

        }

        private async void btnUsefullForks_Click(object sender, EventArgs e)
        {
            pnlUsefulForkRoot.Controls.Clear();
            usefulForksCenterPanel.Controls.Clear();
            

            var rootFork = new RepositorySettings(txtbUsefullForks.Text, txtbUsefullForks.Text, 0);
            var (newData, repoInfo) = await GitHubUtils.GetAsync<GithubRepo>(rootFork.RepoApiUrl,
                UserSettingsManager.Instance.GitHubToken, DateTime.MinValue);
            ForkedRepository root = new ForkedRepository(repoInfo,repoInfo.PushTime);
            pnlUsefulForkRoot.Controls.Add(root);
            List<GithubRepo> repos = new List<GithubRepo>();
            if (repoInfo.Forks > 0)
            {
                await GetForks(repoInfo, repos);
            }

            var results = repos.OrderByDescending(r => r.Stargazers).ThenByDescending(r => r.PushTime).ToList();
            results.Reverse();
            foreach (GithubRepo repo in results)
            {

                ForkedRepository ar1 = new ForkedRepository(repo,repoInfo.PushTime);
                usefulForksCenterPanel.Controls.Add(ar1);
                ar1.Dock = DockStyle.Top;

            }


        }

        private async Task GetForks(GithubRepo repo, List<GithubRepo> repos)
        {

            List<GithubRepo> forks = new List<GithubRepo>();
            int page = 1;
            bool hasMore = true;
            while (hasMore)
            {
                var forksData = await GitHubUtils.GetAsync<GithubRepo[]>(repo.ForksUrl + "?per_page=100&page=" + page,
                    UserSettingsManager.Instance.GitHubToken, DateTime.MinValue);
                if (forksData.result != null)
                {


                    foreach (var fork in forksData.result)
                    {
                        forks.Add(fork);
                    }
                }
                hasMore = forksData.result is { Length: 100 };

                page++;
            }
            repos.AddRange(forks);
            foreach (var fork in forks)
            {
                if (fork.Forks > 0)
                {
                    await GetForks(fork, repos);
                }
            }
        }

        private async void btnPruneRemotes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepositoryRoot.Text) && Directory.Exists(txtRepositoryRoot.Text))
            {
                if (chkbClearLog.Checked)
                {
                    richTextBox1.Text = "";
                }

                tvRepositories.Nodes.Clear();
                _output.Clear();
                bool currentFolderIsGit = CheckIfCurrentFolderIsGet(txtRepositoryRoot.Text);
                var dirs = !currentFolderIsGit
                    ? Directory.GetDirectories(txtRepositoryRoot.Text)
                    : new[] { txtRepositoryRoot.Text };

                List<TreeNode> nodes = new List<TreeNode>();
                foreach (var dir in dirs)
                {
                    GitNode gn = new GitNode(dir, GetBranchName(dir));
                    var node = new TreeNode(gn.DisplayName, 0, 0) { Tag = gn };
                    nodes.Add(node);
                }

                tvRepositories.Nodes.AddRange(nodes.ToArray());
                for (var index = 0; index < dirs.Length; index++)
                {
                    string dir = dirs[index];
                    await PruneRepo(dir, index);
                }
            }

        }
        private async Task PruneRepo(string dir, int index)
        {
            var dirName = Path.GetFileName(dir);
            _output[dirName] = new List<string>();
            PrintToUi($"{DateTime.Now.ToShortTimeString()}: Pruning repository: " + dir);
            tvRepositories.Nodes[index].ImageIndex = tvRepositories.Nodes[index].SelectedImageIndex = 1;
            await ExecuteGitCommand("remote prune origin", dir, dirName);
            tvRepositories.Nodes[index].ImageIndex = _output[dirName][0].Contains("Already up to date")
                ? tvRepositories.Nodes[index].SelectedImageIndex = 2
                : tvRepositories.Nodes[index].SelectedImageIndex = 4;
            PrintToUi(
                $"{DateTime.Now.ToShortTimeString()}: End pulling repository: {dir}{Environment.NewLine}{Environment.NewLine}");

        }
    }
}

