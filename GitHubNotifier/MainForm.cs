using GitHubNotifier.DataTypes;
using GitHubNotifier.Forms;
using GitHubNotifier.Managers;
using GitHubNotifier.UserControls;
using GitHubNotifier.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubNotifier
{
    public partial class MainForm : Form
    {
        List<RepositoryEntry> repos = new List<RepositoryEntry>();
        private UserSettingsManager Settings => UserSettingsManager.Instance;
        private bool preventExit = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
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
            }
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
            foreach (RepositorySettings repo in Settings.Repositories)
            {
                if (repo.Active)
                {
                    AddRepo(repo, tpActive);
                }
                else
                {
                    AddRepo(repo, tpNonActive);
                }
            }

            tabControl1.SelectedIndex = 0;
            timerNotifications.Interval = Settings.NotificationsIntervalCheck * 60 * 1000;
            if (Settings.StartMinimized)
            {
                Hide();
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
                    IgnoreWhenFullScreen = true
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
                            }
                            popupNotifier.Popup();
                        }
                    }
                }
            }


            if (Settings.LastUnReadUserNotifications.Any())
            {
                lstNotifications.Items.Clear();
                lstNotifications.Items.AddRange(Settings.LastUnReadUserNotifications.Select(n => $"{n.Repository.FullName}:  {n.Subject.Title}").ToArray());
            }

            tsslblNotifications.Text = $"Notification: {Settings.LastUnReadUserNotifications.Count}. Last Update: {Settings.LastReadUserNotification}";

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
                var dirs = chkbSubfoldersRepositories.Checked
                    ? Directory.GetDirectories(txtRepositoryRoot.Text)
                    : new[] {txtRepositoryRoot.Text};
                foreach (string dir in dirs)
                {
                   PrintToUi("################### Fetching repository: "+dir);
                   await PullOrFetchRepository("fetch", dir); 
                    PrintToUi("################### End Fetching repository: " + dir);
                }
            }
        }
        private async void btnPull_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepositoryRoot.Text) && Directory.Exists(txtRepositoryRoot.Text))
            {
                var dirs = chkbSubfoldersRepositories.Checked
                    ? Directory.GetDirectories(txtRepositoryRoot.Text)
                    : new[] { txtRepositoryRoot.Text }; foreach (string dir in dirs)
                {
                    PrintToUi("################### Fetching repository: " + dir);
                    await PullOrFetchRepository("pull", dir);
                    PrintToUi("################### End Fetching repository: " + dir);
                }
            }
        }

        private Task PullOrFetchRepository(string command, string repoPath)
        {
            try
            {
                TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
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
                    PrintToUi(e.Data);
                };
                publishCmd.ErrorDataReceived += (s, e) =>
                {
                    PrintToUi(e.Data);
                };
                publishCmd.StartInfo = start;
                publishCmd.Exited += (_, e) =>
                {
                    PrintToUi($"######## Git operation Ended for command: {command}"); 
                    tcs.SetResult($"Process Exited for git.exe");
                };
                publishCmd.EnableRaisingEvents = true;
                publishCmd.Start();
                publishCmd.BeginOutputReadLine();
                publishCmd.BeginErrorReadLine();
                Thread.Sleep(1000);
                return tcs.Task;
                
            }
            catch (Exception e)
            {
                PrintToUi($"######## ERROR: Git operation Ended for command: {command}: {e.Message}");
            }
            return Task.CompletedTask;
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
                await CheckNotifications(true);
                await CheckAll();
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            Show();
            BringToFront();
            Focus();
        }
    }
}
