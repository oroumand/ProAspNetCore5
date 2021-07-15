using AshpazbashiBackoffice.Core.Domain.Common;
using AshpazbashiBackoffice.Core.Domain.Tags;
using System;

namespace AshpazbashiBackoffice.Core.Domain.Recipes
{
    public class RecipeTag : Entity
    {
        public Guid RecipeId { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
