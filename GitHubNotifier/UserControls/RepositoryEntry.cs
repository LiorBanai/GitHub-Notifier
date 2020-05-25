using GitHubNotifier.DataTypes;
using GitHubNotifier.Managers;
using GitHubNotifier.Utils;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubNotifier.UserControls
{
    public partial class RepositoryEntry : UserControl
    {
        private RepositorySettings Repo;

        public RepositoryEntry()
        {
            InitializeComponent();
        }

        public RepositoryEntry(RepositorySettings repo) : this()
        {
            Repo = repo;
            lnkLabel.Text = repo.RepoUrl;
            timerUpdate.Interval = repo.UpdateMinutes * 60 * 1000;
            lblNext.Text = "Next check: " + DateTime.Now.AddMilliseconds(repo.UpdateMinutes * 60 * 1000);
        }

        private async void RepositoryEntry_Load(object sender, EventArgs e)
        {
            lblDownloads.Text = "Downloads: " + Repo.LastTotalDownloads;
            lblLikes.Text = "Likes: " + Repo.LastTotalStars;
            lblOpenIssues.Text = "Open Issues: " + Repo.OpenIssues;
            await Check(true);
        }
        public async Task Check(bool forceCheck)
        {
            await CheckDownloads(forceCheck);
            await CheckStarsAndIssues(forceCheck);
            Repo.LastChecked = DateTime.Now;

        }

        private async Task CheckDownloads(bool forceCheck)
        {
            var lastCheck = forceCheck ? DateTime.MinValue : Repo.LastChecked;
            var (newData, entries) = await GitHubUtils.GetAsync<GithubReleaseEntry[]>(Repo.RepoApiReleasesUrl,
                UserSettingsManager.Instance.GitHubToken, lastCheck);
            if (!newData)
                return;

            var downloads = entries.OrderByDescending(r => r.Published).SelectMany(entry => entry.Assets).Sum(a => a.Downloads);
            if (Repo.LastTotalDownloads != downloads)
            {
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = lblDownloads.Text,
                    Image = Properties.Resources.Download_32x32
                };
                var popupNotifier = new NotificationWindow.PopupNotifier
                {
                    TitleText = msg.Caption,
                    ContentText = msg.Text,
                    IsRightToLeft = false,
                    Image = msg.Image
                };
                popupNotifier.Popup();
            }

            lblDownloads.Text = "Downloads: " + downloads;
            Repo.LastTotalDownloads = downloads;
        }

        private async Task CheckStarsAndIssues(bool forceCheck)
        {
            var lastCheck = forceCheck ? DateTime.MinValue : Repo.LastChecked;
            var (newData, repoInfo) = await GitHubUtils.GetAsync<GithubRepo>(Repo.RepoApiUrl, UserSettingsManager.Instance.GitHubToken, lastCheck);
            if (!newData)
                return;
            if (Repo.LastTotalStars != repoInfo.Stargazers)
            {
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = "Likes: " + repoInfo.Stargazers,
                    Image = Properties.Resources.Feature_32x32
                };
                var popupNotifier = new NotificationWindow.PopupNotifier
                {
                    TitleText = msg.Caption,
                    ContentText = msg.Text,
                    IsRightToLeft = false,
                    Image = msg.Image
                };
                popupNotifier.Popup();
            }

            Repo.LastTotalStars = repoInfo.Stargazers;
            lblLikes.Text = "Likes: " + repoInfo.Stargazers;

            if (Repo.OpenIssues != repoInfo.OpenIssues)
            {
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = "Open Issues: " + repoInfo.OpenIssues,
                    Image = Properties.Resources.Feature_32x32
                };
                var popupNotifier = new NotificationWindow.PopupNotifier
                {
                    TitleText = msg.Caption,
                    ContentText = msg.Text,
                    IsRightToLeft = false,
                    Image = msg.Image
                };
                popupNotifier.Popup();
            }
            Repo.OpenIssues = repoInfo.OpenIssues;
            lblOpenIssues.Text = "Open Issues: " + repoInfo.OpenIssues;

        }

        private async void timerUpdate_Tick(object sender, EventArgs e)
        {
            await Check(false);
            lblNext.Text = "Next check: " + DateTime.Now.AddMilliseconds(timerUpdate.Interval);
        }

        private async void btnCheckNow_Click(object sender, EventArgs e)
        {
            await Check(true);
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(lnkLabel.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }
        }
    }
}
