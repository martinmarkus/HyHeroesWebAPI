using System;
using System.Text;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
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
            services.AddScoped<IEconomicService, EconomicService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ValueConverter>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IUserMapper, UserMapper>();
            services.AddScoped<IProductMapper, ProductMapper>();
        }

        public static void AddCustomPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IPurchasedProductRepository, PurchasedProductRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceIssuerRepository, InvoiceIssuerRepository>();
            services.AddScoped<IInvoiceRequesterRepository, InvoiceRequesterRepository>();
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<HyHeroesDbContext>(options => {
                options.UseMySql(configuration["ConnectionStrings:DbConnection"],
                    b => b.MigrationsAssembly("HyHeroesWebAPI.Presentation"));
                }
              );
        }

        public static void AddCustomAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsSection = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

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
                    Title = "HyHeroesWebAPI Swagger UI", 
                    Version = "v1",
                    Description = "https://hyheroes.hu/"
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
