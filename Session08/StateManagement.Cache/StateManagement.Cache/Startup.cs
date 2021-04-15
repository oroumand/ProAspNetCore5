using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StateManagement.Cache.Middlewares;
using StateManagement.Cache.Infra;
namespace StateManagement.Cache
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var useDistributedCache = true;

            if (useDistributedCache)
            {
                //services.AddDistributedMemoryCache();
                services.AddDistributedSqlServerCache(options =>
                {
                    options.ConnectionString = "Server=.; Database=CacheDb; User Id=sa; Password=1qaz!QAZ";
                    options.SchemaName = "dbo";
                    options.TableName = "tblCacheData";
                });
                //services.AddStackExchangeRedisCache(options =>
                //{

                //});
                services.AddSingleton<ICacheAdapter, DistributedCacheAdapter>();

            }
            else
            {
                services.AddMemoryCache();
                services.AddSingleton<ICacheAdapter, MomoryCacheAdapter>();
            }


            services.AddSingleton<NewsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseMiddleware<NewsCountMiddleware>();
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
