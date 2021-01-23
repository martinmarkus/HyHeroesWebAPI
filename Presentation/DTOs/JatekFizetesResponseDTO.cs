using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class JatekFizetesResponseDTO
    {
        [JsonProperty("jatekFizetesResponseCode")]
        public string JatekFizetesResponseCode { get; set; }
    }
}
