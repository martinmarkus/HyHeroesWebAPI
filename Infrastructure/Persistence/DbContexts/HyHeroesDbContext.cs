using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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

        public DbSet<EDSMSPurchase> EDSMSPurchases { get; set; }

        public DbSet<KreditPurchase> KreditPurchases { get; set; }

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

        public DbSet<OnlinePlayerState> OnlinePlayerStates { get; set; }

        public DbSet<ClientIdentity> ClientIdentities { get; set; }

        public DbSet<BlacklistedIP> BlacklistedIPs { get; set; }

        public DbSet<BarionTransaction> BarionTransactions { get; set; }

        public DbSet<BarionBillingAddress> BarionBillingAddresses { get; set; }

        public DbSet<KreditGift> KreditGifts { get; set; }
        
        public DbSet<JatekfizetesRequest> JatekfizetesRequests { get; set; }

        public DbSet<BankTransfer> BankTransfers { get; set; }

        public DbSet<BankTransferBillingAddress> BankTransferBillingAddresses { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<BillingoDocument> BillingoDocuments { get; set; }

        public DbSet<BillingoPartner> BillingoPartners { get; set; }

        public DbSet<BillingoBillingAddress> BillingoBillingAddresses { get; set; }

        public DbSet<BillingoBankAccount> BillingoBankAccounts { get; set; }
        #endregion

        private readonly string _environment = string.Empty;

        public HyHeroesDbContext(
            DbContextOptions<HyHeroesDbContext> dbContextOptions,
            IHostingEnvironment env) : base(dbContextOptions)
        {
            _environment = env.EnvironmentName;
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

            modelBuilder.Entity<User>()
                .HasMany(user => user.PasswordResetCodes)
                .WithOne(code => code.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MassKreditActivationCode>()
                .HasMany(code => code.MassKreditUserActivations)
                .WithOne(act => act.MassKreditActivationCode)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasMany(prod => prod.PurchasedProducts)
                .WithOne(purchase => purchase.Product)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GameServer>()
                .HasMany(server => server.OnlinePlayerStates)
                .WithOne(state => state.GameServer)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(user => user.BarionTransactions)
                .WithOne(start => start.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BarionTransaction>()
                .HasOne(trans => trans.BarionBillingAddress)
                .WithOne(addr => addr.BarionTransaction)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(user => user.SentKreditGifts)
                .WithOne(gift => gift.SenderUser)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(user => user.JatekfizetesRequests)
                .WithOne(cooldown => cooldown.CallerUser)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(user => user.ReceivedKreditGifts)
                .WithOne(gift => gift.ReceiverUser)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<KreditPurchase>()
                .HasMany(purchase => purchase.EDSMSPurchases)
                .WithOne(edsms => edsms.KreditPurchase)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BankTransfer>()
                .HasOne(trans => trans.BankTransferBillingAddress)
                .WithOne(addr => addr.BankTransfer)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(user => user.BankTransfers)
                .WithOne(trans => trans.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(user => user.FailedBillingTransactions)
                .WithOne(failed => failed.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(user => user.Notifications)
                .WithOne(notification => notification.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BillingoPartner>()
                .HasOne(partner => partner.BillingoBillingAddress)
                .WithOne(address => address.BillingoPartner);

            modelBuilder.Entity<BankTransfer>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BankTransferBillingAddress>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BarionBillingAddress>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BillingoBankAccount>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BillingoBillingAddress>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BillingoDocument>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();
            
            modelBuilder.Entity<BillingoPartner>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BarionTransaction>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BillingTransaction>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<BlacklistedIP>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<ClientIdentity>()
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

            modelBuilder.Entity<JatekfizetesRequest>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<KreditGift>()
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

            modelBuilder.Entity<Notification>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<OnlinePlayerState>()
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

            modelBuilder.Entity<PurchaseState>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<Role>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            modelBuilder.Entity<User>()
                .Property(entity => entity.RowVersion)
                .IsConcurrencyToken();

            if (_environment.Equals("Production", StringComparison.OrdinalIgnoreCase))
            {
                InsertProductionBaseData(modelBuilder);
            }
            else if (_environment.Equals("Development", StringComparison.OrdinalIgnoreCase))
            {
                InsertDevelopmentBaseData(modelBuilder);
            }
        }

        private void InsertProductionBaseData(ModelBuilder modelBuilder)
        {
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
                   Id = new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                   UserName = "birdemic",
                   Email = "martinmarkus0@gmail.com",
                   Currency = 100000,
                   HyCoin = 0,
                   LastAuthenticationDate = DateTime.Now,
                   LastAuthenticationIp = "localhost",
                   RegistrationDate = DateTime.Now,
                   RoleId = new Guid("779126ee-2c1c-4eef-8eec-4ff6463e17aa"),
                   PasswordHash = "C4JDaequjw97dDIGQSosEUGVrJJ3L4kk",
                   PasswordSalt = "6yuhyavedvvwufmjpln1cjuqrm6agpvh"
               });
        }

        private void InsertDevelopmentBaseData(ModelBuilder modelBuilder)
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
                    Id = new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
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
                    Id = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
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
                    Id = new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
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

            modelBuilder.Entity<ClientIdentity>().HasData(
                new ClientIdentity()
                {
                    BaseValue = "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N",
                    ValidatorSalt = "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N",
                    ValidatorHash = "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL",
                    ExpirationDate = DateTime.Now.AddMinutes(1),
                    UserId = new Guid("5de99496-dbbd-4ce5-9445-6d453b46d145"),
                },
                new ClientIdentity()
                {
                    BaseValue = "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N",
                    ValidatorSalt = "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N",
                    ValidatorHash = "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL",
                    ExpirationDate = DateTime.Now.AddMinutes(1),
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                },
                new ClientIdentity()
                {
                    BaseValue = "bQY0QnNkr4ch0cAR1sBM6uZr+IFWzt4N",
                    ValidatorSalt = "IFch0cAbQ46uZ0Wr+QnNkrBMR1sYzt4N",
                    ValidatorHash = "whQv8pQfvmULOXU3szzZo3kgPcGDa5vL",
                    ExpirationDate = DateTime.Now.AddMinutes(1),
                    UserId = new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698"),
                }
            );

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
                    CategoryName = "Egyéb",
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
                    ImageUrl = "http://localhost:4200/assets/img/add-icon.png",
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
                    ImageUrl = "http://localhost:4200/assets/img/add-icon.png",
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
                    ImageUrl = "http://localhost:4200/assets/img/add-icon.png",
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
                    ImageUrl = "http://localhost:4200/assets/img/add-icon.png",
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
                    ImageUrl = "http://localhost:4200/assets/img/add-icon.png",
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
                    ImageUrl = "http://localhost:4200/assets/img/add-icon.png",
                    ProductCategoryId = new Guid("894cf24d-9bf2-4935-9b31-4d1614f1cee0")
                });


            modelBuilder.Entity<PasswordResetCode>().HasData(
                new PasswordResetCode()
                {
                    Code = Guid.NewGuid(),
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5")
                },
                new PasswordResetCode()
                {
                    Code = Guid.NewGuid(),
                    UserId = new Guid("96bb6ed1-38e2-4bd7-b6d7-989ec78f5698")
                });

            modelBuilder.Entity<News>().HasData(
                new News()
                {
                    Title = "Teszt Hír #1",
                    Preview = "Ez a hír előnézeti szövege.",
                    FormattedNews = "Ez itt a hír tartalma.",
                    PublisherUserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddSeconds(-200)
                },
                new News()
                {
                    Title = "Teszt Hír #2",
                    Preview = "Ez a hír előnézeti szövege.",
                    FormattedNews = "Ez itt a hír tartalma.",
                    PublisherUserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddSeconds(-150)
                },
                new News()
                {
                    Title = "Teszt Hír #3",
                    Preview = "Ez a hír előnézeti szövege.",
                    FormattedNews = "Ez itt a hír tartalma.",
                    PublisherUserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                     CreationDate = DateTime.Now.AddSeconds(-100)
                },
                new News()
                {
                    Title = "Teszt Hír #4",
                    Preview = "Ez a hír előnézeti szövege.",
                    FormattedNews = "Ez itt a hír tartalma.",
                    PublisherUserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddSeconds(-50)
                },
                new News()
                {
                    Title = "Teszt Hír #5",
                    Preview = "Ez a hír előnézeti szövege.",
                    FormattedNews = "Ez itt a hír tartalma.",
                    PublisherUserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now
                });

            modelBuilder.Entity<KreditPurchase>().HasData(
                new KreditPurchase()
                {
                    KreditValue = 1000,
                    CurrencyValue = 2000,
                    PaymentType = PaymentType.PayPal,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-4)
                },
                new KreditPurchase()
                {
                    KreditValue = 2500,
                    CurrencyValue = 5000,
                    PaymentType = PaymentType.PayPal,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-4)
                },
                new KreditPurchase()
                {
                    KreditValue = 500,
                    CurrencyValue = 1000,
                    PaymentType = PaymentType.PayPal,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-3)
                },
                new KreditPurchase()
                {
                    KreditValue = 1000,
                    CurrencyValue = 2000,
                    PaymentType = PaymentType.PayPal,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-3)
                },
                new KreditPurchase()
                {
                    KreditValue = 3000,
                    CurrencyValue = 6000,
                    PaymentType = PaymentType.PayPal,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-2)
                },
                new KreditPurchase()
                {
                    KreditValue = 1500,
                    CurrencyValue = 3000,
                    PaymentType = PaymentType.PayPal,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-1)
                },
                new KreditPurchase()
                {
                    KreditValue = 330,
                    CurrencyValue = 330,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-4)
                },
                new KreditPurchase()
                {
                    KreditValue = 508,
                    CurrencyValue = 500,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-4)
                },
                new KreditPurchase()
                {
                    KreditValue = 2032,
                    CurrencyValue = 2000,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-3)
                },
                new KreditPurchase()
                {
                    KreditValue = 330,
                    CurrencyValue = 330,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-3)
                },
                new KreditPurchase()
                {
                    KreditValue = 330,
                    CurrencyValue = 330,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-3)
                },
                new KreditPurchase()
                {
                    KreditValue = 508,
                    CurrencyValue = 500,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-2)
                },
                new KreditPurchase()
                {
                    KreditValue = 508,
                    CurrencyValue = 500,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-2)
                },
                new KreditPurchase()
                {
                    KreditValue = 508,
                    CurrencyValue = 500,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-1)
                },
                new KreditPurchase()
                {
                    KreditValue = 508,
                    CurrencyValue = 500,
                    PaymentType = PaymentType.EDSMS,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-1)
                },
                new KreditPurchase()
                {
                    KreditValue = 500,
                    CurrencyValue = 1000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-4)
                },
                new KreditPurchase()
                {
                    KreditValue = 500,
                    CurrencyValue = 1000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-3)
                },
                new KreditPurchase()
                {
                    KreditValue = 1000,
                    CurrencyValue = 2000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-3)
                },
                new KreditPurchase()
                {
                    KreditValue = 1500,
                    CurrencyValue = 3000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-2)
                },
                new KreditPurchase()
                {
                    KreditValue = 1500,
                    CurrencyValue = 3000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-2)
                },
                new KreditPurchase()
                {
                    KreditValue = 1500,
                    CurrencyValue = 3000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-2)
                },
                new KreditPurchase()
                {
                    KreditValue = 500,
                    CurrencyValue = 1000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-2)
                },
                new KreditPurchase()
                {
                    KreditValue = 2000,
                    CurrencyValue = 4000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-1)
                },
                new KreditPurchase()
                {
                    KreditValue = 1500,
                    CurrencyValue = 3000,
                    PaymentType = PaymentType.Barion,
                    UserId = new Guid("bf99a9b3-1d1b-4614-9ff7-90a17b1cd9f5"),
                    CreationDate = DateTime.Now.AddMonths(-1)
                }
                );
        }
    }
}
