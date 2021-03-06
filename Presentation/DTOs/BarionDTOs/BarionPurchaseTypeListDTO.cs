using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.BarionDTOs
{
    public class BarionPurchaseTypeListDTO
    {
        [JsonProperty("barionPurchaseTypes")]
        public IList<BarionPurchaseTypeDTO> BarionPurchaseTypes { get; set; } = new List<BarionPurchaseTypeDTO>();

        [JsonProperty("zips")]
        public IList<ZipCode> Zips { get; set; } = new List<ZipCode>();
    }
}
