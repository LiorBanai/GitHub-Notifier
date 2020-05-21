using Newtonsoft.Json;
using System;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class GitHubResources
    {
        [JsonProperty("core")] public RateLimit Core { get; set; }
        [JsonProperty("graphql")] public RateLimit Graphql { get; set; }
        [JsonProperty("integration_manifest")] public RateLimit IntegrationManifest { get; set; }
        [JsonProperty("search")] public RateLimit Search { get; set; }
    }
}
