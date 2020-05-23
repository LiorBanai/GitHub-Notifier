using System;
using Newtonsoft.Json;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class GitHubNotificationRepository
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("full_name")] public string FullName { get; set; }
        [JsonProperty("html_url")] public string RepositoryHtmlUrl { get; set; }
        [JsonProperty("description")] public string RepositoryDescription { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
    }

    [Serializable]
    [JsonObject]
    public class GitHubNotificationSubject
    {
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("url")] public string URL { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("latest_comment_url")] public string LatestCommentUrl { get; set; }

    }

    [Serializable]
    [JsonObject]
    public class GitHubUserNotification
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("unread")] public bool Unread { get; set; }
        [JsonProperty("updated_at")] public DateTime Updated { get; set; }
        [JsonProperty("subject")] public GitHubNotificationSubject Subject { get; set; }
        [JsonProperty("repository")] public GitHubNotificationRepository Repository { get; set; }
    }
}
