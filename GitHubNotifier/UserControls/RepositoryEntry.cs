using GitHubNotifier.DataTypes;
using GitHubNotifier.Managers;
using GitHubNotifier.Utils;
using System;
using System.Collections.Generic;
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
            timerUpdate.Enabled = repo.Active;
            lblNext.Text = "Next check: " + DateTime.Now.AddMilliseconds(repo.UpdateMinutes * 60 * 1000);
        }

        private async void RepositoryEntry_Load(object sender, EventArgs e)
        {
            lblViews.Visible = Repo.ShowViews;
            lblDownloads.Visible = Repo.ShowDownloads;
            lblLikes.Visible = Repo.ShowLikes;
            lnklblIssues.Visible = Repo.ShowOpenIssues;
            lblClones.Visible = Repo.ShowClones;
            lblDownloads.Text = "Downloads: " + Repo.LastTotalDownloads;
            lblLikes.Text = "Likes: " + Repo.LastTotalStars;
            lnklblIssues.Text = "Open Issues: " + Repo.OpenIssues;
            lblViews.Text = $"Views: {Repo.LastTotalViews}. U:{Repo.LastTotalUniqueViews}";
            if (Repo.Active)
            {
                await Check(true);
            }
        }

        public bool Active() => Repo.Active;
        public async Task Check(bool forceCheck)
        {

            lblViews.Visible = Repo.ShowViews;
            lblDownloads.Visible = Repo.ShowDownloads;
            lblLikes.Visible = Repo.ShowLikes;
            lnklblIssues.Visible = Repo.ShowOpenIssues;
            lblClones.Visible = Repo.ShowClones;
            if (!Repo.Active && !forceCheck)
            {
                return;
            }

            if (Repo.ShowDownloads)
            {
                await CheckDownloads(forceCheck);
            }

            if (Repo.ShowLikes || Repo.ShowOpenIssues)
            {
                await CheckStarsAndIssues(forceCheck);
            }

            if (Repo.ShowViews)
            {
                await CheckTrafficViews(forceCheck);
            }

            if (Repo.ShowClones)
            {
                await CheckTrafficClone(forceCheck);
            }

            Repo.LastChecked = DateTime.Now;

        }

        private async Task CheckTrafficViews(bool forceCheck)
        {
            var lastCheck = forceCheck ? DateTime.MinValue : Repo.LastChecked;
            var (newData, views) = await GitHubUtils.GetAsync<GithubTrafficViews>(Repo.RepoApiTrafficViewsUrl,
                UserSettingsManager.Instance.GitHubToken, lastCheck);
            if (!newData)
            {
                return;
            }

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
                        popupNotifier.TitleFont = new Font(popupNotifier.TitleFont.FontFamily, 16.0f);
                        popupNotifier.ContentColor = change > 0 ? Color.ForestGreen : Color.Red;
                        popupNotifier.IgnoreWhenFullScreen = true;
                        popupNotifier.ContentFont = new Font(popupNotifier.ContentFont.FontFamily, 14.0f);
                        popupNotifier.AutoContentHeight = true;

                    }
                    if (change > 0 || !UserSettingsManager.Instance.DoNotShowDecrementPopups)
                    {
                        popupNotifier.Popup();
                    }
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
        private async Task CheckTrafficClone(bool forceCheck)
        {
            var lastCheck = forceCheck ? DateTime.MinValue : Repo.LastChecked;
            var (newData, clones) = await GitHubUtils.GetAsync<GithubTrafficClones>(Repo.RepoApiTrafficClonesUrl,
                UserSettingsManager.Instance.GitHubToken, lastCheck);
            if (!newData)
            {
                return;
            }

            if (Repo.LastTotalClones != clones.Total)
            {
                int change = clones.Total - Repo.LastTotalClones;
                lblClones.BackColor = change > 0 ? Color.LightGreen : Color.LightPink;
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = $"Clones: {clones.Total} ({(change > 0 ? "+" : string.Empty)}{change})",
                    Image = Properties.Resources.NewDataSource_32x32
                };
                using (var popupNotifier = new NotificationWindow.PopupNotifier())
                {
                    {
                        popupNotifier.TitleText = msg.Caption;
                        popupNotifier.ContentText = msg.Text;
                        popupNotifier.IsRightToLeft = false;
                        popupNotifier.Image = msg.Image;
                        popupNotifier.TitleFont = new Font(popupNotifier.TitleFont.FontFamily, 16.0f);
                        popupNotifier.ContentColor = change > 0 ? Color.ForestGreen : Color.Red;
                        popupNotifier.IgnoreWhenFullScreen = true;
                        popupNotifier.ContentFont = new Font(popupNotifier.ContentFont.FontFamily, 14.0f);
                        popupNotifier.AutoContentHeight = true;

                    }
                    if (change > 0 || !UserSettingsManager.Instance.DoNotShowDecrementPopups)
                    {
                        popupNotifier.Popup();
                    }
                }
            }
            else
            {
                lblClones.BackColor = SystemColors.Control;
            }

            lblClones.Text = $"Clones: {clones.Total}. U:{clones.uniques}";
            Repo.LastTotalClones = clones.Total;
            Repo.LastTotalUniqueClones = clones.uniques;
        }

        private async Task CheckDownloads(bool forceCheck)
        {
            var lastCheck = forceCheck ? DateTime.MinValue : Repo.LastChecked;
            var (newData, entries) = await GitHubUtils.GetAsync<GithubReleaseEntry[]>(Repo.RepoApiReleasesUrl,
                UserSettingsManager.Instance.GitHubToken, lastCheck);
            if (!newData)
            {
                return;
            }

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
                    AutoContentHeight = true,
                    IgnoreWhenFullScreen = true
                })
                {
                    popupNotifier.TitleFont = new Font(popupNotifier.TitleFont.FontFamily, 16.0f);
                    popupNotifier.ContentColor = change > 0 ? Color.ForestGreen : Color.Red;
                    popupNotifier.ContentFont = new Font(popupNotifier.ContentFont.FontFamily, 14.0f);
                    if (change > 0 || !UserSettingsManager.Instance.DoNotShowDecrementPopups)
                    {
                        popupNotifier.Popup();
                    }
                }
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
            if (!Repo.ShowOpenIssues && !Repo.ShowLikes)
            {
                return;
            }

            var lastCheck = forceCheck ? DateTime.MinValue : Repo.LastChecked;
            var (newData, repoInfo) = await GitHubUtils.GetAsync<GithubRepo>(Repo.RepoApiUrl, UserSettingsManager.Instance.GitHubToken, lastCheck);
            if (!newData)
            {
                return;
            }

            if (Repo.ShowLikes && Repo.LastTotalStars != repoInfo.Stargazers)
            {
                int change = repoInfo.Stargazers - Repo.LastTotalStars;
                lblLikes.BackColor = change > 0 ? Color.LightGreen : Color.LightPink;
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = $"Stars: {repoInfo.Stargazers} ({(change > 0 ? "+" : string.Empty)}{change})",
                    Image = Properties.Resources.Feature_32x32
                };
                using (var popupNotifier = new NotificationWindow.PopupNotifier())
                {
                    {
                        popupNotifier.TitleText = msg.Caption;
                        popupNotifier.ContentText = msg.Text;
                        popupNotifier.IsRightToLeft = false;
                        popupNotifier.Image = msg.Image;
                        popupNotifier.TitleFont = new Font(popupNotifier.TitleFont.FontFamily, 16.0f);
                        popupNotifier.ContentColor = change > 0 ? Color.ForestGreen : Color.Red;
                        popupNotifier.ContentFont = new Font(popupNotifier.ContentFont.FontFamily, 14.0f);
                        popupNotifier.IgnoreWhenFullScreen = true;
                        popupNotifier.AutoContentHeight = true;
                    }
                    if (change > 0 || !UserSettingsManager.Instance.DoNotShowDecrementPopups)
                    {
                        popupNotifier.Popup();
                    }
                }
            }
            else
            {
                lblLikes.BackColor = SystemColors.Control;
            }

            Repo.LastTotalStars = repoInfo.Stargazers;
            lblLikes.Text = "Stars: " + repoInfo.Stargazers;
            List<GitHubIssue> relevantIssues = new List<GitHubIssue>();
            if (Repo.ShowOpenIssues && Repo.OpenIssues != repoInfo.OpenIssues)
            {
                int change = repoInfo.OpenIssues - Repo.OpenIssues;
                string issuesInfo = string.Empty;
                if (change > 0)
                {
                    var issues = await GitHubUtils.GetAsync<GitHubIssue[]>(Repo.RepoApiIssuesUrl,
                        UserSettingsManager.Instance.GitHubToken, lastCheck);
                    if (issues.newData)
                    {
                        relevantIssues = issues.result.Take(change).ToList();
                        //foreach (var issue in relevantIssues)
                        //{
                        //    if (issue.comments > 0)
                        //    {
                        //        var comments = await GitHubUtils.GetAsync<GitHubComment[]>(issue.comments_url,
                        //        UserSettingsManager.Instance.GitHubToken, lastCheck);
                        //    }

                        //}
                        issuesInfo = string.Join(Environment.NewLine, relevantIssues.Select(i => i.Title));
                        cmsIssues.Items.Clear();
                        foreach (var issue in relevantIssues)
                        {
                            cmsIssues.Items.Add(issue.Title, null, (_, __) => OpenLink(issue.html_url));
                        }
                    }
                }
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = $"Open Issues: {repoInfo.OpenIssues} ({(change > 0 ? "+" : string.Empty)}{change}): {issuesInfo}",
                    Image = Properties.Resources.Feature_32x32,
                };
                foreach (var issue in relevantIssues)
                {

                    using (var popupNotifier = new NotificationWindow.PopupNotifier())
                    {
                        {
                            popupNotifier.TitleText = msg.Caption;
                            popupNotifier.ContentText = issue.Title;
                            popupNotifier.IsRightToLeft = false;
                            popupNotifier.Image = msg.Image;
                            popupNotifier.TitleFont = new Font(popupNotifier.TitleFont.FontFamily, 14.0f);
                            popupNotifier.ContentColor = change > 0 ? Color.ForestGreen : Color.Red;
                            popupNotifier.ContentFont = new Font(popupNotifier.ContentFont.FontFamily, 11);
                            popupNotifier.IgnoreWhenFullScreen = true;
                            popupNotifier.AutoContentHeight = true;
                        }
                        if (change > 0 || !UserSettingsManager.Instance.DoNotShowDecrementPopups)
                        {
                            popupNotifier.Popup();
                        }
                    }
                }

                Repo.OpenIssues = repoInfo.OpenIssues;
                lnklblIssues.Text = "Open Issues: " + repoInfo.OpenIssues;
                lnklblIssues.BackColor = change > 0 ? Color.LightGreen : Color.LightPink;
            }
            else
            {
                lnklblIssues.BackColor = SystemColors.Control;
            }
        }

        private async void timerUpdate_Tick(object sender, EventArgs e)
        {
            await UpdateValues(false);
        }

        private async void btnCheckNow_Click(object sender, EventArgs e)
        {
            await UpdateValues(true);
        }

        private async Task UpdateValues(bool forceCheck)
        {
            await Check(forceCheck);
            timerUpdate.Stop();
            timerUpdate.Start();
            lblNext.Text = "Next check: " + DateTime.Now.AddMilliseconds(timerUpdate.Interval);

        }
        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenLink(Repo.RepoUrl);
        }

        private void lnklblIssues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OpenLink(Repo.RepoIssueUrl);
            }
        }

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception)
            {
                //ignore 

            }
        }

    }
}
