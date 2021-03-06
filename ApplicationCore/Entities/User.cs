﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("users")]
    public class User : BaseEntity
    {
        [Required]
        public string UserName { get; set; }

        public string Email { get; set; }

        [Required]
        public int Currency { get; set; } = 0;

        [Required]
        public int HyCoin { get; set; } = 0;

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string PasswordSalt { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        [Required]
        public Guid RoleId { get; set; }

        [Required]
        public string LastAuthenticationIp { get; set; }

        [Required]
        public DateTime LastAuthenticationDate { get; set; } = DateTime.Now;

        [Required]
        public bool IsBanned { get; set; } = false;

        public virtual Role Role { get; set; }

        public virtual DiscordUserId DiscordUserId { get; set; }

        public virtual ICollection<PasswordResetCode> PasswordResetCodes { get; set; }

        public virtual ICollection<BarionTransaction> BarionTransactions { get; set; }

        public virtual ICollection<BankTransfer> BankTransfers { get; set; }

        public virtual ICollection<KreditGift> SentKreditGifts { get; set; }

        public virtual ICollection<KreditGift> ReceivedKreditGifts { get; set; }

        public virtual ICollection<JatekfizetesRequest> JatekfizetesRequests { get; set; }

        public virtual ICollection<FailedBillingTransaction> FailedBillingTransactions { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
