namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface ICustomAntiforgeryService
    {
        bool Validate(string baseAntiforgeryValue, string baseAntiforgeryKey, string encryptedAntiforgery);
    }
}
