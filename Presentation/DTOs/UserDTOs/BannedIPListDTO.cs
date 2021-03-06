using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class BannedIPListDTO
    {
        public IList<BannedIPDTO> BannedIPDTOs { get; set; } = new List<BannedIPDTO>();
    }
}
