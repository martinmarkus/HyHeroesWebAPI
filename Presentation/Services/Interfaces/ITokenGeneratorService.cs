namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface ITokenGeneratorService
    {
        string GenerateToken(string tokenId);
    }
}
