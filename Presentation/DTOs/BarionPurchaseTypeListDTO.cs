using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionPurchaseTypeListDTO
    {
        public IList<BarionPurchaseTypeDTO> BarionPurchaseTypes { get; set; } = new List<BarionPurchaseTypeDTO>();
    }
}
