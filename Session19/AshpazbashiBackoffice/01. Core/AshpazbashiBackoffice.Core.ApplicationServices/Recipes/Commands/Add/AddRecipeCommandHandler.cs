using AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Common;
using AshpazbashiBackoffice.Core.Domain.Recipes;
using MediatR;
using System;
using System.Linq;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Add
{

    public class AddRecipeCommandHandler : RequestHandler<AddRecipeCommand, Guid>
    {
        private readonly IRecipeRepository recipeRepository;
        private readonly IImageStoreServicecs imageStoreServicecs;

        public AddRecipeCommandHandler(IRecipeRepository recipeRepository, IImageStoreServicecs imageStoreServicecs)
        {
            this.recipeRepository = recipeRepository;
            this.imageStoreServicecs = imageStoreServicecs;
        }

        protected override Guid Handle(AddRecipeCommand request)
        {
            var file = imageStoreServicecs.Save(request.RecipeImage);
            var recipe = new Recipe
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Detail = request.Detail,
                ShortDescription = request.ShortDescription,
                Ingredients = request.IngredientInputs.Select(c => new Ingredient
                {
                    Title = c.Title,
                    Value = c.Value
                }).ToList(),
                ReceipImage = file
            };

            recipeRepository.Insert(recipe);
            return recipe.Id;
        }
    }


}
