using AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Common;
using MediatR;
using System;
using System.Collections.Generic;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Add
{
    public class AddRecipeCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Detail { get; set; }
        public RecipeImageInput RecipeImage { get; set; }
        public List<IngredientInput> IngredientInputs { get; set; }
        public List<RecipeTagInput> RecipeTags { get; set; }
    }


}
