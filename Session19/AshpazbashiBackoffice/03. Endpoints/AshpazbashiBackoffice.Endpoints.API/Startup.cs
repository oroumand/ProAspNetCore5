using AshpazbashiBackoffice.Core.Domain.Tags;
using AshpazbashiBackoffice.Infra.Data.Sql.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Add;
using FluentValidation.AspNetCore;
using AshpazbashiBackoffice.Infra.Data.Sql.Tags;
using AshpazbashiBackoffice.Endpoints.API.Middlewares.ApiExceptionHandler;
using AshpazbashiBackoffice.Core.Domain.Recipes;
using AshpazbashiBackoffice.Infra.Data.Sql.Recipes;
using AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Common;

namespace AshpazbashiBackoffice.Endpoints.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddTagCommand>()); ;
            services.AddDbContext<AshpazbashiDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("AshpazbashiCnn")));

            //Add MediatR
            services.AddMediatR(typeof(AddTagCommand).Assembly);





            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IImageStoreServicecs, PhysicalImageStoreService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AshpazbashiBackoffice.Endpoints.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AshpazbashiBackoffice.Endpoints.API v1"));
            }
            else
            {
                app.UseMiddleware<ApiExceptionMiddleware>();
            }

            //app.UseHttpsRedirection();
            app.UseCors(c =>
            {
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
                c.AllowAnyHeader();
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
