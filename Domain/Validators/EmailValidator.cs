using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Validators;

/// <summary>
/// Валидатор для объекта Email.
/// Выполняет проверку корректности формата email и длины значения.
/// </summary>
public class EmailValidator : AbstractValidator<Email>
{
    /// <summary>
    /// Конструктор валидатора для Email.
    /// Устанавливает правила проверки на соответствие формату email и допустимую длину.
    /// </summary>
    public EmailValidator()
    {
        RuleFor(e => e.Value)
            .EmailAddress().WithMessage(ValidationMessage.InvalidEmail)
            .Length(6, 255).WithMessage(ValidationMessage.WrongLength);
    }
}