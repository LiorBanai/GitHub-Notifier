using GitHubNotifier.DataTypes;
using GitHubNotifier.Managers;
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
            timerUpdate.Interval = repo.UpdateMinutes * 60 * 1000;
        }

        private async void RepositoryEntry_Load(object sender, EventArgs e)
        {
            lblDownloads.Text = "Downloads: " + Repo.LastTotalDownloads;
            lblLikes.Text = "Likes: " + Repo.LastTotalStars;
            await Check();
        }
        public async Task Check()
        {
            await CheckDownloads();
            await CheckStars();
            Repo.LastChecked = DateTime.Now;

        }

        private async Task CheckDownloads()
        {

            var (newData, entries) = (await GitHubUtils.GetAsync<GithubReleaseEntry[]>(Repo.RepoApiReleasesUrl,
                UserSettingsManager.Instance.GitHubToken, Repo.LastChecked));
            Repo.LastChecked = DateTime.Now;
            if (!newData)
                return;

            var downloads = entries.OrderByDescending(r => r.Published).SelectMany(entry => entry.Assets).Sum(a => a.Downloads);
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

        private async Task CheckStars()
        {
            var (newData, repoInfo) = await GitHubUtils.GetAsync<GithubRepo>(Repo.RepoApiUrl, UserSettingsManager.Instance.GitHubToken, Repo.LastChecked);
            if (!newData)
                return;
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

        private async void btnCheckNow_Click(object sender, EventArgs e)
        {
            await Check();
        }
    }
}
