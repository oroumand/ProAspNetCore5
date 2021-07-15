using FluentValidation;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Add
{
    public class AddTagValidator:AbstractValidator<AddTagCommand>
    {
        public AddTagValidator()
        {
            RuleFor(c => c.Title).NotEmpty().WithMessage("برای عنوان تگ مقدار لازم است")
               .MaximumLength(50).WithMessage("طول ورودی برای تگ حدکثر 50 کاراکتر می‌باشد");
        }
    }
}
