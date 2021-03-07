using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Entities;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IPayPalTokenService
    {
        public Task<PayPalToken> GetToken();
        public Task<PayPalToken> GenerateToken();
    }
}
