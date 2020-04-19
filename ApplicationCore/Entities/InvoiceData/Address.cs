namespace HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData
{
    public class Address : BaseEntity
    {
        public string CityName { get; set; }

        public int ZipCode { get; set; }

        public string AddressLine { get; set; }
    }
}
