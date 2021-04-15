using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;

namespace StateManagement.Cache.Session
{
    public static class SessionExtentions
    {
        public static void Set<TInput>(this ISession session, string key, TInput input)
        {
            var serializedObject = JsonConvert.SerializeObject(input);
            session.SetString(key, serializedObject);
        }

        public static TOutput Get<TOutput>(this ISession session, string key)
        {
            var result = session.GetString(key);
            var output = default(TOutput);
            if (string.IsNullOrEmpty(result))
            {
                output = JsonConvert.DeserializeObject<TOutput>(result);
            }
            return output;
        }
    }
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDistributedMemoryCache();
            services.AddDistributedSqlServerCache(options =>
            {
                options.ConnectionString = "Server=.; Database=CacheDb; User Id=sa; Password=1qaz!QAZ";
                options.SchemaName = "dbo";
                options.TableName = "tblCacheData";
            });
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.IsEssential = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();

            app.UseRouting();

            app.Use(async (context, next) =>
            {
                context.Session.SetString("MySessionKey", "Hello Session");
                var SessionValue = context.Session.GetString("MySessionKey");

                await context.Response.WriteAsync($"Session id is {context.Session.Id}\n");
                await next();
            });

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
