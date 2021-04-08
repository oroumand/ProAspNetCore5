using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationTests
{

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).
            ConfigureAppConfiguration((hostingContext, configurationBuilder) =>
            {
                //var builder = configurationBuilder;
                configurationBuilder.Sources.Clear();
                configurationBuilder.AddJsonFile("appsettings.json",true,true);
                configurationBuilder.AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json");
                configurationBuilder.AddEnvironmentVariables();
                configurationBuilder.AddJsonFile("testappsettings.json");
                if(hostingContext.HostingEnvironment.IsDevelopment())
                    configurationBuilder.AddUserSecrets<Startup>();

            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });



        public static IHostBuilder CreateDefaultBuilder(string[] args)
        {
            var builder = new HostBuilder()
              .UseContentRoot(Directory.GetCurrentDirectory())
              .ConfigureHostConfiguration(config =>
              {
        // Configuration provider setup
              })
              .ConfigureAppConfiguration((hostingContext, config) =>
              {
        // Configuration provider setup
             })
              .ConfigureLogging((hostingContext, logging) =>
              {
                  logging.AddConfiguration(
                    hostingContext.Configuration.GetSection("Logging"));
                  logging.AddConsole();
                  logging.AddDebug();
              })
              .UseDefaultServiceProvider((context, options) =>
              {
                  var isDevelopment = context.HostingEnvironment
                                             .IsDevelopment();
                  options.ValidateScopes = isDevelopment;
                  options.ValidateOnBuild = isDevelopment;
              });

            return builder;
        }
    }
}
