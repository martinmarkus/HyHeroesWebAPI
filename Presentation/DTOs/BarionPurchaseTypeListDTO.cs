using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionPurchaseTypeListDTO
    {
        [JsonProperty("barionPurchaseTypes")]
        public IList<BarionPurchaseTypeDTO> BarionPurchaseTypes { get; set; } = new List<BarionPurchaseTypeDTO>();

        [JsonProperty("zips")]
        public IList<ZipCode> Zips { get; set; } = new List<ZipCode>();
    }
}
