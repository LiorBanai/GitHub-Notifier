using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubNotifier.DataTypes
{
    [Serializable]
    [JsonObject]
    public class GithubAsset
    {
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("content_type")]
        public string ContentType { get; set; }
        [JsonProperty("size")]
        public long Size { get; set; }
        [JsonProperty("download_count")]
        public int Downloads { get; set; }
        [JsonProperty("created_at")]
        public DateTime Created { get; set; }
        [JsonProperty("updated_at")]
        public DateTime Updated { get; set; }
        [JsonProperty("browser_download_url")]
        public string BrowserDownloadUrl { get; set; }

        public override string ToString() => $"Asset Name: {Name}, URL: {URL}, Size: {Size}, Downloads: {Downloads}, Created: {Created}";
    }
}
