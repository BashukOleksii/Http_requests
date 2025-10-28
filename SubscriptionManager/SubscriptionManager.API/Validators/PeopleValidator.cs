using FluentValidation;
using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.Validators
{
    public class PeopleValidator: AbstractValidator<PeopleItem>
    {
        public PeopleValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Поле не може бути порожнім")
                .Matches("^[A-Z][a-z]{5,10}[0-9]{0,5}$").WithMessage("Поле має відповідати стандарту (Перша велика англійська, " +
                "далів від 5 до 10 малих англійських літер та за бажаням до 5 цифр, але не обов'язково)");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Поле не може бути порожнім")
                .Matches(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$").WithMessage("Електронна адрсе має відповідати стандарту");
        }
    }
}
