using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("billingobillingaddresses")]
    public class BillingoBillingAddress : BaseEntity
    {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("post_code")]
        public string PostCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonIgnore]
        public virtual BillingoPartner BillingoPartner { get; set; }
    }
}
