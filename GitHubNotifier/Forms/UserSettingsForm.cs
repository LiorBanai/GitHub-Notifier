using System;
using System.Collections.Generic;
using System.IO;
using GitHubNotifier.DataTypes;
using GitHubNotifier.Managers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GitHubNotifier.Forms
{
    public partial class UserSettingsForm : Form
    {
        private RepositorySettings selectedRepositorySettings;
        public UserSettingsForm()
        {
            InitializeComponent();
        }

        private void UserSettingsForm_Load(object sender, System.EventArgs e)
        {
            LoadSettings();
        }

        public void LoadSettings()
        {
            RefreshList();
            nudNotifications.Value = UserSettingsManager.Instance.NotificationsIntervalCheck;
            chkbStartMinimized.Checked = UserSettingsManager.Instance.StartMinimized;
            chkbShowNotificationsOnlyOnce.Checked = UserSettingsManager.Instance.ShowNotificationsOnlyOnce;
            chkbDoNotShowDecrementPopups.Checked = UserSettingsManager.Instance.DoNotShowDecrementPopups;
        }

        private void btnAddRepo_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbRepoDisplayName.Text) && !string.IsNullOrEmpty(txtbRepoName.Text))
            {
                UserSettingsManager.Instance.AddNewRepository(txtbRepoDisplayName.Text, txtbRepoName.Text, (int)nudMinutes.Value);
                RefreshList();
            }
        }

        private void RefreshList()
        {
            chklstRepo.Items.Clear();
            chklstRepo.Items.AddRange(UserSettingsManager.Instance.Repositories.ToArray());
            for (int i = 0; i < UserSettingsManager.Instance.Repositories.Count; i++)
            {
                RepositorySettings r = UserSettingsManager.Instance.Repositories[i];
                chklstRepo.SetItemCheckState(i, r.Active ? CheckState.Checked : CheckState.Unchecked);
            }
        }

        private void chklstRepo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chklstRepo.SelectedItem is RepositorySettings repo)
            {
                repo.Active = e.NewValue == CheckState.Checked;
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (chklstRepo.SelectedItem is RepositorySettings repo)
            {
                UserSettingsManager.Instance.RemoveRepository(repo);
                RefreshList();

            }
        }

        private void UserSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserSettingsManager.Instance.NotificationsIntervalCheck = (int)nudNotifications.Value;
        }

        private void chklstRepo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (chklstRepo.SelectedItem is RepositorySettings repo)
            {
                groupBox1.Text = "Repository:" + repo.DisplayName;
                selectedRepositorySettings = repo;
                chkbStars.Checked = repo.ShowLikes;
                chkbDownloads.Checked = repo.ShowDownloads;
                chkbOpenIssues.Checked = repo.ShowOpenIssues;
                chkbViews.Checked = repo.ShowViews;
                chkbClones.Checked = repo.ShowClones;
                txtSelectedRepoName.Text = repo.RepoName;
                txtSelectedRepoDisplayName.Text = repo.DisplayName;
            }
        }

        private void chkbStars_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
            {
                selectedRepositorySettings.ShowLikes = chkbStars.Checked;
            }
        }

        private void chkbDownloads_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
            {
                selectedRepositorySettings.ShowDownloads = chkbDownloads.Checked;
            }
        }

        private void chkbOpenIssues_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
            {
                selectedRepositorySettings.ShowOpenIssues = chkbOpenIssues.Checked;
            }
        }

        private void chkbViews_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
            {
                selectedRepositorySettings.ShowViews = chkbViews.Checked;
            }
        }

        private void chkbClones_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
            {
                selectedRepositorySettings.ShowClones = chkbClones.Checked;
            }
        }

        private void txtSelectedRepoName_TextChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
            {
                selectedRepositorySettings.RepoName = txtSelectedRepoName.Text;
            }
        }

        private void txtSelectedRepoDisplayName_TextChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
            {
                selectedRepositorySettings.DisplayName = txtSelectedRepoDisplayName.Text;
            }
        }

        private void chkbStartMinimized_CheckedChanged(object sender, System.EventArgs e)
        {
            UserSettingsManager.Instance.StartMinimized = chkbStartMinimized.Checked;
        }

        private void chkbShowNotificationsOnlyOnce_CheckedChanged(object sender, System.EventArgs e)
        {
            UserSettingsManager.Instance.ShowNotificationsOnlyOnce = chkbShowNotificationsOnlyOnce.Checked;
        }

        private void chkbDoNotShowDecrementPopups_CheckedChanged(object sender, System.EventArgs e)
        {
            UserSettingsManager.Instance.DoNotShowDecrementPopups = chkbDoNotShowDecrementPopups.Checked;
        }

        private void btnImport_Click(object sender, System.EventArgs e)
        {
            FileDialog f = new OpenFileDialog();
            f.Filter = "json file|*.json";
            f.Title = "Import repositories";
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var data = File.ReadAllText(f.FileName);
                    List<RepositorySettings> repositories = JsonConvert.DeserializeObject<List<RepositorySettings>>(data);
                    UserSettingsManager.Instance.Repositories = repositories;
                    RefreshList();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error: {exception.Message}", "Error importing Json", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "json file|*.json";
            saveFileDialog1.Title = "Export repositories";
            ;

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var data = JsonConvert.SerializeObject(UserSettingsManager.Instance.Repositories);
                File.WriteAllText(saveFileDialog1.FileName, data);
            }
        }
    }

}
