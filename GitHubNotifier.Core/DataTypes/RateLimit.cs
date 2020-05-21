using Newtonsoft.Json;
using System;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class RateLimit
    {
        [JsonProperty("limit")] public int Limit { get; set; }
        [JsonProperty("remaining")] public int Remaining { get; set; }
        [JsonProperty("reset")] public int Reset { get; set; }
        public DateTime ResetTime => DateTimeOffset.FromUnixTimeSeconds(Reset).ToLocalTime().DateTime;

        public override string ToString()
        {
            return $"remaining: {Remaining}/{Limit}. Reset at: {ResetTime}";
        }
    }
}
