namespace HyHeroesWebAPI.Presentation.Services
{
    public interface ITokenGeneratorService
    {
        string GenerateToken(string tokenId);
    }
}
