using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalCaptureStatusDTO
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
