using Microsoft.AspNetCore.Http;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PayPalIPNContextDTO
    {
        public HttpRequest IPNRequest { get; set; }

        public string RequestBody { get; set; }

        public string Verification { get; set; } = String.Empty;
    }
}
