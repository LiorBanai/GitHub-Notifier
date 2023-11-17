using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class GithubRepo
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("node_id")] public string NodeId { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("full_name")] public string FullName { get; set; }
        [JsonProperty("private")] public bool Private { get; set; }
        [JsonProperty("owner")] public GithubUser Owner { get; set; }

        [JsonProperty("fork")] public bool Fork { get; set; }

        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("stargazers_count")] public int Stargazers { get; set; }
        [JsonProperty("watchers_count")] public int Watchers { get; set; }
        [JsonProperty("subscribers_count")] public int Subscribers { get; set; }
        [JsonProperty("forks_count")] public int Forks { get; set; }
        [JsonProperty("forks_url")] public string ForksUrl { get; set; }
        [JsonProperty("url")] public string ApiUrl { get; set; }
        [JsonProperty("html_url")] public string HtmlUrl { get; set; }
        [JsonProperty("commits_url")] public string ApiCommitsUrl { get; set; }

        [JsonProperty("open_issues_count")] public int OpenIssues { get; set; }
        [JsonProperty("updated_at")] public DateTime UpdateTime { get; set; }
        [JsonProperty("pushed_at")] public DateTime PushTime { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Forks)}: {Forks}, {nameof(ApiUrl)}: {ApiUrl}";
        }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            ApiCommitsUrl = ApiCommitsUrl.Replace(@"{/sha}", "");
        }
    }
}