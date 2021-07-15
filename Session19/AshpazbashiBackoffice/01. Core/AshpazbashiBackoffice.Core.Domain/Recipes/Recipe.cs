using AshpazbashiBackoffice.Core.Domain.Common;
using System.Collections.Generic;

namespace AshpazbashiBackoffice.Core.Domain.Recipes
{
    public class Recipe : Entity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Detail { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public RecipeImage ReceipImage { get; set; }
        public List<RecipeTag> RecipeTags { get; set; }
    }
}
