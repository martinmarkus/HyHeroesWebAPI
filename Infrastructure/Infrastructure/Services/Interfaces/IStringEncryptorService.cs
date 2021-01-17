namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IStringEncryptorService
    {
        string CreateHash(string value, string salt, int hashSize = 24);
       
        string CreateSalt();

        string CreateHMACSHA256(string value, string key);
    }
}
