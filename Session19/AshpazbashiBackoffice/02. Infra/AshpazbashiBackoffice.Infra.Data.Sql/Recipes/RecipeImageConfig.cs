using AshpazbashiBackoffice.Core.Domain.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AshpazbashiBackoffice.Infra.Data.Sql.Recipes
{
    public class RecipeImageConfig : IEntityTypeConfiguration<RecipeImage>
    {
        public void Configure(EntityTypeBuilder<RecipeImage> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.PhysicalPath).HasMaxLength(500).IsRequired();
            builder.Property(c => c.FileType).HasMaxLength(10).IsRequired();
        }
    }
}
