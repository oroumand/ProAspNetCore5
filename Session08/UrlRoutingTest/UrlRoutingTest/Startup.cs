using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlRoutingTest.Infra;
using UrlRoutingTest.Middlewares;

namespace UrlRoutingTest
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(opts => {
                opts.ConstraintMap.Add("vn",
                typeof(Nezamvazife));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseDeveloperExceptionPage();
            app.UseRouting();

            //app.Use(async (context, next) =>
            //{
            //    var endpoint = context.GetEndpoint();
            //    if (endpoint != null)
            //        await context.Response.WriteAsync($"Endpoint Name Is: {endpoint.DisplayName}\n");
            //});


            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/cityPop/{city}", new CityPopulation().Invoke).WithMetadata(new RouteNameMetadata("cityPop")); ;

                //endpoints.MapGet("/pc/{provience}", new ProvCenter().Invoke);

                //endpoints.MapGet("/file/{fileName}.{fileExtention}", async context =>
                //{
                //    await context.Response.WriteAsync("File Name Variables\n");
                //    foreach (var item in context.Request.RouteValues.Keys)
                //    {
                //        await context.Response.WriteAsync($"{item}: {context.Request.RouteValues[item]} \n");
                //    }
                //});

                //endpoints.MapGet("/name{fname}", async context =>
                //{
                //    await context.Response.WriteAsync("Name Variables\n");
                //    foreach (var item in context.Request.RouteValues.Keys)
                //    {
                //        await context.Response.WriteAsync($"{item}: {context.Request.RouteValues[item]} \n");
                //    }
                //});

                //endpoints.MapGet("/first/{seccond=Alireza}", async context =>
                //{
                //    await context.Response.WriteAsync("Pattern Is /first/{seccond=Alireza}\n");
                //    foreach (var item in context.Request.RouteValues.Keys)
                //    {
                //        await context.Response.WriteAsync($"{item}: {context.Request.RouteValues[item]} \n");
                //    }
                //});

                //endpoints.MapGet("/first/{seccond?}", async context =>
                //{
                //    await context.Response.WriteAsync("Pattern Is /first/{seccond?}\n");
                //    foreach (var item in context.Request.RouteValues.Keys)
                //    {
                //        await context.Response.WriteAsync($"{item}: {context.Request.RouteValues[item]} \n");
                //    }
                //});

                //endpoints.MapGet("/first/{seccond}/{*catchall}", async context =>
                //{
                //    await context.Response.WriteAsync("Pattern Is /first/{seccond}/{*catchall}}\n");
                //    foreach (var item in context.Request.RouteValues.Keys)
                //    {
                //        await context.Response.WriteAsync($"{item}: {context.Request.RouteValues[item]} \n");
                //    }
                //});


                //endpoints.MapGet("/{first:int}/{seccond:bool}", async context =>
                //{
                //    await context.Response.WriteAsync("Pattern Is /{first:int}/{seccond:bool}\n");
                //    foreach (var item in context.Request.RouteValues.Keys)
                //    {
                //        await context.Response.WriteAsync($"{item}: {context.Request.RouteValues[item]} \n");
                //    }
                //});



                //endpoints.MapGet("/{vaziat:vn}", async context =>
                //{
                //    await context.Response.WriteAsync("Pattern Is /{first:int}/{seccond:bool}\n");
                //    foreach (var item in context.Request.RouteValues.Keys)
                //    {
                //        await context.Response.WriteAsync($"{item}: {context.Request.RouteValues[item]} \n");
                //    }
                //}).WithDisplayName("Nezamvazife");
                endpoints.MapGet("/{int:int}", async context =>
                {
                    await context.Response.WriteAsync("Int");
                }).Add(d => ((RouteEndpointBuilder)d).Order = 1);
                endpoints.MapGet("/{d:double}", async context =>
                {
                    await context.Response.WriteAsync("double");
                }).Add(d => ((RouteEndpointBuilder)d).Order = 2);
                endpoints.MapFallback(async context =>
                {
                    await context.Response.WriteAsync("Fallback working");
                });
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Routing Not Working");
            });
        }
    }
}
