using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ApplyBankTransferDTO
    {
        [Required]
        [JsonProperty("transferCode")]
        public string TransferCode { get; set; }
    }
}
