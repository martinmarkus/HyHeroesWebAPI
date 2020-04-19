using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<User> LoginAsync(string emailOrUserName, string password);

        Task<User> RegisterAsync(User user);

        Task<bool> UserAlreadyExists(NewUser newUser);
    }
}
