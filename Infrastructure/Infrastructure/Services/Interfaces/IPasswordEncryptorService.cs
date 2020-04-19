namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IPasswordEncryptorService
    {
        string CreateHash(string password, string salt);
        string CreateSalt();
    }
}
