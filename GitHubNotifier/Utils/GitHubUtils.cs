using GitHubNotifier.DataTypes;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GitHubNotifier.Utils
{
    public static class GitHubUtils
    {
        public static event EventHandler<string> OnNameResolutionFailure;
        public static async Task<GitHubRateLimit> GetRateLimit(string token)
        {
            var data = await GetAsync<GitHubRateLimit>("https://api.github.com/rate_limit", token, DateTime.Now);
            return data.result;


        }

        public static async Task<(bool newData, T result)> GetAsync<T>(string uri, string token, DateTime lastModified)
        {
            try
            {
                Uri myUri = new Uri(uri);
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(myUri);
                myHttpWebRequest.Accept = "application/json";
                myHttpWebRequest.UserAgent = "GitHubNotifier";
                if (!string.IsNullOrEmpty(token))
                {
                    myHttpWebRequest.Headers.Add(HttpRequestHeader.Authorization, $"Token {token}");
                }

                myHttpWebRequest.IfModifiedSince = lastModified;

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)await myHttpWebRequest.GetResponseAsync();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.NotModified)
                {
                    return (false, default);
                }

                using (var reader = new System.IO.StreamReader(myHttpWebResponse.GetResponseStream()))
                {
                    string responseText = await reader.ReadToEndAsync();
                    return (true, JsonConvert.DeserializeObject<T>(responseText));
                }
            }
            catch (WebException e) when (e.Status == WebExceptionStatus.NameResolutionFailure)
            {
                OnNameResolutionFailure?.Invoke(null, "Error getting " + uri);
                return (false, default);
            }
            catch (WebException e) when (e.Status==WebExceptionStatus.UnknownError)
            {
                return (false, default);
            }
            catch (WebException e) when (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.NotModified)
            {
                return (false, default);
            }
            catch (WebException e) when (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.Unauthorized)
            {
                return (false, default);
            }
            catch (WebException e) when (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.Forbidden)
            {
                return (false, default);
            }
            catch (Exception)
            {
                return (false, default);
            }
        }



    }
}
