using System;

namespace GitHubNotifier.DataTypes
{
    public class GitHubComment
    {
        public string url { get; set; }
        public string html_url { get; set; }
        public string issue_url { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public GithubUser user { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string author_association { get; set; }
        public string body { get; set; }
        public object performed_via_github_app { get; set; }
    }


    public class GitHubComments
    {
        private GitHubComment[] Comments { get; set; }
    }
}
