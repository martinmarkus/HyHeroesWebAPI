﻿using System;
using System.Collections.Generic;
using System.Text;
using BarionClientLibrary;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Facades;
using HyHeroesWebAPI.Presentation.Facades.Interfaces;
using HyHeroesWebAPI.Presentation.Factories.PaymentServiceFactories;
using HyHeroesWebAPI.Presentation.Factories.PaymentServiceFactories.Interfaces;
using HyHeroesWebAPI.Presentation.Mapper;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
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
using SzamlazzHuService.Services;

namespace HyHeroesWebAPI.Presentation.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ITokenGeneratorService, JwtTokenGeneratorService>();
            services.AddScoped<IPasswordEncryptorService, PasswordEncryptorService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAuthorizerService, AuthorizerService>();
            services.AddScoped<IStatisticService, StatisticService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IHttpRequestService, HttpRequestService>();
            services.AddScoped<IEDSMSService, EDSMSService>();
            services.AddScoped<IPayPalService, PayPalService>();
            services.AddScoped<IBarionPaymentService, BarionPaymentService>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IEmailSenderService, EmailSenderService>();

            services.AddScoped<IRecurringTaskFacade, RecurringTaskFacade>();

            services.AddScoped<ValueConverter>();
            services.AddScoped<BillService>();
            services.AddScoped<RandomStringGenerator>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IBillingMapper, BillingMapper>();
            services.AddScoped<IUserMapper, UserMapper>();
            services.AddScoped<IProductMapper, ProductMapper>();
            services.AddScoped<IBarionPaymentMapper, BarionPaymentMapper>();
            services.AddScoped<IEDSMSMapper, EDSMSMapper>();
            services.AddScoped<INewsMapper, NewsMapper>();
            services.AddScoped<IPayPalMapper, PayPalMapper>();
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
            services.AddScoped<IEDSMSActivationCodeRepository, EDSMSActivationCodeRepository>();
            services.AddScoped<IServerActivationRepository, ServerActivationRepository>();
            services.AddScoped<IServerExpirationRepository, ServerExpirationRepository>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<IPayPalIPNMessageRepository, PayPalIPNMessageRepository>();
            services.AddScoped<IPayPalTransactionRequestRepository, PayPalTransactionRequestRepository>();
            services.AddScoped<IEmailVerificationCodeRepository, EmailVerificationCodeRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>(); 

            services.AddDbContext<HyHeroesDbContext>(options => {
                options.UseMySql(
                    configuration["ConnectionStrings:DbConnection"],
                    b =>
                        {
                            b.MigrationsAssembly("HyHeroesWebAPI.Presentation");
                            b.EnableRetryOnFailure();
                        }
                    );
                }
              );
        }

        public static void AddCustomAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsSection = configuration.GetSection("AppSettings");

            services.Configure<AppSettings>(appSettingsSection);
            services.Configure<List<EDSMSPurchaseTypeDTO>>(configuration.GetSection("EDSMSPurchaseTypes"));

            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);
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

        public static void AddBarionService(this IServiceCollection services)
        {
            var barionSettings = new BarionSettings
            {
                BaseUrl = new Uri("https://api.test.barion.com/"),
                POSKey = Guid.Parse("d1bcff3989885d3a98235c1cd768eba2"),
                Payee = "test@example.com",
            };

            services.AddSingleton(barionSettings);
            services.AddTransient<BarionClient>();
            services.AddHttpClient<BarionClient>();
        }

        public static void AddCustomSwagger(this IServiceCollection services)
        {
            //services.ConfigureSwaggerGen(options =>
            //{
            //    options.OperationFilter<AuthorizationHeaderParameterOperationFilter>();
            //});

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
