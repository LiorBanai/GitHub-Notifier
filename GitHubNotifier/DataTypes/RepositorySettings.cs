using System;

namespace GitHubNotifier.DataTypes
{
    [Serializable]

    public class RepositorySettings
    {
        public string DisplayName { get; set; }
        public string RepoName { get; set; }
        public string RepoUrl => $"https://github.com/{RepoName}";
        public string RepoIssueUrl => $"https://github.com/{RepoName}/issues";
        public string RepoApiUrl => $"https://api.github.com/repos/{RepoName}";
        public string RepoApiTrafficViewsUrl => $"https://api.github.com/repos/{RepoName}/traffic/views";
        public string RepoApiReleasesUrl => $"https://api.github.com/repos/{RepoName}/releases";


        public int UpdateMinutes { get; set; }
        public DateTime LastChecked { get; set; }

        public int LastTotalDownloads { get; set; }
        public int LastTotalStars { get; set; }
        public int LastTotalViews { get; set; }
        public int LastTotalUniqueViews { get; set; }

        public int OpenIssues { get; set; }
        public bool Enabled { get; set; }
        public bool ShowLikes { get; set; }
        public bool ShowDownloads { get; set; }
        public bool ShowOpenIssues { get; set; }
        public bool ShowViews { get; set; }
        public RepositorySettings()
        {
            Enabled = true;
            ShowLikes = true;
            ShowDownloads = true;
            ShowOpenIssues = true;
            ShowViews = true;

        }
        public RepositorySettings(string displayName, string repoName, int updateMinutes) : this()
        {
            DisplayName = displayName;
            RepoName = repoName;
            UpdateMinutes = updateMinutes;
        }

        public override string ToString()
        {
            return $"{nameof(RepoName)}: {RepoName}";
        }
    }
}
