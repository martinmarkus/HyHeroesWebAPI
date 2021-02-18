using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services
{
    public class HttpRequestService : IHttpRequestService
    {
        public async Task<HttpResponseData> GetJsonResponseAsync(HttpRequestData httpRequestData)
        {
            if (httpRequestData == null)
            {
                throw new NullReferenceException();
            }

            HttpResponseData response = default;
            try
            {
                response = await SendRequestWithWebRequest(httpRequestData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return response;
        }

        private async Task<HttpResponseData> SendRequestWithWebRequest(HttpRequestData httpRequestData)
        {
            try
            {
                var webRequest = WebRequest.Create(httpRequestData.Url);

                webRequest.Method = httpRequestData.Method;
                webRequest.Timeout = 12000;
                webRequest.ContentType = "application/json";

                if (httpRequestData.HeaderValues != null && httpRequestData.HeaderValues.Count > 0)
                {
                    foreach (var headerValue in httpRequestData.HeaderValues)
                    {
                        webRequest.Headers.Add(headerValue.Key, headerValue.Value);
                    }
                }

                if (!string.IsNullOrEmpty(httpRequestData.JsonContent)
                    && !httpRequestData.Method.Equals("GET", StringComparison.OrdinalIgnoreCase))
                {
                    var contentBytes = Encoding.UTF8.GetBytes(httpRequestData.JsonContent);
                    var reqStream = webRequest.GetRequestStream();
                    reqStream.Write(contentBytes, 0, contentBytes.Length);
                    reqStream.Close();

                    if (webRequest.ContentLength != contentBytes.Length)
                    {
                        webRequest.ContentLength = contentBytes.Length;
                    }
                }

                var response = webRequest.GetResponseAsync();
                await Task.WhenAll(response);

                using (System.IO.Stream s = response.Result.GetResponseStream())
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                    {
                        return new HttpResponseData()
                        {
                            JsonContent = sr.ReadToEnd()
                        };
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            throw new FormatException();
        }
    }
}
