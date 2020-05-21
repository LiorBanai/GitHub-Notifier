using Newtonsoft.Json;
using System;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class GitHubRateLimit
    {
        [JsonProperty("resources")] public GitHubResources Resources { get; set; }
        [JsonProperty("rate")] public RateLimit Rate { get; set; }


    }
}
