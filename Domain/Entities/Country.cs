using System;
using FluentValidation.Results;
using Domain.Validators;
using FluentValidation;

namespace Domain.Entities;

/// <summary>
/// Страна
/// </summary>
public class Country : BaseEntity<Country>
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
        ValidateEntity(new CountryValidator());
    }

    /// <summary>
    /// Название страны
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Код Страны
    /// </summary>
    public string Code { get; set; }
    
}