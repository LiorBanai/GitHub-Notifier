using GitHubNotifier.DataTypes;
using GitHubNotifier.Properties;
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
        public event EventHandler RepositoriesChanged;
        public List<RepositorySettings> Repositories { get; set; }
        public DateTime LastReadUserNotification { get; set; }
        public List<GitHubUserNotification> LastUnReadUserNotifications { get; set; }
        public int NotificationsIntervalCheck { get; set; }
        public bool ShowNotificationsOnlyOnce { get; set; }
        public string GitHubToken { get; } = Environment.GetEnvironmentVariable("GitHubNotifier_Token");
        public bool StartMinimized { get; set; }
        public bool DoNotShowDecrementPopups { get; set; }
        public string RepositoryRoot { get; set; }

        private UserSettingsManager()
        {
            NotificationsIntervalCheck = 15;
            LastUnReadUserNotifications = new List<GitHubUserNotification>();
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
            LastUnReadUserNotifications = ParseSettings<List<GitHubUserNotification>>(Settings.Default.LastUnReadUserNotifications);
            LastReadUserNotification = Settings.Default.LastReadUserNotification;
            NotificationsIntervalCheck = Settings.Default.NotificationsIntervalCheck;
            StartMinimized = Settings.Default.StartMinimized;
            ShowNotificationsOnlyOnce = Settings.Default.ShowNotificationsOnlyOnce;
            DoNotShowDecrementPopups = Settings.Default.DoNotShowDecrementPopups;
            Repositories = ParseSettings<List<RepositorySettings>>(Settings.Default.Repositories);
            RepositoryRoot = Settings.Default.RepositoryRoot;

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
            Save();
            RepositoriesChanged?.Invoke(this,EventArgs.Empty);

        }

        internal void RemoveRepository(RepositorySettings repo)
        {
            Repositories.Remove(repo);
            Save();
            RepositoriesChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Save()
        {
            Settings.Default.Repositories = JsonConvert.SerializeObject(Repositories);
            Settings.Default.LastReadUserNotification = LastReadUserNotification;
            Settings.Default.NotificationsIntervalCheck = NotificationsIntervalCheck;
            Settings.Default.LastUnReadUserNotifications = JsonConvert.SerializeObject(LastUnReadUserNotifications);
            Settings.Default.StartMinimized = StartMinimized;
            Settings.Default.ShowNotificationsOnlyOnce = ShowNotificationsOnlyOnce;
            Settings.Default.DoNotShowDecrementPopups = DoNotShowDecrementPopups;
            Settings.Default.RepositoryRoot= RepositoryRoot;
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