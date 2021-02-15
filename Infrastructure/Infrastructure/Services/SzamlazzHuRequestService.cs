using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using System;
using System.Net;
using System.Net.Http;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services
{
    public class SzamlazzHuRequestService : ISzamlazzHuRequestService
    {
        private static HttpClient _httpClient;

        private CookieContainer _cookies;

        public CookieContainer Cookies
        {
            get => _cookies;
            set => InitHttpClientHandler(value);
        }

        public SzamlazzHuRequestService()
        {
            InitHttpClientHandler(new CookieContainer());
        }

        public void InitHttpClientHandler(CookieContainer cookieContainer)
        {
            _cookies = cookieContainer;

            var handler = new HttpClientHandler()
            {
                CookieContainer = _cookies,
                UseCookies = true,
                AllowAutoRedirect = false
            };

            _httpClient = new HttpClient(handler);
        }

        public HttpResponseMessage SendRequest(ByteArrayContent content, string filename)
        {
            try
            {
                using (var form = new MultipartFormDataContent())
                {
                    form.Add(content, filename, "data.xml");

                    var result = _httpClient.PostAsync("https://www.szamlazz.hu/szamla/", form).Result;

                    return result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
