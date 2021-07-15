using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Common
{
    public class IngredientInput
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class RecipeTagInput
    {
        public Guid TagId { get; set; }
    }
}
