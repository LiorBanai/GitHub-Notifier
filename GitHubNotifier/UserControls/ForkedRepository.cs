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
        private GithubCommit[] Commits { get; }
        private DateTime RootPushTime { get; }
        private DateTime RootLatestCommit { get; }
        private DateTime NewestCommit { get; }

        public ForkedRepository()
        {
            InitializeComponent();
        }

        public ForkedRepository(GithubRepo repo, GithubCommit[] commits) : this()
        {
            Repo = repo;
            RootPushTime = repo.PushTime;
            Commits = commits;
            NewestCommit = commits.Max(c => c.commit.author.date);
            RootLatestCommit = NewestCommit;

        }


        public ForkedRepository(GithubRepo repo, GithubCommit[] commits, DateTime rootPushTime, DateTime rootLatestCommit) : this()
        {
            Repo = repo;
            RootPushTime = rootPushTime;
            RootLatestCommit = rootLatestCommit;
            Commits = commits;
            NewestCommit = commits.Max(c => c.commit.author.date);
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
            lblLatestCommit.Text = $"Newest Commit:{NewestCommit}. Ahead: ({Commits.Count(c => c.commit.author.date > RootLatestCommit)})";
            if (RootLatestCommit < NewestCommit)
            {
                lblLatestCommit.ForeColor = Color.Green;
            }
        }
    }
}
