using FluentValidation;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Delete
{
    public class DeleteTagValidator : AbstractValidator<DeleteTagCommand>
    {
        public DeleteTagValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("برای شناسه تگ مقدار لازم است");
        }
    }
}
