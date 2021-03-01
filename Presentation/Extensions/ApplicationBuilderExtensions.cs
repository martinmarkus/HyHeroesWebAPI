﻿using Hangfire;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
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
using HyHeroesWebAPI.Presentation.Utils;

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

            //if (env.IsDevelopment())
            //{
                app.ApplicationServices.GetService(typeof(IOnlinePlayerStateGeneratorService));
                app.ApplicationServices.GetService(typeof(IPersistenceMaintainerService));
                //app.ApplicationServices.GetService(typeof(DiscordCommands));

                var discordService = (IDiscordService)app.ApplicationServices.GetService(typeof(IDiscordService));
                Task.Run(async () =>
                {
                    await discordService.RunBotAsync();
                }).ConfigureAwait(false);
            //}
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
