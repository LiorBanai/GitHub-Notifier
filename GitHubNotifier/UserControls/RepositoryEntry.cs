﻿using GitHubNotifier.DataTypes;
using GitHubNotifier.Utils;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubNotifier
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
        }

        private async void RepositoryEntry_Load(object sender, EventArgs e)
        {
            await Check();
        }
        public async Task Check()
        {
            await CheckDownloads();
            await CheckStars();
        }
        public async Task CheckDownloads()
        {
            var entries = (await GitHubUtils.GetAsync<GithubReleaseEntry[]>(Repo.RepoApiReleasesUrl)).OrderByDescending(r => r.Published).ToList();
            var downloads = entries.SelectMany(entry => entry.Assets).Sum(a => a.Downloads);
            if (Repo.LastTotalDownloads != downloads)
            {
                PopupMessage msg = new PopupMessage
                {
                    Caption = Name,
                    Text = lblDownloads.Text,
                    Image = Properties.Resources.Download_32x32
                };
                var popupNotifier = new Tulpep.NotificationWindow.PopupNotifier
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
        public async Task CheckStars()
        {
            var repoInfo = await GitHubUtils.GetAsync<GithubRepo>(Repo.RepoApiUrl);
            if (Repo.LastTotalStars != repoInfo.Stargazers)
            {
                PopupMessage msg = new PopupMessage
                {
                    Caption = Name,
                    Text = "Likes: " + repoInfo.Stargazers,
                    Image = Properties.Resources.Feature_32x32
                };
                var popupNotifier = new Tulpep.NotificationWindow.PopupNotifier
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
        }

        private async void timerUpdate_Tick(object sender, EventArgs e)
        {
            await Check();
        }
    }
}
