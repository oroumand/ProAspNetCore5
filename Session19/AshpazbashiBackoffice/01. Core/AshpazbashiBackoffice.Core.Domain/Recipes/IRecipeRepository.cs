using AshpazbashiBackoffice.Core.Domain.Common;
using System;

namespace AshpazbashiBackoffice.Core.Domain.Recipes
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        Recipe GetWithChile(Guid recipeId);
    }
}
