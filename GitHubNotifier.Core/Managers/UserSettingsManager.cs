using GitHubNotifier.Core.Properties;
using GitHubNotifier.DataTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GitHubNotifier.Managers
{
    public class UserSettingsManager
    {
        private static readonly Lazy<UserSettingsManager> _instance =
            new Lazy<UserSettingsManager>(() => new UserSettingsManager());

        public static UserSettingsManager Instance { get; set; } = _instance.Value;

        public List<RepositorySettings> Repositories { get; set; }
        public DateTime LastReadUserNotification { get; set; }
        public string GitHubToken { get; } = Environment.GetEnvironmentVariable("GitHubNotifier_Token");
        private UserSettingsManager()
        {
            Load();
        }

        private void Load()
        {
            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
            }

            LastReadUserNotification = Settings.Default.LastReadUserNotification;
            Repositories = ParseSettings<List<RepositorySettings>>(Settings.Default.Repositories);
            if (Repositories == null || !Repositories.Any())
            {
                Repositories = new List<RepositorySettings>
                {
                    new RepositorySettings("Analogy Log Viewer","Analogy-LogViewer/Analogy.LogViewer",15),
                    new RepositorySettings("Analogy Serilog", "Analogy-LogViewer/Analogy.LogViewer.Serilog",15)
                };
            }

        }

        internal void AddNewRepository(string displayName, string id, int updateInterval)
        {
            Repositories.Add(new RepositorySettings(displayName, id, updateInterval));
        }
        internal void RemoveRepository(RepositorySettings repo) => Repositories.Remove(repo);
        public void Save()
        {
            Settings.Default.Repositories = JsonConvert.SerializeObject(Repositories);
            Settings.Default.LastReadUserNotification = LastReadUserNotification;
            Settings.Default.Save();
        }
        private T ParseSettings<T>(string data) where T : new()
        {
            try
            {
                return string.IsNullOrEmpty(data) ?
                    new T() :
                    JsonConvert.DeserializeObject<T>(data);
            }
            catch (Exception e)
            {
                //LogManager.Instance.LogError("Error during parsing: " + e, nameof(UserSettingsManager));
                return new T();
            }


        }


    }
}