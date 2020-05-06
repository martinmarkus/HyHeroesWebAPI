using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<User> LoginAsync(LoginUser loginUser);

        Task<User> RegisterAsync(User user);

        Task<bool> UserAlreadyExists(NewUser newUser);
    }
}
