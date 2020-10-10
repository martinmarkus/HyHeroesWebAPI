using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IPayPalService
    {
        Task<PayPalTransactionDTO> CreatePayPalTransaction(string authenticatedUserName);
        Task<bool> ProcessIPNMessageAsync(PayPalIPNMessage newIPNMessage);
    }
}
