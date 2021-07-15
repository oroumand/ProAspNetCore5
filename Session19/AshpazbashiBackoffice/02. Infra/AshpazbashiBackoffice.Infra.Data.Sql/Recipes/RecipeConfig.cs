using AshpazbashiBackoffice.Core.Domain.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AshpazbashiBackoffice.Infra.Data.Sql.Recipes
{
    public class RecipeConfig : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(100).IsRequired();
            builder.Property(c => c.ShortDescription).HasMaxLength(500).IsRequired();
            builder.Property(c => c.Detail).IsRequired();
            builder.OwnsMany(c => c.Ingredients);
        }
    }
}
