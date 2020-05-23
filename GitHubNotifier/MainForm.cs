using GitHubNotifier.DataTypes;
using GitHubNotifier.Forms;
using GitHubNotifier.Managers;
using GitHubNotifier.UserControls;
using GitHubNotifier.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Hide();
            else
                Show();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await CheckAPILimits();
            await CheckNotifications();
            foreach (RepositorySettings repo in Settings.Repositories)
            {
                AddRepo(repo);
            }

            tabControl1.SelectedIndex = 0;
            timerNotifications.Interval = Settings.NotificationsIntervalCheck * 60 * 1000;
        }

        private async Task CheckAPILimits()
        {
            var result = await GitHubUtils.GetRateLimit(Settings.GitHubToken);
            tsslblAPILimit.Text = "API Limits:" + result.Rate;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (preventExit)
            {
                e.Cancel = true;
                Hide();
                var popupNotifier = new NotificationWindow.PopupNotifier
                {
                    TitleText = "GitHub Notifier",
                    ContentText = "Still here. Right click and exit to close",
                    IsRightToLeft = false,
                    Image = Properties.Resources.Feature_32x32
                };
                popupNotifier.Popup();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSettingsManager.Instance.Save();
        }


        private void AddRepo(RepositorySettings repo)
        {
            RepositoryEntry ar1 = new RepositoryEntry(repo);
            repos.Add(ar1);
            tpRepo.Controls.Add(ar1);
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

        private async Task CheckNotifications()
        {
            if (DateTime.Now < Settings.LastReadUserNotification.AddMinutes(Settings.NotificationsIntervalCheck))
                return;
            var (newData, notifications) = await GitHubUtils.GetAsync<GitHubUserNotification[]>("https://api.github.com/notifications", UserSettingsManager.Instance.GitHubToken, UserSettingsManager.Instance.LastReadUserNotification);
            if (newData && notifications.Any(n => n.Unread))
            {
                UserSettingsManager.Instance.LastReadUserNotification = DateTime.Now;
                lstNotifications.Items.Clear();
                lstNotifications.Items.AddRange(notifications.Where(n => n.Unread).Select(n => n.Subject.Title).ToArray());
            }

        }

        private void tsmiExitForm_Click(object sender, EventArgs e)
        {
            ExitAndClose();
        }
    }
}
