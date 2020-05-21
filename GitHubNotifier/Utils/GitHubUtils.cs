using GitHubNotifier.DataTypes;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubNotifier.Utils
{
    public static class GitHubUtils
    {
        public static async Task<GitHubRateLimit> GetRateLimit(string token = null)
        {
            string uri = "https://api.github.com/rate_limit";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("GitHubNotifier");//Set the User Agent to "request"
                if (!string.IsNullOrEmpty(token))
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", token);
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    response.EnsureSuccessStatusCode();
                    var answer = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<GitHubRateLimit>(answer);
                }
            }
        }

        public static async Task<T> GetAsync<T>(string uri, string token = null)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("GitHubNotifier");//Set the User Agent to "request"
                if (!string.IsNullOrEmpty(token))
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", token);
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    response.EnsureSuccessStatusCode();
                    var answer = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(answer);
                }
            }
        }



    }
}
