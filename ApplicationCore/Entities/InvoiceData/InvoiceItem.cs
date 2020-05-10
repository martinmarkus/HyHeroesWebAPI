namespace HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData
{
    public class InvoiceItem : BaseEntity
    {
        public string Name { get; set; }

        public int Amount { get; set; }

        public int NetUnitPrice { get; set; } // netto egysegar

        public int GrossPrice { get; set; } // teljes brutto

        #nullable enable 
        public string? VtszSzjTeszor { get; set; } // nem kotelezo jelenleg 
        #nullable enable
    }
}
