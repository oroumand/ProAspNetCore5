using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Session06.DI.ApplicaitonService;
using Session06.DI.DataAccess;
using Session06.DI.FactoryTests;
using Session06.DI.LifeTimes;
using Session06.DI.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session06.DI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPersonRepository, FakePersonRepository>();
            services.AddTransient<ITransientObject, TransientObject>();
            services.AddScoped<IScopeObject, ScopeObject>();
            services.AddSingleton<ISingletonObject, SingletonObject>();
            services.AddSingleton<CreatePersonService>();

            var useDistributedCache = true;
            services.AddTransient<DistributedCache>();
            services.AddTransient<InMemoryCache>();

            services.AddTransient(typeof(IList<>), typeof(List<>));

            services.AddTransient<ICacheAdapter>(c =>
            {                
                if (useDistributedCache)
                {
                    var service = c.GetServices<DistributedCache>().FirstOrDefault();
                    return service;
                }
                return new InMemoryCache();
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseMiddleware<CreatePersonMiddleware>();
            app.UseMiddleware<TransientTestMiddleware>();
            app.UseMiddleware<ScopeTestMiddleware>();
            app.UseMiddleware<SingletonTestMiddleware>();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
