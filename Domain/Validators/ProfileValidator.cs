using FluentValidation;
using Domain.Entities;

namespace Domain.Validators
{
    /// <summary>
    /// Валидатор для сущности Profile.
    /// Проверяет, что внешнего идентификатор (ExternalId) не пустой и имеет допустимую длину.
    /// </summary>
    public sealed class ProfileValidator : AbstractValidator<Profile>
    {
        /// <summary>
        /// Конструктор валидатора для Profile.
        /// Устанавливает правила проверки для ExternalId: поле не должно быть пустым и должно быть длиной от 2 до 100 символов.
        /// </summary>
        public ProfileValidator()
        {
            // Валидация для ExternalId (внешнего идентификатора)
            RuleFor(d => d.ExternalId)
                .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
                .Length(2, 100).WithMessage(ValidationMessage.WrongLength);
        }
    }
}