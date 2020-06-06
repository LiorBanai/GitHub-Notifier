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
    public class GithubTrafficViews
    {
        [JsonProperty("count")] public int Total { get; set; }
        [JsonProperty("views")] public GithubTrafficView[] Views { get; set; }
    }

    [Serializable]
    [JsonObject]
    public class GithubTrafficClones
    {
        [JsonProperty("count")] public int Total { get; set; }
        [JsonProperty("Uniques")] public int uniques { get; set; }
        [JsonProperty("clones")] public Clone[] Clones { get; set; }
    }

    public class Clone
    {
        public DateTime timestamp { get; set; }
        public int count { get; set; }
        public int uniques { get; set; }
    }

}
