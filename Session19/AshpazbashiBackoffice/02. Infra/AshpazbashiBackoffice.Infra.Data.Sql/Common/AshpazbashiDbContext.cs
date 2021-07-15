using AshpazbashiBackoffice.Core.Domain.Recipes;
using AshpazbashiBackoffice.Core.Domain.Tags;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshpazbashiBackoffice.Infra.Data.Sql.Common
{
    public class AshpazbashiDbContext : DbContext
    {
        public AshpazbashiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeImage> RecipeImages { get; set; }
        public DbSet<RecipeTag> RecipeTags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AshpazbashiDbContext).Assembly);
        }
    }
}
