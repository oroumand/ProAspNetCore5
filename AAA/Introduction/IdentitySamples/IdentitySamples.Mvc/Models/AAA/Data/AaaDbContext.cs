using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySamples.Mvc.Models.AAA.Data
{
    public class AaaDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BlackListPasswordItem> blackListPasswordItems { get; set; }
        public AaaDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
