using MediatR;
using System;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Delete
{
    public class DeleteRecipeCommand : IRequest<Guid>
    {
        public Guid RecipeId { get; set; }
    }


}
