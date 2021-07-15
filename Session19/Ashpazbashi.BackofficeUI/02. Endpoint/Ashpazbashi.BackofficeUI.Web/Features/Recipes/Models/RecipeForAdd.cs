using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashpazbashi.BackofficeUI.Web.Features.Recipes.Models
{
    public class RecipeForAdd
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Detail { get; set; }
        public RecipeImageForAdd RecipeImage { get; set; } = new RecipeImageForAdd();
        public List<Ingredient> IngredientInputs { get; set; } = new List<Ingredient>();
        public List<RecipeTag> RecipeTags { get; set; } = new List<RecipeTag>();

    }

    public class RecipeImageForAdd
    {
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] FileContent { get; set; }
    }

    public class Ingredient
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class RecipeTag
    {
        public Guid TagId { get; set; }
    }
}
