using Hangfire;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseDefaultServices(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("AllowAll");

            app.UseAuthentication();
            app.UseMvc();
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            if (env.IsDevelopment())
            {
                app.ApplicationServices.GetService(typeof(IOnlinePlayerStateGeneratorService));
            }
        }

        public static void UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "HyHeroesWebAPI V1");
                c.DocExpansion(DocExpansion.None);
                c.RoutePrefix = string.Empty;
            });
        }

        public static void UseCustomHangfire(
            this IApplicationBuilder app)
        {
            app.UseHangfireDashboard();
            app.UseHangfireServer();

            var maintainerService = (IPersistenceMaintainerService)app.ApplicationServices.GetService(typeof(IPersistenceMaintainerService));
        }

        public static void UseCustomExceptionHandling(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(a => a.Run(async context => 
            {
                await Task.Run(() =>
                {
                    var feature = context.Features.Get<IExceptionHandlerPathFeature>();
                    var exception = feature.Error;

                    var result = JsonConvert.SerializeObject(new { error = exception.Message });
                    context.Response.ContentType = "application/json";
                });
            }));
        }
    }
}
