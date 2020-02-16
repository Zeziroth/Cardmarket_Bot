using System;
using System.IO;
using System.Net;
using System.Text;

namespace Cardmarket_Bot
{
    public static class RequestHelper
    {
        public static string MakeRequest(string customURL, params dynamic[] args)
        {
            String method = "GET";
            String url = String.Format(Settings.API_ENDPOINT + customURL, args);

            HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
            OAuthHeader header = new OAuthHeader();
            request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
            request.Method = method;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            return readStream.ReadToEnd();
        }
    }
}
