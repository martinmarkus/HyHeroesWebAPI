using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.ProductDTOs
{
    public class ExpiredProductsVerificationDTO
    {
        [Required]
        [JsonProperty("purchasedProductIds")]
        public IList<Guid> PurchasedProductIds { get; set; }

        [Required]
        [JsonProperty("serverId")]
        public Guid GameServerId { get; set; }
    }
}
