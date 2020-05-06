using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData;
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

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceIssuer> InvoiceIssuers { get; set; }

        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        public DbSet<InvoiceRequester> InvoiceRequesters { get; set; }

        public DbSet<ActualValueOfOneKredit> ActualValueOfOneKredit { get; set; }
        #endregion

        public HyHeroesDbContext(DbContextOptions<HyHeroesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasAlternateKey(x => new { x.UserName, x.Email });

            modelBuilder.Entity<Role>()
                .HasAlternateKey(x => x.Name);

        }
    }
}
