using Domain.Validators;
using FluentValidation;
using FluentValidation.Results;

namespace Domain.Entities;

/// <summary>
/// Лекарственный препарат
/// </summary>
public class Drug : BaseEntity
{
    /// <summary>
    /// Конструктор сущности Drug
    /// </summary>
    /// <param name="name">Название препарата</param>
    /// <param name="manufacturer">Производитель</param>
    /// <param name="countryCodeId">Код страны производителя</param>
    /// <param name="country">Страна производитель</param>
    public Drug(string name, string manufacturer, string countryCodeId, Country country)
    {
        Name = name;
        Manufacturer = manufacturer;
        CountryCodeId = countryCodeId;
        Country = country;
        
        Validate();
    }

    

    /// <summary>
    /// Название препарата
    /// </summary>
    public string Name { get; private set; }
    
    /// <summary>
    /// Производитель
    /// </summary>
    public string Manufacturer { get; private set; }
    
    /// <summary>
    /// ID Страны
    /// </summary>
    public string CountryCodeId { get; set; }
    
    public  Country Country { get; set; }
    //TODO: Описсать каждый обьект 
    //TODO: Валидация для каждого обьекта
    //TODO: Плюшки за 1)обьяснить почему BaseValueObject GetHashCode
    //TODO: 2) сделать тесты для проверки валидации негативный и позитивный тест XUnit
    /// <summary>
    /// Навигационное свойство для связи Drug и DrugItem
    /// </summary>
    public ICollection<DrugItem> DrugItems { get; set; } = new List<DrugItem>();
    /// <summary>
    /// Метод для проверки корректности данных с использованием DrugValidator
    /// </summary>
    /// <exception cref="ValidationException">Выбрасывается при ошибках валидации</exception>

    public void Validate()
    {
        var validator = new DrugValidator();
        ValidationResult result = validator.Validate(this);
        
        if (!result.IsValid)
        {
            var errors = string.Join(" | ", result.Errors.Select(x => x.ErrorMessage));
            throw new ValidationException(errors);
        }
    }
}