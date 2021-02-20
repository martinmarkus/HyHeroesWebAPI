using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HyHeroesWebAPI.Presentation.Extensions;
using HyHeroesWebAPI.Presentation.Conventions;
using Microsoft.AspNetCore.HttpOverrides;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace HyHeroesWebAPI.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomAuthentication(Configuration);
            services.AddCustomServices();
            services.AddCustomBarionService(Configuration);
            services.AddCustomPersistence(Configuration);
            services.AddCustomSwagger();
            services.AddCustomHangfire();
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowAnyOrigin()
                           .WithExposedHeaders(
                                "htozygkkkc",
                                "xo42atufxn",
                                "LZM33EUZZBHMTHEXGOYH",
                                "BRABLYKGJHXK8HK470EK");
                });
            });

            services.AddMvc(options =>
            {
                options.Conventions.Add(new ControllerNameAttributeConvention());
                options.EnableEndpointRouting = false;
            });

            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }

        public void Configure(
            IApplicationBuilder app,
            IPersistenceMaintainerService persistenceMaintainerService)
        {
            // INFO: for linux nginx hosting
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseCustomExceptionHandling();
            app.UseDefaultServices();
            app.UseCustomSwagger();
            app.UseCustomHangfire(persistenceMaintainerService);
        }
    }
}
