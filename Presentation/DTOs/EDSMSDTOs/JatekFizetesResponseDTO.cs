using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.EDSMSDTOs
{
    public class JatekFizetesResponseDTO
    {
        [JsonProperty("jatekFizetesResponseCode")]
        public string JatekFizetesResponseCode { get; set; }
    }
}
