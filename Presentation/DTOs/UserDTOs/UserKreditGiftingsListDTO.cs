using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class UserKreditGiftingsListDTO
    {
        [JsonProperty("userKreditGiftings")]
        public IList<UserKreditGiftingsDTO> UserKreditGiftings { get; set; } = new List<UserKreditGiftingsDTO>();
    }
}
