using Newtonsoft.Json;
using System;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class GithubRepo
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("full_name")] public string FullName { get; set; }
        [JsonProperty("fork")] public bool Fork { get; set; }
        [JsonProperty("private")] public bool Private { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("stargazers_count")] public int Stargazers { get; set; }
        [JsonProperty("watchers_count")] public int Watchers { get; set; }
        [JsonProperty("subscribers_count")] public int Subscribers { get; set; }
        [JsonProperty("forks_count")] public int Forks { get; set; }
        [JsonProperty("open_issues_count")] public int OpenIssues { get; set; }
    }
}
