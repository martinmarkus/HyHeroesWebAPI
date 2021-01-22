using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BannedIPListDTO
    {
        public IList<BannedIPDTO> BannedIPDTOs { get; set; } = new List<BannedIPDTO>();
    }
}
