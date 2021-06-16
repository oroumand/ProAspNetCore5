using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Session15.ModelBindingAndValidation.Infrastructures;
using Session15.ModelBindingAndValidation.Models;

namespace Session15.ModelBindingAndValidation
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
            services.AddControllersWithViews(c=>
            {
                c.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(c => "In Meghdar Nemitune Null Bashe");
                //c.ModelBinderProviders.Insert(0, new CustomeBinderProvider());
            });
            services.AddDbContext<ProductContext>(c => c.UseSqlServer(_configuration.GetConnectionString("cnn")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
