using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BankTransferListDTO
    {
        public IList<BankTransferDTO> BankTransfers { get; set; } = new List<BankTransferDTO>();
    }
}
