using GitHubNotifier.DataTypes;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubNotifier.Utils
{
    public static class GitHubUtils
    {
        public static async Task<GitHubRateLimit> GetRateLimit(string token)
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

        public static async Task<(bool newData, T result)> GetAsync<T>(string uri, string token, DateTime lastModified)
        {
            Uri myUri = new Uri(uri);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(myUri);
            myHttpWebRequest.Headers.Add(HttpRequestHeader.Accept, "application/json");
            myHttpWebRequest.Headers.Add(HttpRequestHeader.UserAgent, "GitHubNotifier");



            if (!string.IsNullOrEmpty(token))
                myHttpWebRequest.Headers.Add(HttpRequestHeader.Authorization, $"Token {token}");

            myHttpWebRequest.IfModifiedSince = lastModified;
            try
            {
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)await myHttpWebRequest.GetResponseAsync();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.NotModified)
                    return (false, default);

                using (var reader = new System.IO.StreamReader(myHttpWebResponse.GetResponseStream()))
                {
                    string responseText = await reader.ReadToEndAsync();
                    return (true, JsonConvert.DeserializeObject<T>(responseText));
                }
            }
            catch (WebException e) when (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.NotModified)
            {
                return (false, default);
            }
            //using (HttpClient client = new HttpClient())
            //{
            //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //    client.DefaultRequestHeaders.UserAgent.TryParseAdd("GitHubNotifier");//Set the User Agent to "request"
            //    if (!string.IsNullOrEmpty(token))
            //        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", token);
            //    client.DefaultRequestHeaders.IfModifiedSince = lastModified.ToUniversalTime();
            //    using (HttpResponseMessage response = await client.GetAsync(uri))
            //    {
            //        if (response.StatusCode == HttpStatusCode.NotModified)
            //            return (false, default);
            //        var answer = await response.Content.ReadAsStringAsync();
            //        return (true, JsonConvert.DeserializeObject<T>(answer));
            //    }
            //}
        }



    }
}
