using System;
using FluentValidation.Results;
using Domain.Validators;
using FluentValidation;

namespace Domain.Entities;

/// <summary>
/// Страна
/// </summary>
public class Country : BaseEntity
{
    /// <summary>
    /// Конструктор сущности Country
    /// </summary>
    /// <param name="name">Название страны</param>
    /// <param name="code">Код страны по формату ISO3166-1 alpha-2</param>
    /// <exception cref="ValidationException">Выбрасывается, если валидация не пройдена</exception>
    public Country(string name, string code)
    {
        Name = name;
        Code = code;

        // Валидация при создании объекта
        Validate();
    }

    /// <summary>
    /// Название страны
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Код Страны
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Метод для проверки корректности данных с использованием CountryValidator
    /// </summary>
    /// <exception cref="ValidationException">Выбрасывается при ошибках валидации</exception>
    public void Validate()
    {
        var validator = new CountryValidator();
        ValidationResult result = validator.Validate(this);

        if (!result.IsValid)
        {
            var errors = string.Join(" | ", result.Errors.Select(x => x.ErrorMessage));
            throw new ValidationException(errors);
        }
    }
}