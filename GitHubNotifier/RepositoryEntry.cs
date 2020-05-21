using GitHubNotifier.DataTypes;
using GitHubNotifier.Properties;
using GitHubNotifier.Utils;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubNotifier
{
    public partial class RepositoryEntry : UserControl
    {
        private string Name { get; set; }
        private string uri { get; set; }
        private int TotalDownloads { get; set; } = 0;
        private int Stars { get; set; } = 0;

        public RepositoryEntry()
        {
            InitializeComponent();
        }

        public RepositoryEntry(string name, string apiUri, string repoUri) : this()
        {
            this.uri = apiUri;
            Name = name;
            lnkLabel.Text = repoUri;
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
            var entries = (await GitHubUtils.GetAsync<GithubReleaseEntry[]>(uri + "/releases")).OrderByDescending(r => r.Published).ToList();
            var downloads = entries.SelectMany(entry => entry.Assets).Sum(a => a.Downloads);
            if (TotalDownloads >= 0 && downloads > TotalDownloads)
            {
                TotalDownloads = entries.SelectMany(entry => entry.Assets).Sum(a => a.Downloads);
                lblDownloads.Text = "Downloads: " + TotalDownloads;
                PopupMessage msg = new PopupMessage
                {
                    Caption = Name,
                    Text = lblDownloads.Text,
                    Image = Resources.Download_32x32
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
            else
            {
                TotalDownloads = entries.SelectMany(entry => entry.Assets).Sum(a => a.Downloads);
                lblDownloads.Text = "Downloads: " + TotalDownloads;
            }
        }
        public async Task CheckStars()
        {
            var repoInfo = await GitHubUtils.GetAsync<GithubRepo>(uri);
            if (Stars >= 0 && repoInfo.Stargazers > Stars)
            {
                lblLikes.Text = "Likes: " + repoInfo.Stargazers;
                PopupMessage msg = new PopupMessage
                {
                    Caption = Name,
                    Text = lblLikes.Text,
                    Image = Resources.Feature_32x32
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
            else
            {
                lblLikes.Text = "Likes: " + repoInfo.Stargazers;
            }

            Stars = repoInfo.Stargazers;
        }

        private async void timerUpdate_Tick(object sender, EventArgs e)
        {
            await Check();
        }
    }
}
