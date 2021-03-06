using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.BankTransferDTOs
{
    public class BankTransferTypeListDTO
    {
        [JsonProperty("bankTransferPurchaseTypes")]
        public IList<BankTransferPurchaseTypeDTO> BankTransferPurchaseTypes { get; set; } = new List<BankTransferPurchaseTypeDTO>();

        //[JsonProperty("zips")]
        //public IList<ZipCode> Zips { get; set; } = new List<ZipCode>();
    }
}
