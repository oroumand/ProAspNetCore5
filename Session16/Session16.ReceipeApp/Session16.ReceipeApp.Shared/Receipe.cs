using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Session16.ReceipeApp.Shared
{
    public class ReceipeValidator : AbstractValidator<Receipe>
    {
        public ReceipeValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("برای نام مقدار لازم است").Length(2, 50).WithMessage("طول نام  باید بین 2 تا 50 کاراکتر باشد.");
            RuleFor(c => c.Description).NotEmpty().WithMessage("برای توضیحات مقدار لازم است").Length(2, 50).WithMessage("طول توضیحات  باید بین 2 تا 50 کاراکتر باشد.");
            RuleFor(c => c.Detaile).NotEmpty().WithMessage("برای دستور پخت مقدار لازم است").Length(2, 50).WithMessage("طول دستور پخت  باید بین 2 تا 50 کاراکتر باشد.");
            RuleForEach(c => c.Ingridients).SetValidator(new IngridientValidator());
        }
    }

    public class IngridientValidator : AbstractValidator<Ingridient>
    {
        public IngridientValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("برای نام ماده تشکیل دهنده مقدار لازم است").Length(2, 50).WithMessage("طول نام ماده تشکیل دهنده باید بین 2 تا 50 کاراکتر باشد.");
            RuleFor(c => c.Value).NotEmpty().WithMessage("برای مقدار ماده تشکیل دهنده مقدار لازم است").Length(2, 50).WithMessage("طول مقدار ماده تشکیل دهنده باید بین 2 تا 50 کاراکتر باشد.");
        }
    }
    public class Receipe
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string Detaile { get; set; }
        public int PreparationTime { get; set; }
        public List<Ingridient> Ingridients { get; set; } = new List<Ingridient>();

    }
    public class Ingridient
    {

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
