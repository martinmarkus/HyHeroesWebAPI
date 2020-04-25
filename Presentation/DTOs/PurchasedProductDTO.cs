using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PurchasedProductDTO
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public decimal PricePerMonth { get; set; }

        public decimal PermanentPrice { get; set; }

#nullable enable
        public string? Description { get; set; }

        public string? InGameActivatorCommand { get; set; }

        public string? InGameDeactivatorCommand { get; set; }
        #nullable disable

        public DateTime PurchaseDate { get; set; }

        public bool IsPermanent { get; set; }

        public bool IsVerified { get; set; }

        public bool IsExpirationVerified { get; set; }

        public int ValidityPeriodInDays { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string RoleName { get; set; }

        public int PermissionLevel { get; set; }

        public bool IsBanned { get; set; }


        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }
    }
}
