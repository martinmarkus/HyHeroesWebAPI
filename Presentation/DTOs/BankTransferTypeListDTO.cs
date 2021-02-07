using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BankTransferTypeListDTO
    {
        [JsonProperty("bankTransferPurchaseTypes")]
        public IList<BankTransferPurchaseTypeDTO> BankTransferPurchaseTypes { get; set; } = new List<BankTransferPurchaseTypeDTO>();

        [JsonProperty("zips")]
        public IList<ZipCode> Zips { get; set; } = new List<ZipCode>();
    }
}
