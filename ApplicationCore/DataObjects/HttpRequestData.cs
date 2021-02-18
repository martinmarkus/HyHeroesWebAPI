using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.DataObjects
{
    public class HttpRequestData
    {
        public string JsonContent { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }

        public Dictionary<string, string> HeaderValues { get; set; }
    }
}
