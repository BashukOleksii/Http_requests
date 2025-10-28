using FluentValidation;
using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.Validators
{
    public class SubscriptioValidator : AbstractValidator<SubscriptionItem>
    {
        public SubscriptioValidator() 
        {
            RuleFor(x => x.OwnerId)
                    .NotEmpty().WithMessage("Для підписки неохідно вказати власника");

            RuleFor(x => x.Service)
                .NotEmpty().WithMessage("Поле не може бути порожнім")
                .Length(3, 30).WithMessage("Поле має бути в межах [3;30]");

            RuleFor(x => x.Status)
                .NotEmpty().WithMessage("Поле обов'язкове для заповнення")
                .IsInEnum().WithMessage("Значення має бути в вказаному переліку");
        }
    }
}
