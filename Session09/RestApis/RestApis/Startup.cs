using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RestApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestApis
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson().AddXmlSerializerFormatters();

            services.Configure<MvcOptions>(opts => {
                opts.RespectBrowserAcceptHeader = true;
                opts.ReturnHttpNotAcceptable = true;
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RestApis.Default", Version = "v1" });
            });

            services.Configure<MvcNewtonsoftJsonOptions>(opts =>
            {
                opts.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });



            //services.Configure<JsonOptions>(opts => {
            //    opts.JsonSerializerOptions.IgnoreNullValues = true;
            //    opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            //});

            services.AddDbContext<ProductApiDbContext>(c => c.UseSqlServer(_configuration.GetConnectionString("ProductCnn")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestApis.Default v1"));

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //string productUrl = "/api/products";
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapControllers();
                //endpoints.MapGet(productUrl, async context => {
                //    var dbContext = context.RequestServices.GetService<ProductApiDbContext>();
                //    var products = await dbContext.Products.ToListAsync();
                //    var jsonResult = JsonSerializer.Serialize(products);
                //    context.Response.ContentType = "application/json";
                //    await context.Response.WriteAsync(jsonResult);
                //});

                //endpoints.MapGet($"{productUrl}/{{id}}", async context => {
                //    var id = int.Parse(context.Request.RouteValues["id"] as string);
                //    var dbContext = context.RequestServices.GetService<ProductApiDbContext>();
                //    var product = dbContext.Products.FirstOrDefault(c => c.Id == id);
                //    if(product != null)
                //    {
                //        var jsonResult = JsonSerializer.Serialize(product);
                //        context.Response.ContentType = "application/json";
                //        await context.Response.WriteAsync(jsonResult);
                //    }
                //    else
                //    {
                //        context.Response.StatusCode = 404;
                //        await context.Response.WriteAsync("محصولی با شناسه  {id} یافت نشد.");
                //    }
                //});

                //endpoints.MapPost($"{productUrl}", async context => {
                //    var product =await JsonSerializer.DeserializeAsync<Product>(context.Request.Body);
                //    var dbContext = context.RequestServices.GetService<ProductApiDbContext>();
                //    dbContext.Add(product);
                //    await dbContext.SaveChangesAsync();
                //    await context.Response.WriteAsync("ثبت محصول با موفقیت انجام شد");

                //});
            });
        }
    }
}
