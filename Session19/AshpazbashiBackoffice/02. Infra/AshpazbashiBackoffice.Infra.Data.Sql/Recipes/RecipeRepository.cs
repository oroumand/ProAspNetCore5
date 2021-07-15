using AshpazbashiBackoffice.Core.Domain.Recipes;
using AshpazbashiBackoffice.Infra.Data.Sql.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AshpazbashiBackoffice.Infra.Data.Sql.Recipes
{
    public class RecipeRepository : EfRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(AshpazbashiDbContext ashpazbashiDbContext) : base(ashpazbashiDbContext)
        {
        }

        public Recipe GetWithChile(Guid recipeId)
        {
            return dbContext.Recipes.Include(c => c.RecipeTags).Include(c => c.ReceipImage).FirstOrDefault(c => c.Id == recipeId);
        }
    }
}
