namespace services
{
    using domain.Entidades;
    using FluentValidation;

    public class DivisorValidator : AbstractValidator<Divisor>
    {
        public DivisorValidator()
        {
            RuleFor(x => x.Numero)
                .NotEmpty()
                .WithMessage("Numero não pode ser nulo ou vazio.");                           
            RuleFor(x => x.Primo)
                .Must(x => x == false || x == true)
                .WithMessage("Primo deve ser true/false.");
        }
    }
}
