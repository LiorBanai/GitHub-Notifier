using GitHubNotifier.DataTypes;
using GitHubNotifier.Forms;
using GitHubNotifier.Managers;
using GitHubNotifier.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GitHubNotifier
{
    public partial class MainForm : Form
    {
        List<RepositoryEntry> repos = new List<RepositoryEntry>();
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
            var result = await GitHubUtils.GetRateLimit(UserSettingsManager.Instance.GitHubToken);
            tsslblAPILimit.Text = "Api Limits:" + result.Rate;
            foreach (RepositorySettings repo in UserSettingsManager.Instance.Repositories)
            {
                AddRepo(repo);

                //AddRepo("messagePack", "https://api.github.com/repos/neuecc/MessagePack-CSharp");
                // AddRepo("messagePack", "https://api.github.com/repos/neuecc/MessagePack-CSharp");
                //AddRepo("vscode", "https://api.github.com/repos/microsoft/vscode", "");
                // AddRepo("messagePack", "https://api.github.com/repos/neuecc/MessagePack-CSharp", "");
                // AddRepo("Analogy RegexParser", "https://api.github.com/repos/Analogy-LogViewer/Analogy.LogViewer.RegexParser", "");
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (preventExit)
            {
                e.Cancel = true;
                Hide();
                var popupNotifier = new NotificationWindow.PopupNotifier
                {
                    TitleText = "GitHun Notifier",
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
            preventExit = false;
            Close();
            Application.Exit();
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            UserSettingsForm form = new UserSettingsForm();
            form.Show(this);
        }
    }
}
