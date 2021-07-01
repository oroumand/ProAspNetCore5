using FluentValidation;

namespace Session16.ReceipeApp.Shared
{
    public class IngridientValidator : AbstractValidator<Ingridient>
    {
        public IngridientValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("برای نام ماده تشکیل دهنده مقدار لازم است").Length(2, 50).WithMessage("طول نام ماده تشکیل دهنده باید بین 2 تا 50 کاراکتر باشد.");
            RuleFor(c => c.Value).NotEmpty().WithMessage("برای مقدار ماده تشکیل دهنده مقدار لازم است").Length(2, 50).WithMessage("طول مقدار ماده تشکیل دهنده باید بین 2 تا 50 کاراکتر باشد.");
        }
    }
}
