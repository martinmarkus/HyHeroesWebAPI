namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IStringEncryptorService
    {
        string CreateHash(string password, string salt);
       
        string CreateSalt();

        string CreateHMACSHA256(string value, string key);
    }
}
