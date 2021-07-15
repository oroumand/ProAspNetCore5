using AshpazbashiBackoffice.Core.ApplicationServices.Common;
using AshpazbashiBackoffice.Core.Domain.Recipes;
using MediatR;
using System;
using System.Linq;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Edit
{

    public class EditRecipeCommandHandler : RequestHandler<EditRecipeCommand, Guid>
    {
        private readonly IRecipeRepository recipeRepository;

        public EditRecipeCommandHandler(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        }
        protected override Guid Handle(EditRecipeCommand request)
        {
            var recipe = recipeRepository.GetWithChile(request.RecipeId);
            if (recipe == null)
                throw new EntityNotFoundException(request.RecipeId, "دستور پخت");

            recipe.Title = request.Title;
            recipe.ShortDescription = request.ShortDescription;
            recipe.Detail = request.Detail;

            recipe.RecipeTags.Clear();

            recipe.RecipeTags.AddRange(request.RecipeTags.Select(c => new RecipeTag
            {
                TagId = c.TagId
            }).ToList());

            recipe.Ingredients.Clear();

            recipe.Ingredients.AddRange(request.IngredientInputs.Select(c => new Ingredient
            {
                Title = c.Title,
                Value = c.Value
            }));

            recipeRepository.SaveChanges();
            return recipe.Id;
        }
    }
}
