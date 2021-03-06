using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.EDSMSDTOs
{
    public class EDSMSPurchaseTypeListDTO
    {
        [JsonProperty("EDSMSPurchaseTypes")]
        public IList<EDSMSPurchaseTypeDTO> EDSMSPurchaseTypes { get; set; } = new List<EDSMSPurchaseTypeDTO>();
    }
}
