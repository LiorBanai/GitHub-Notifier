using GitHubNotifier.DataTypes;
using GitHubNotifier.Utils;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubNotifier.Managers;

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
            timerUpdate.Interval = repo.UpdateMinutes * 60 * 1000;
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
            
            var entries = (await GitHubUtils.GetAsync<GithubReleaseEntry[]>(Repo.RepoApiReleasesUrl, UserSettingsManager.Instance.GitHubToken)).OrderByDescending(r => r.Published).ToList();
            var downloads = entries.SelectMany(entry => entry.Assets).Sum(a => a.Downloads);
            if (Repo.LastTotalDownloads != downloads)
            {
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = lblDownloads.Text,
                    Image = Core.Properties.Resources.Download_32x32
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
        public async Task CheckStars()
        {
            var repoInfo = await GitHubUtils.GetAsync<GithubRepo>(Repo.RepoApiUrl, UserSettingsManager.Instance.GitHubToken);
            if (Repo.LastTotalStars != repoInfo.Stargazers)
            {
                PopupMessage msg = new PopupMessage
                {
                    Caption = Repo.DisplayName,
                    Text = "Likes: " + repoInfo.Stargazers,
                    Image = Core.Properties.Resources.Feature_32x32
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
        }

        private async void timerUpdate_Tick(object sender, EventArgs e)
        {
            await Check();
        }
    }
}
