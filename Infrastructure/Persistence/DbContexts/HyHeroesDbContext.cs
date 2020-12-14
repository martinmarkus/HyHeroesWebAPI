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

        public DbSet<ServerActivation> ServerActivations { get; set; }

        public DbSet<ServerExpiration> ServerExpirations { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<PayPalIPNMessage> PayPalIPNMessages { get; set; }

        public DbSet<PayPalTransactionRequest> PayPalTransactionRequests { get; set; }

        public DbSet<EmailVerificationCode> EmailVerificationCodes { get; set; }
        #endregion

        public HyHeroesDbContext(DbContextOptions<HyHeroesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasAlternateKey(x => new { x.UserName/*, x.Email */});

            //modelBuilder.Entity<Role>()
            //    .HasAlternateKey(x => x.Name);
        }
    }
}
