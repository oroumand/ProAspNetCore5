using AshpazbashiBackoffice.Core.Domain.Recipes;
using AshpazbashiBackoffice.Core.Domain.Tags;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AshpazbashiBackoffice.Infra.Data.Sql.Recipes
{
    public class RecipeTagConfig : IEntityTypeConfiguration<RecipeTag>
    {
        public void Configure(EntityTypeBuilder<RecipeTag> builder)
        {
            builder.HasKey(c => new { c.RecipeId, c.TagId });
            builder.HasOne<Recipe>().WithMany(c => c.RecipeTags).HasForeignKey(c => c.RecipeId);
            builder.HasOne<Tag>().WithMany().HasForeignKey(c => c.TagId);
        }
    }
}
