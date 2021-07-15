using AshpazbashiBackoffice.Core.ApplicationServices.Common;
using AshpazbashiBackoffice.Core.Domain.Recipes;
using MediatR;
using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Delete
{

    public class DeleteRecipeCommandHandler : RequestHandler<DeleteRecipeCommand, Guid>
    {
        private readonly IRecipeRepository recipeRepository;

        public DeleteRecipeCommandHandler(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        }
        protected override Guid Handle(DeleteRecipeCommand request)
        {
            var recipe = recipeRepository.GetWithChile(request.RecipeId);
            if (recipe == null)
                throw new EntityNotFoundException(request.RecipeId, "دستور پخت");
            recipeRepository.Remove(recipe);
            return recipe.Id;
        }
    }
}
