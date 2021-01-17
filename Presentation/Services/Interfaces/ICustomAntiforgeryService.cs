namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface ICustomAntiforgeryService
    {
        bool Validate(string baseValue, string encryptedValue, string salt);
    }
}
