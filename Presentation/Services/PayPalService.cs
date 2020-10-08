using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PayPalService : IPayPalService
    {
        public async Task<bool> ProcessIPNAsync(PayPalIPNDTO payPalIPNDTO)
        {
            throw new NotImplementedException();
        }
    }
}
