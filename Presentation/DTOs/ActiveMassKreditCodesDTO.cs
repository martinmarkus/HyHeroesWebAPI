using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ActiveMassKreditCodesDTO
    {
        public IList<MassKreditCodeDTO> ActiveMassKreditCodes { get; set; } = new List<MassKreditCodeDTO>();
    }
}
