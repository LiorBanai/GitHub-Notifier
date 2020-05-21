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

        public List<RepositorySettings> Repositories { get; set; }

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

            Repositories = ParseSettings<List<RepositorySettings>>(Settings.Default.Repositories);
            if (Repositories == null || !Repositories.Any())
            {
                Repositories = new List<RepositorySettings>
                {
                    new RepositorySettings("Analogy Log Viewer","Analogy-LogViewer/Analogy.LogViewer"),
                    new RepositorySettings("Analogy Serilog", "Analogy-LogViewer/Analogy.LogViewer.Serilog")
                };
            }

        }

        internal void AddNewRepository(string displayName, string id)
        {
            Repositories.Add(new RepositorySettings(displayName, id));
        }
        internal void RemoveRepository(RepositorySettings repo) => Repositories.Remove(repo);
        public void Save()
        {
            Settings.Default.Repositories = JsonConvert.SerializeObject(Repositories);
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