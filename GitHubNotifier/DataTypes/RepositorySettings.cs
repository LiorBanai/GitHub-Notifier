using System;

namespace GitHubNotifier.DataTypes
{
    [Serializable]

    public class RepositorySettings
    {
        public string DisplayName { get; set; }
        public string RepoName { get; set; }
        public string RepoUrl => $"https://github.com/{RepoName}";
        public string RepoApiUrl => $"https://api.github.com/repos/{RepoName}";
        public string RepoApiReleasesUrl => $"https://api.github.com/repos/{RepoName}/releases";

        public int UpdateMinutes { get; set; }

        public int LastTotalDownloads { get; set; }
        public int LastTotalStars { get; set; }
        public bool Enabled { get; set; }

        public RepositorySettings()
        {
            Enabled = true;
        }
        public RepositorySettings(string displayName, string repoName):this()
        {
            DisplayName = displayName;
            RepoName = repoName;
            UpdateMinutes = 30;
        }

        public override string ToString()
        {
            return $"{nameof(RepoName)}: {RepoName}";
        }
    }
}
