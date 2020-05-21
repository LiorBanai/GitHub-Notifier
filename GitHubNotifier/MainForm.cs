using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GitHubNotifier
{
    public partial class Form1 : Form
    {
        List<RepositoryEntry> repos = new List<RepositoryEntry>();
        private bool preventExit = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible)
                Hide();
            else
                Show();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //  var result = await GitHubUtils.GetRateLimit(Environment.GetEnvironmentVariable("GitHub_notifications"));
            //AddRepo("messagePack", "https://api.github.com/repos/neuecc/MessagePack-CSharp");
            // AddRepo("messagePack", "https://api.github.com/repos/neuecc/MessagePack-CSharp");
            AddRepo("vscode", "https://api.github.com/repos/microsoft/vscode", "");
            AddRepo("messagePack", "https://api.github.com/repos/neuecc/MessagePack-CSharp", "");
            AddRepo("Analogy RegexParser", "https://api.github.com/repos/Analogy-LogViewer/Analogy.LogViewer.RegexParser", "");
            AddRepo("Analogy Serilog", "https://api.github.com/repos/Analogy-LogViewer/Analogy.LogViewer.Serilog", "");
            AddRepo("Analogy Log viewer", "https://api.github.com/repos/Analogy-LogViewer/Analogy.LogViewer", "");
        }
        private void AddRepo(string name, string apiUri, string htmlUrl)
        {
            RepositoryEntry ar1 = new RepositoryEntry(name, apiUri, htmlUrl);
            repos.Add(ar1);
            panel1.Controls.Add(ar1);
            ar1.Dock = DockStyle.Top;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            preventExit = false;
            Close();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (preventExit)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
