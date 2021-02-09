using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BankTransferListDTO
    {
        [JsonProperty("bankTransfers")]
        public IList<BankTransferDTO> BankTransfers { get; set; } = new List<BankTransferDTO>();
    }
}
