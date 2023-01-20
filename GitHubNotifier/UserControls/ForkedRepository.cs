using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubNotifier.DataTypes;

namespace GitHubNotifier.UserControls
{
    public partial class ForkedRepository : UserControl
    {
        private GithubRepo Repo { get; }
        private DateTime RootPushTime { get; }

        public ForkedRepository()
        {
            InitializeComponent();
        }

        public ForkedRepository(GithubRepo repo, DateTime rootPushTime) : this()
        {
            Repo = repo;
            RootPushTime = rootPushTime;
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(Repo.HtmlUrl);
        }

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception)
            {
                //ignore 

            }
        }

        private void ForkedRepository_Load(object sender, EventArgs e)
        {
            lnkLabel.Text = Repo.FullName;
            lblLikes.Text = "Stars: " + Repo.Stargazers;
            lblUpdated.Text = "Push Time: " + Repo.PushTime;
            if (RootPushTime < Repo.PushTime)
            {
                lblUpdated.ForeColor = Color.Green;
            }
        }
    }
}
