using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HyHeroesWebAPI.Presentation.Extensions;
using HyHeroesWebAPI.Presentation.Conventions;
using Microsoft.AspNetCore.HttpOverrides;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomAuthentication(Configuration);
            services.AddCustomServices(Configuration);
            services.AddBarionService();
            services.AddCustomPersistence(Configuration);
            services.AddCustomSwagger();
            
            services.AddControllers();
            services.AddCors();
            services.AddMvc(mvc =>
            {
                mvc.Conventions.Add(new ControllerNameAttributeConvention());
                mvc.EnableEndpointRouting = false;
            });

            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UserCustomExceptionHandling();
            //}

            // INFO: for linux nginx hosting
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseCustomExceptionHandling();
            app.UseDefaultServices();
            app.UseCustomSwagger();
        }
    }
}
