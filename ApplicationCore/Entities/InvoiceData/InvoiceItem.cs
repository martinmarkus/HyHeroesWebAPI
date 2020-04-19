namespace HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData
{
    public class InvoiceItem : BaseEntity
    {
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public decimal NetUnitPrice { get; set; } // netto egysegar

        public decimal GrossPrice { get; set; } // teljes brutto

        #nullable enable 
        public string? VtszSzjTeszor { get; set; } // nem kotelezo jelenleg 
        #nullable enable
    }
}
