using GitHubNotifier.DataTypes;
using GitHubNotifier.Managers;
using GitHubNotifier.Utils;
using System;
using System.Diagnostics;
using System.Drawing;
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
            lnkLabel.Text = repo.DisplayName;
            timerUpdate.Interval = repo.UpdateMinutes * 60 * 1000;
            lblNext.Text = "Next check: " + DateTime.Now.AddMilliseconds(repo.UpdateMinutes * 60 * 1000);
        }

        private async void RepositoryEntry_Load(object sender, EventArgs e)
        {
            lblDownloads.Text = "Downloads: " + Repo.LastTotalDownloads;
            lblLikes.Text = "Likes: " + Repo.LastTotalStars;
            lnklblIssues.Text = "Open Issues: " + Repo.OpenIssues;
            lblViews.Text = $"Views: {Repo.LastTotalViews}. U:{Repo.LastTotalUniqueViews}";
            await Check(true);
        }
        public async Task Check(bool forceCheck)
        {
            lblViews.Visible = Repo.ShowViews;
            lblDownloads.Visible = Repo.ShowDownloads;
            lblLikes.Visible = Repo.ShowLikes;
            lnklblIssues.Visible = Repo.ShowOpenIssues;
            if (Repo.ShowDownloads)
                await CheckDownloads(forceCheck);
            if (Repo.ShowLikes || Repo.ShowOpenIssues)
                await CheckStarsAndIssues(forceCheck);
            if (Repo.ShowViews)
                await CheckTraffic(forceCheck);
            Repo.LastChecked = DateTime.Now;

        }

        private async Task CheckTraffic(bool forceCheck)
        {
            var lastCheck = forceCheck ? DateTime.MinValue : Repo.LastChecked;
            var (newData, views) = await GitHubUtils.GetAsync<GithubTraffic>(Repo.RepoApiTrafficViewsUrl,
                UserSettingsManager.Instance.GitHubToken, lastCheck);
            if (!newData)
                return;
            if (Repo.LastTotalViews != views.Total)
            {
                int change = views.Total - Repo.LastTotalViews;
                lblViews.BackColor = change > 0 ? Color.LightGreen : Color.LightPink;
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = $"Views: {views.Total} ({(change > 0 ? "+" : string.Empty)}{change})",
                    Image = Properties.Resources.Show_32x32
                };
                using (var popupNotifier = new NotificationWindow.PopupNotifier())
                {
                    {
                        popupNotifier.TitleText = msg.Caption;
                        popupNotifier.ContentText = msg.Text;
                        popupNotifier.IsRightToLeft = false;
                        popupNotifier.Image = msg.Image;
                        popupNotifier.IgnoreWhenFullScreen = true;
                    }
                    popupNotifier.Popup();
                }
            }
            else
            {
                lblViews.BackColor = SystemColors.Control;
            }

            lblViews.Text = $"Views: {views.Total}. U:{views.Views.Sum(v => v.Uniques)}";
            Repo.LastTotalViews = views.Total;
            Repo.LastTotalUniqueViews = views.Views.Sum(v => v.Uniques);
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
                int change = downloads - Repo.LastTotalDownloads;
                lblDownloads.BackColor = change > 0 ? Color.LightGreen : Color.LightPink;
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = $"Downloads: {downloads} ({(change > 0 ? "+" : string.Empty)}{change})",
                    Image = Properties.Resources.Download_32x32
                };
                using (var popupNotifier = new NotificationWindow.PopupNotifier
                {
                    TitleText = msg.Caption,
                    ContentText = msg.Text,
                    IsRightToLeft = false,
                    Image = msg.Image,
                    IgnoreWhenFullScreen = true
                })
                    popupNotifier.Popup();
            }
            else
            {
                lblDownloads.BackColor = SystemColors.Control;
            }


            lblDownloads.Text = "Downloads: " + downloads;
            Repo.LastTotalDownloads = downloads;
        }

        private async Task CheckStarsAndIssues(bool forceCheck)
        {
            if (!Repo.ShowOpenIssues && !Repo.ShowLikes) return;
            var lastCheck = forceCheck ? DateTime.MinValue : Repo.LastChecked;
            var (newData, repoInfo) = await GitHubUtils.GetAsync<GithubRepo>(Repo.RepoApiUrl, UserSettingsManager.Instance.GitHubToken, lastCheck);
            if (!newData)
                return;
            if (Repo.ShowLikes && Repo.LastTotalStars != repoInfo.Stargazers)
            {
                int change = repoInfo.Stargazers - Repo.LastTotalStars;
                lblLikes.BackColor = change > 0 ? Color.LightGreen : Color.LightPink;
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = $"Likes: {repoInfo.Stargazers} ({(change > 0 ? "+" : string.Empty)}{change})",
                    Image = Properties.Resources.Feature_32x32
                };
                using (var popupNotifier = new NotificationWindow.PopupNotifier())
                {
                    {
                        popupNotifier.TitleText = msg.Caption;
                        popupNotifier.ContentText = msg.Text;
                        popupNotifier.IsRightToLeft = false;
                        popupNotifier.Image = msg.Image;
                        popupNotifier.IgnoreWhenFullScreen = true;
                    }
                    popupNotifier.Popup();
                }
            }
            else
            {
                lblLikes.BackColor = SystemColors.Control;
            }

            Repo.LastTotalStars = repoInfo.Stargazers;
            lblLikes.Text = "Likes: " + repoInfo.Stargazers;

            if (Repo.ShowOpenIssues && Repo.OpenIssues != repoInfo.OpenIssues)
            {
                int change = repoInfo.OpenIssues - Repo.OpenIssues;
                lnklblIssues.BackColor = change > 0 ? Color.LightGreen : Color.LightPink;
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = $"Open Issues: {repoInfo.OpenIssues} ({(change > 0 ? "+" : string.Empty)}{change})",
                    Image = Properties.Resources.Feature_32x32,
                };
                using (var popupNotifier = new NotificationWindow.PopupNotifier())
                {
                    {
                        popupNotifier.TitleText = msg.Caption;
                        popupNotifier.ContentText = msg.Text;
                        popupNotifier.IsRightToLeft = false;
                        popupNotifier.Image = msg.Image;
                        popupNotifier.IgnoreWhenFullScreen = true;
                    }
                    popupNotifier.Popup();
                }
            }
            else
            {
                lnklblIssues.BackColor = SystemColors.Control;
            }

            Repo.OpenIssues = repoInfo.OpenIssues;
            lnklblIssues.Text = "Open Issues: " + repoInfo.OpenIssues;

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
            OpenLink(Repo.RepoUrl);
        }

        private void lnklblIssues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(Repo.RepoIssueUrl);
        }

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }
        }

    }
}
