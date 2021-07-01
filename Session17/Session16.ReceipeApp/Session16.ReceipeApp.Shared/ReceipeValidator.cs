using FluentValidation;

namespace Session16.ReceipeApp.Shared
{
    public class ReceipeValidator : AbstractValidator<Receipe>
    {
        public ReceipeValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("برای نام مقدار لازم است").Length(2, 50).WithMessage("طول نام  باید بین 2 تا 50 کاراکتر باشد.");
            RuleFor(c => c.Description).NotEmpty().WithMessage("برای توضیحات مقدار لازم است").Length(2, 50).WithMessage("طول توضیحات  باید بین 2 تا 50 کاراکتر باشد.");
            RuleFor(c => c.Detaile).NotEmpty().WithMessage("برای دستور پخت مقدار لازم است").Length(2, 50).WithMessage("طول دستور پخت  باید بین 2 تا 50 کاراکتر باشد.");
            //RuleFor(c => c.PreparationTime).GreaterThan(5).WithMessage("حداقل زمان طبخ غذا پنج دقیقه می‌باشد");
            RuleForEach(c => c.Ingridients).SetValidator(new IngridientValidator());
        }
    }
}
