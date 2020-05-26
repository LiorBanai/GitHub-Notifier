using Newtonsoft.Json;
using System;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class GithubTrafficView
    {
        [JsonProperty("count")] public int Count { get; set; }
        [JsonProperty("uniques")] public int Uniques { get; set; }
        [JsonProperty("timestamp")] public DateTime Timestamp { get; set; }
    }

    [Serializable]
    [JsonObject]
    public class GithubTraffic
    {
        [JsonProperty("count")] public int Total { get; set; }
        [JsonProperty("views")] public GithubTrafficView[] Views { get; set; }
    }
}
