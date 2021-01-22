using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class AggregatedOnlinePlayerCountDTOList
    {
        public IList<AggregatedOnlinePlayerCountDTO> OnlinePlayerCountDTOs { get; set; } = new List<AggregatedOnlinePlayerCountDTO>();
    }
}
