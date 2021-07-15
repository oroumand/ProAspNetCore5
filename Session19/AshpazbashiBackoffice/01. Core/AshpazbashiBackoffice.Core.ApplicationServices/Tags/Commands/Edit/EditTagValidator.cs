using FluentValidation;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Edit
{
    public class EditTagValidator : AbstractValidator<EditTagCommand>
    {
        public EditTagValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("برای شناسه تگ مقدار لازم است");
            RuleFor(c => c.Title).NotEmpty().WithMessage("برای عنوان تگ مقدار لازم است")
                .MaximumLength(50).WithMessage("طول ورودی برای تگ حدکثر 50 کاراکتر می‌باشد");
        }
    }
}
