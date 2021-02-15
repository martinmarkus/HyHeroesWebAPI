namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DataObjects
{
    public class BillCreationResponse
    {
        public bool IsCreated { get; set; }

        public string RequestXml { get; set; }

        public string CreatedPDF { get; set; }

        public string ErrorCode { get; set; }
    }
}
