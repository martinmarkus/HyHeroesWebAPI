﻿using System;
using System.Collections.Generic;
using System.Text;
using BarionClientLibrary;
using Hangfire;
using Hangfire.MemoryStorage;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Facades;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Facades.Interfaces;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Mappers;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Mappers.Interfaces;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Infrastructure.Utils;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Facades;
using HyHeroesWebAPI.Presentation.Facades.Interfaces;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mappers;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Discord.WebSocket;
using Discord.Commands;
using HyHeroesWebAPI.Presentation.DTOs.EDSMSDTOs;

namespace HyHeroesWebAPI.Presentation.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services, IWebHostEnvironment env)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ITokenGeneratorService, JwtTokenGeneratorService>();
            services.AddScoped<IStringEncryptorService, StringEncryptorService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAuthorizerService, AuthorizerService>();
            services.AddScoped<IStatisticService, StatisticService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IHttpRequestService, HttpRequestService>();
            services.AddScoped<IEDSMSService, EDSMSService>();
            services.AddScoped<IPayPalService, PayPalService>();
            services.AddScoped<IPayPalTokenService, PayPalTokenService>();
            services.AddScoped<IBarionPaymentService, BarionPaymentService>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IEmailSenderService, EmailSenderService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IMassKreditActivationService, MassKreditActivationService>();
            services.AddScoped<IIPValidatorService, IPValidatorService>();
            services.AddScoped<IHttpCallCounterService, HttpCallCounterService>();
            services.AddScoped<IBankTransferService, BankTransferService>();
            services.AddScoped<IZipReaderService, ZipReaderService>();
            services.AddScoped<IExternalAuthenticationService, ExternalAuthenticationService>();
            services.AddScoped<ISzamlazzHuBillService, SzamlazzHuBillService>();
            services.AddScoped<ISzamlazzHuRequestService, SzamlazzHuRequestService>();
            services.AddScoped<IBillingoService, BillingoService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IKreditUploadService, KreditUploadService>();
            
            services.AddScoped<IXmlSerializerFacade, XmlSerializerFacade>();
            services.AddScoped<IRecurringTaskFacade, RecurringTaskFacade>();
            services.AddScoped<ValueConverter>();
            services.AddScoped<FormatterUtil>();
            services.AddScoped(typeof(RandomStringGenerator<>));

            services.AddScoped<IBillingMapper, BillingMapper>();
            services.AddScoped<IUserMapper, UserMapper>();
            services.AddScoped<IProductMapper, ProductMapper>();
            services.AddScoped<IBarionPaymentMapper, BarionPaymentMapper>();
            services.AddScoped<IEDSMSMapper, EDSMSMapper>();
            services.AddScoped<INewsMapper, NewsMapper>();
            services.AddScoped<IPasswordResetCodeMapper, PasswordResetCodeMapper>();
            services.AddScoped<IMassKreditCodeMapper, MassKreditCodeMapper>();
            services.AddScoped<IGameServerMapper, GameServerMapper>();
            services.AddScoped<IBannedIpMapper, BannedIpMapper>();
            services.AddScoped<IOnlinePlayerCountMapper, OnlinePlayerCountMapper>();
            services.AddScoped<IBankTransferMapper, BankTransferMapper>();
            services.AddScoped<IBillMapper, BillMapper>();
            services.AddScoped<IBillingoMapper, BillingoMapper>();
            services.AddScoped<INotificationMapper, NotificationMapper>();
            services.AddScoped<IKreditGiftingMapper, KreditGiftingMapper>();
            services.AddScoped<IHomeMapper, HomeMapper>();
            services.AddScoped<IPayPalMapper, PayPalMapper>();

            services.AddScoped<ExceptionHandler>();
            services.AddScoped<CheckIPBlacklist>();
            services.AddScoped<GameServerIntegration>();
            services.AddScoped<SessionRefresh>();
            services.AddScoped<Logger>();

            // INFO: Singleton configurations
            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger<object>>();
            services.AddSingleton(typeof(ILogger<object>), logger);

            services.AddSingleton<IPersistenceMaintainerService, PersistenceMaintainerService>();
            
            services.AddSingleton<IDiscordService, DiscordService>();
            services.AddSingleton<DiscordSocketClient>();
            services.AddSingleton<CommandService>();

            //if (env.IsDevelopment())
            //{
                services.AddSingleton<IOnlinePlayerStateGeneratorService, OnlinePlayerStateGeneratorService>();
            //}
        }

        public static void AddCustomBarionService(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettings = configuration
                .GetSection("AppSettings")
                .Get<AppSettings>();

            var barionSettings = new BarionSettings()
            {
                BaseUrl = new Uri(appSettings.CustomBarionSettings.BaseUrl),
                POSKey = Guid.Parse(appSettings.CustomBarionSettings.POSKey)
            };

            services.AddSingleton(barionSettings);
            services.AddTransient<BarionClient>();
            services.AddHttpClient<BarionClient>();
        }

        public static void AddCustomHangfire(this IServiceCollection services)
        {
            services.AddHangfire(config => config
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseDefaultTypeSerializer()
                .UseMemoryStorage());

            services.AddHangfireServer();
        }

        public static void AddCustomPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IPurchasedProductRepository, PurchasedProductRepository>();
            services.AddScoped<IBillingTransactionRepository, BillingTransactionRepository>();
            services.AddScoped<IFailedTransactionRepository, FailedTransactionRepository>();
            services.AddScoped<IEDSMSPurchaseRepository, EDSMSPurchaseRepository>();
            services.AddScoped<IKreditPurchaseRepository, KreditPurchaseRepository>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<IPayPalIPNMessageRepository, PayPalIPNMessageRepository>();
            services.AddScoped<IPayPalOrderRepository, PayPalOrderRepository>();
            services.AddScoped<IEmailVerificationCodeRepository, EmailVerificationCodeRepository>();
            services.AddScoped<IPasswordResetCodeRepository, PasswordResetCodeRepository>();
            services.AddScoped<IPurchaseStateRepository, PurchaseStateRepository>();
            services.AddScoped<IGameServerRepository, GameServerRepository>();
            services.AddScoped<IMassKreditActivationCodeRepository, MassKreditActivationCodeRepository>();
            services.AddScoped<IMassKreditUserActivationRepository, MassKreditUserActivationRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IOnlinePlayerStateRepository, OnlinePlayerStateRepository>();
            services.AddScoped<ICustomAntiforgeryService, CustomAntiforgeryService>();
            services.AddScoped<IClientIdentityRepository, ClientIdentityRepository>();
            services.AddScoped<IBlacklistedIPRepository, BlacklistedIPRepository>();
            services.AddScoped<IBarionTransactionRepository, BarionTransactionRepository>();
            services.AddScoped<IBarionBillingAddressRepository, BarionBillingAddressRepository>();
            services.AddScoped<IKreditGiftRepository, KreditGiftRepository>();
            services.AddScoped<IJatekfizetesRequestRepository, JatekfizetesRequestRepository>();
            services.AddScoped<IBankTransferBillingAddressRepository, BankTransferBillingAddressRepository>();
            services.AddScoped<IBankTransferRepository, BankTransferRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IBillingoBillingAddressRepository, BillingoBillingAddressRepository>();
            services.AddScoped<IBillingoDocumentRepository, BillingoDocumentRepository>();
            services.AddScoped<IBillingoPartnerRepository, BillingoPartnerRepository>();
            services.AddScoped<IBillingoBankAccountRepository, BillingoBankAccountRepository>();
            services.AddScoped<IDiscordUserIdRepository, DiscordUserIdRepository>();
            services.AddScoped<IPayPalBillingAddressRepository, PayPalBillingAddressRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>(); 

            services.AddDbContext<HyHeroesDbContext>(options => {
                options.UseMySql(
                    configuration["ConnectionStrings:DbConnection"],
                    optionsBuilder => optionsBuilder.MigrationsAssembly("HyHeroesWebAPI.Infrastructure"));
                });
        }

        public static void AddCustomAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsSection = configuration.GetSection("AppSettings");

            services.Configure<AppSettings>(appSettingsSection);
            services.Configure<List<EDSMSPurchaseTypeDTO>>(configuration.GetSection("EDSMSPurchaseTypes"));

            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.AuthenticationSecretKey);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        public static void AddCustomSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                { 
                    Title = "Mineopia Web API Interface", 
                    Version = "v1",
                    Description = string.Empty
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });
        }
    }
}
