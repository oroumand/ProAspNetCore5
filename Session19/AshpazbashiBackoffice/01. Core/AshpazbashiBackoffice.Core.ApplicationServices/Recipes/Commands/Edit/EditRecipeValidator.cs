using AshpazbashiBackoffice.Core.Domain.Recipes;
using FluentValidation;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Edit
{
    public class EditRecipeValidator : AbstractValidator<EditRecipeCommand>
    {
        public EditRecipeValidator(IRecipeRepository recipeRepository)
        {
            RuleFor(c => c.Title).NotEmpty().WithMessage("برای عنوان تگ مقدار لازم است")
                .MaximumLength(100).WithMessage("طول ورودی برای تگ حدکثر 100 کاراکتر می‌باشد");

            RuleFor(c => c.ShortDescription).NotEmpty().WithMessage("برای عنوان تگ مقدار لازم است")
                .MaximumLength(500).WithMessage("طول ورودی برای تگ حدکثر 500 کاراکتر می‌باشد");

            RuleFor(c => c.Detail).NotEmpty().WithMessage("شرح آماده سازی غذا باید مقدار داشته باشد");

            RuleFor(c => c.RecipeId).Must(d => recipeRepository.Exists(c => c.Id == d)).WithMessage("امکان دسرتسی به درستور پخت با شناسه ارسالی وجود ندارد.");
        }
    }

}
