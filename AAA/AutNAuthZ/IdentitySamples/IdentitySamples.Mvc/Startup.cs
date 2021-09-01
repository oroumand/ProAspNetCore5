using IdentitySamples.Mvc.Models.AAA.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace IdentitySamples.Mvc
{

    public class UserIsInRoleRequirement:IAuthorizationRequirement
    {
        public UserIsInRoleRequirement(string role)
        {
            Role = role;
        }

        public string Role { get; }
    }

    public class UserIsInRoleRequirementHandler : AuthorizationHandler<UserIsInRoleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserIsInRoleRequirement requirement)
        {
            if(context.User.IsInRole("Admin1"))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }

    public class UserIsInRoleRequirementHandler2 : AuthorizationHandler<UserIsInRoleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserIsInRoleRequirement requirement)
        {
            if (context.User.IsInRole("Admin2"))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }

    public class UserIsInRoleRequirementHandler3 : AuthorizationHandler<UserIsInRoleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserIsInRoleRequirement requirement)
        {
            if (context.User.IsInRole("Admin"))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }

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
            services.AddSingleton<IAuthorizationHandler, UserIsInRoleRequirementHandler>();
            services.AddSingleton<IAuthorizationHandler, UserIsInRoleRequirementHandler2>();
            services.AddSingleton<IAuthorizationHandler, UserIsInRoleRequirementHandler3>();
            services.AddAuthorization(c =>
            {
                c.AddPolicy("AdminUsers", c =>
                {
                    // c.RequireRole("Admin");
                    c.Requirements.Add(new UserIsInRoleRequirement("Admin"));
                });

            });
            services.AddControllersWithViews();

            services.AddDbContext<AaaDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("AAACnn")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AaaDbContext>();

            //services.AddTransient<IPasswordValidator<ApplicationUser>, BlackListPaswordValidator>();

            //services.AddTransient<IUserValidator<ApplicationUser>, CustomUserValidator>();
            services.Configure<IdentityOptions>(c =>
            {
                c.Password.RequireDigit = false;
                c.Password.RequireLowercase = false;
                c.Password.RequireUppercase = false;
                c.Password.RequireNonAlphanumeric = false;
                c.Password.RequiredLength = 3;
               // c.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";
                c.User.RequireUniqueEmail = true;
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
