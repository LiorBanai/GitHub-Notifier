using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubNotifier.DataTypes
{
    internal class GitNode
    {
        public string LocalFolder { get; set; }
        public string BranchName { get; set; }
        public string DisplayName => $"{Path.GetFileName(LocalFolder)} ({BranchName})";

        public GitNode(string localFolder, string branchName)
        {
            LocalFolder = localFolder;
            BranchName = branchName;
        }

        public override string ToString()
        {
            return $"{nameof(LocalFolder)}: {LocalFolder}, {nameof(BranchName)}: {BranchName}";
        }
    }
}
