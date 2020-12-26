using HyHeroesWebAPI.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace HyHeroesWebAPI.Infrastructure.Persistence.DbContexts
{
    public class HyHeroesDbContext : DbContext
    {
        #region DbSets
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<PurchasedProduct> PurchasedProducts { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<BillingTransaction> BillingTransactions { get; set; }

        public DbSet<FailedBillingTransaction> FailedTransactions { get; set; }

        public DbSet<ActualValueOfOneKredit> ActualValueOfOneKredit { get; set; }

        public DbSet<EDSMSPurchase> EDSMSPurchases { get; set; }

        public DbSet<KreditPurchase> KreditPurchases { get; set; }

        public DbSet<EDSMSActivationCode> EDSMSActivationCodes { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<PayPalIPNMessage> PayPalIPNMessages { get; set; }

        public DbSet<PayPalTransactionRequest> PayPalTransactionRequests { get; set; }

        public DbSet<EmailVerificationCode> EmailVerificationCodes { get; set; }

        public DbSet<PasswordResetCode> PasswordResetCodes { get; set; }

        public DbSet<GameServer> GameServers { get; set; }

        public DbSet<PurchaseState> PurchaseStates { get; set; }

        public DbSet<MassKreditActivationCode> MassKreditActivationCodes { get; set; }

        public DbSet<MassKreditUserActivation> MassKreditUserActivations { get; set; }
        #endregion

        public HyHeroesDbContext(DbContextOptions<HyHeroesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasAlternateKey(x => new { x.UserName/*, x.Email */});

            modelBuilder.Entity<PurchasedProduct>()
                .HasMany(p => p.PurchaseStates)
                .WithOne(ps => ps.PurchasedProduct)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GameServer>()
                .HasMany(gs => gs.PurchaseStates)
                .WithOne(ps => ps.GameServer)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
