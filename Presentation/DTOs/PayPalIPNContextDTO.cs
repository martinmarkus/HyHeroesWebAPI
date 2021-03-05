using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PayPalIPNContextDTO
    {
        public HttpRequest IPNRequest { get; set; }

        public string RequestBody { get; set; }

        public string Verification { get; set; } = String.Empty;
    }
}
