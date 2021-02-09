using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class FinalizeBankTransferDTO
    {
        [Required]
        [JsonProperty("bankTransferCode")]
        public string BankTransferCode { get; set; }
    }
}
