using FluentValidation;

namespace Core;

public class EmailValidator : AbstractValidator<string>
{
  public EmailValidator()
  {
    RuleFor(email => email)
    .NotEmpty().WithMessage("O Email não pode ser vazio")
    .EmailAddress().WithMessage("O Email não é válido")
    .MaximumLength(100).WithMessage("O Email não pode ter mais que 100 caracteres");
  }
}