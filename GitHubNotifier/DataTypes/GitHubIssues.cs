using Newtonsoft.Json;
using System;

namespace GitHubNotifier.DataTypes
{
    public class GitHubIssue
    {
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("repository_url")]
        public string repository_url { get; set; }
        [JsonProperty("labels_url")]
        public string labels_url { get; set; }
        [JsonProperty("comments_url")]
        public string comments_url { get; set; }
        [JsonProperty("events_url")]
        public string events_url { get; set; }
        [JsonProperty("html_url")]
        public string html_url { get; set; }
        [JsonProperty("node_id")]
        public string node_id { get; set; }
        [JsonProperty("number")]
        public int number { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("User")]
        public GithubUser User { get; set; }
        public GitHubLabel[] labels { get; set; }
        public string state { get; set; }
        public bool locked { get; set; }
        public object assignee { get; set; }
        public object[] assignees { get; set; }
        public object milestone { get; set; }
        public int comments { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object closed_at { get; set; }
        public string author_association { get; set; }
        public string body { get; set; }
        public GitHubPullRequest pull_request { get; set; }
    }


    public class GitHubPullRequest
    {
        public string url { get; set; }
        public string html_url { get; set; }
        public string diff_url { get; set; }
        public string patch_url { get; set; }
    }

    public class GitHubLabel
    {
        public long id { get; set; }
        public string node_id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public bool _default { get; set; }
        public string description { get; set; }
    }

}
