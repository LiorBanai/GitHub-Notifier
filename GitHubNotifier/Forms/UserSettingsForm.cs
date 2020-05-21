using GitHubNotifier.DataTypes;
using GitHubNotifier.Managers;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace GitHubNotifier.Forms
{
    public partial class UserSettingsForm : Form
    {
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
        }

        private void btnAddRepo_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbRepoDisplayName.Text) && !string.IsNullOrEmpty(txtbRepoName.Text))
            {
                UserSettingsManager.Instance.AddNewRepository(txtbRepoDisplayName.Text, txtbRepoName.Text,(int)nudMinutes.Value);
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
    }

}
