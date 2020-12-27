using HyHeroesWebAPI.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

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

        public DbSet<ProductCategory> ProductCategories { get; set; }
        #endregion

        public HyHeroesDbContext(DbContextOptions<HyHeroesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasAlternateKey(x => new { x.UserName });

            modelBuilder.Entity<PurchasedProduct>()
                .HasMany(p => p.PurchaseStates)
                .WithOne(ps => ps.PurchasedProduct)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GameServer>()
                .HasMany(gs => gs.PurchaseStates)
                .WithOne(ps => ps.GameServer)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(pc => pc.Products)
                .WithOne(pr => pr.ProductCategory)
                .OnDelete(DeleteBehavior.Cascade);

            // INFO: Concurrency token settings
            modelBuilder.Entity<ActualValueOfOneKredit>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BillingTransaction>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<EDSMSActivationCode>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<EDSMSPurchase>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<EmailVerificationCode>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<FailedBillingTransaction>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<GameServer>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<KreditPurchase>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<MassKreditActivationCode>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<MassKreditUserActivation>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<News>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<PasswordResetCode>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<PayPalIPNMessage>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<PayPalTransactionRequest>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<Product>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<ProductCategory>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<PurchasedProduct>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<Role>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            modelBuilder.Entity<User>()
                 .Property(entity => entity.RowVersion)
                 .IsConcurrencyToken();

            // TODO: comment on prod
            InsertMockData(modelBuilder);
        }

        private void InsertMockData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameServer>().HasData(
                new GameServer()
                {
                    IsServerRunning = true,
                    ServerName = "GTA"
                },
                new GameServer()
                {
                    IsServerRunning = true,
                    ServerName = "Survival"
                },
                new GameServer()
                {
                    IsServerRunning = true,
                    ServerName = "Skyblock"
                },
                new GameServer()
                {
                    IsServerRunning = false,
                    ServerName = "RPG"
                });

            modelBuilder.Entity<ActualValueOfOneKredit>().HasData(
                new ActualValueOfOneKredit()
                {
                    Value = 2
                });

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                    Name = "User",
                    PermissionLevel = 1
                },
                new Role()
                {
                    Id = new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                    Name = "Admin",
                    PermissionLevel = 2,
                });

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserName = "birdemic",
                    Email = "martinmarkus0@gmail.com",
                    Currency = 1000000,
                    HyCoin = 10000,
                    LastAuthenticationDate = DateTime.Now,
                    LastAuthenticationIp = "localhost",
                    RegistrationDate = DateTime.Now,
                    RoleId = new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                    PasswordHash = "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N",
                    PasswordSalt = "6yuhyavedvvwufmjpln1cjuqrm6agpvh"
                },
                new User()
                {
                    UserName = "birdemic2",
                    Email = "birdemic2@gmail.com",
                    Currency = 50000,
                    HyCoin = 4000,
                    LastAuthenticationDate = DateTime.Now,
                    LastAuthenticationIp = "localhost",
                    RegistrationDate = DateTime.Now,
                    RoleId = new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                    PasswordHash = "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N",
                    PasswordSalt = "6yuhyavedvvwufmjpln1cjuqrm6agpvh"
                },
                new User()
                {
                    UserName = "hatoska",
                    Email = "hatoska@gmail.com",
                    Currency = 40000,
                    HyCoin = 3000,
                    LastAuthenticationDate = DateTime.Now,
                    LastAuthenticationIp = "localhost",
                    RegistrationDate = DateTime.Now,
                    RoleId = new Guid("77dc6e7e-a188-4174-9752-8014cba152e8"),
                    PasswordHash = "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N",
                    PasswordSalt = "6yuhyavedvvwufmjpln1cjuqrm6agpvh"
                });

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory()
                {
                    Id = new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0"),
                    CategoryName = "Rangok",
                    Priority = 1
                },
                new ProductCategory()
                {
                    Id = new Guid("5d32fedf-28f9-4bc9-9899-4bacbbe9ea28"),
                    CategoryName = "Other",
                    Priority = 2
                });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Name = "VIP rang",
                    PricePerMonth = 1000,
                    PermanentPrice = 2000,
                    IsRank = true,
                    Description = "test description",
                    InGameDeactivatorCommand = "deactivate",
                    InGameActivatorCommand = "activate",
                    OneTimeCommand = "onetime command",
                    ImageUrl = "test url",
                    ProductCategoryId = new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0")
                },
                new Product()
                {
                     Name = "Bajnok rang",
                     PricePerMonth = 3000,
                     PermanentPrice = 6000,
                     IsRank = true,
                     Description = "test description",
                     InGameDeactivatorCommand = "deactivate",
                     InGameActivatorCommand = "activate",
                     OneTimeCommand = "onetime command",
                     ImageUrl = "test url",
                    ProductCategoryId = new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0")
                },
                new Product()
                {
                     Name = "Elit rang",
                     PricePerMonth = 5000,
                     PermanentPrice = 10000,
                     IsRank = true,
                     Description = "test description",
                     InGameDeactivatorCommand = "deactivate",
                     InGameActivatorCommand = "activate",
                     OneTimeCommand = "onetime command",
                     ImageUrl = "test url",
                    ProductCategoryId = new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0")
                },
                new Product()
                {
                    Name = "SzuperElit rang",
                    PricePerMonth = 8000,
                    PermanentPrice = 14000,
                    IsRank = true,
                    Description = "test description",
                    InGameDeactivatorCommand = "deactivate",
                    InGameActivatorCommand = "activate",
                    OneTimeCommand = "onetime command",
                    ImageUrl = "test url",
                    ProductCategoryId = new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0")
                },
                new Product()
                {
                    Name = "HiperSzuperElit rang",
                    PricePerMonth = 10000,
                    PermanentPrice = 16000,
                    IsRank = true,
                    Description = "test description",
                    InGameDeactivatorCommand = "deactivate",
                    InGameActivatorCommand = "activate",
                    OneTimeCommand = "onetime command",
                    ImageUrl = "test url",
                    ProductCategoryId = new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0")
                },
                new Product()
                {
                    Name = "ExtraSzuperElit rang",
                    PricePerMonth = 16000,
                    PermanentPrice = 20000,
                    IsRank = true,
                    Description = "test description",
                    InGameDeactivatorCommand = "deactivate",
                    InGameActivatorCommand = "activate",
                    OneTimeCommand = "onetime command",
                    ImageUrl = "test url",
                    ProductCategoryId = new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0")
                });
        }
    }
}
