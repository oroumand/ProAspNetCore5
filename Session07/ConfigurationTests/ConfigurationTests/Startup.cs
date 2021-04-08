using ConfigurationTests.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationTests
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

            //var firstName = _configuration["PersonalData:FirstName"];
            //var lastName = _configuration["PersonalData:LastName"];
            //var age = _configuration["PersonalData:Age"];
            //var ssn = _configuration["PersonalData:ssn"];
            //var alireza = _configuration["Alireza"];

            //services.Configure<PersonalDataOptions>(_configuration.GetSection("PersonalData"));

            var personalDataOptions = new PersonalDataOptions();
            _configuration.GetSection("PersonalData").Bind(personalDataOptions);
            
            services.AddSingleton(personalDataOptions);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, PersonalDataOptions personalDataOptions)
        {
            var firstName = personalDataOptions.FirstName;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if(env.IsEnvironment("InterbalTest"))
            {

            }

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
