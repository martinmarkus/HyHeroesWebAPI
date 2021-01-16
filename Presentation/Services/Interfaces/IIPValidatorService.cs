namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IIPValidatorService
    {
        string GenerateToken(string userIP);

        bool ValidateToken(
            string assertAntiforgeryToken,
            string userIP);
    }
}
