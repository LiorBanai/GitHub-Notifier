using Newtonsoft.Json;
using System;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class RateLimit
    {
        [JsonProperty("limit")] public long Limit { get; set; }
        [JsonProperty("remaining")] public long Remaining { get; set; }
        [JsonProperty("reset")] public long Reset { get; set; }
        public DateTime ResetTime => DateTimeOffset.FromUnixTimeSeconds(Reset).ToLocalTime().DateTime;

        public override string ToString()
        {
            return $"remaining: {Remaining}/{Limit}. Reset at: {ResetTime}";
        }
    }
}