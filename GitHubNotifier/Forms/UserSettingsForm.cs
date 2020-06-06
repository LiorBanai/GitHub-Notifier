using GitHubNotifier.DataTypes;
using GitHubNotifier.Managers;
using System.Windows.Forms;

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
                DataTypes.RepositorySettings r = UserSettingsManager.Instance.Repositories[i];
                chklstRepo.SetItemCheckState(i, r.Enabled ? CheckState.Checked : CheckState.Unchecked);
            }
        }

        private void chklstRepo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chklstRepo.SelectedItem is RepositorySettings repo)
            {
                repo.Enabled = e.NewValue == CheckState.Checked;
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
                chkbLikes.Checked = repo.ShowLikes;
                chkbDownloads.Checked = repo.ShowDownloads;
                chkbOpenIssues.Checked = repo.ShowOpenIssues;
                chkbViews.Checked = repo.ShowViews;

            }
        }

        private void chkbLikes_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
                selectedRepositorySettings.ShowLikes = chkbLikes.Checked;
        }

        private void chkbDownloads_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
                selectedRepositorySettings.ShowDownloads = chkbDownloads.Checked;
        }

        private void chkbOpenIssues_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
                selectedRepositorySettings.ShowOpenIssues = chkbOpenIssues.Checked;
        }

        private void chkbViews_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
                selectedRepositorySettings.ShowViews = chkbViews.Checked;
        }

        private void chkbClones_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectedRepositorySettings != null)
                selectedRepositorySettings.ShowClones = chkbClones.Checked;
        }
    }

}
