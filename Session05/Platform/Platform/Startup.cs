using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Platform.Middlewares;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Platform
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
                app.UseMiddleware<ScMiddleware>();

            app.Map("/admin", c =>
            {
                c.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("Admin \n");
                });

                c.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("Admin 2 \n");
                });
            });
            app.MapWhen(context => true, app2 =>
            {


            });

            app.UseWhen(context => true,app2=>{ 
            
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("User \n");
            });
            //app.UseDeveloperExceptionPage();

            //app.Use(async (httpcontext, next) =>
            //{
            //    if(httpcontext.Request.Query.ContainsKey("a"))
            //    {
            //        await httpcontext.Response.WriteAsync("There is a key in query string\n");
            //    }
            //    await next();

            //});

            //app.Use(async (context, next) =>
            //{
            //    try
            //    {
            //        await next();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("".PadRight(100, '-'));

            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine("".PadRight(100, '-'));

            //        await context.Response.WriteAsync("khataii dar system etefagh oftad");
            //    }
            //});
            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.Query.ContainsKey("ex"))
            //        throw new Exception("Bichare shodim");

            //    await next();
            //});
            //app.Use(async (context, next) =>
            //{
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();
            //    await next();

            //    stopwatch.Stop();

            //    Console.WriteLine("".PadRight(100, '-'));

            //    Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds}");
            //    Console.WriteLine("".PadRight(100, '-'));
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("First Midd Befor \n");
            //    await next();
            //    await context.Response.WriteAsync("First Midd After \n");

            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Seccond Midd \n");
            //    await next();
            //});
            app.UseRouting();
            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.Query.ContainsKey("b"))
            //        System.Threading.Thread.Sleep(2000);
            //    await next();
            //});
            //app.UseMiddleware<LoggerMiddleware>();
            //app.UseMiddleware<TerminatorMiddleware>();

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("This is Terminator");
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!\n");
                });
            });
        }
    }
}
