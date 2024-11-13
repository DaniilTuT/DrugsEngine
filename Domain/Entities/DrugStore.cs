using Domain.Validators;
using Domain.ValueObjects;
using FluentValidation;
using FluentValidation.Results;

namespace Domain.Entities;

/// <summary>
/// Магазин лекарств
/// </summary>
public class DrugStore : BaseEntity
{
    /// <summary>
    /// Конструктор сущности DrugStore
    /// </summary>
    /// <param name="address">Адрес магазина</param>
    /// <param name="number">Номер магазина</param>
    /// <param name="phoneNumber">Номер телефона магазина</param>
    /// <param name="drugNetwork">Сеть аптек, к которой относится магазин</param>
    /// <exception cref="ValidationException">Выбрасывается, если валидация не пройдена</exception>
    public DrugStore(Address address, int number, string phoneNumber, string drugNetwork)
    {
        Address = address;
        Number = number;
        PhoneNumber = phoneNumber;
        DrugNetwork = drugNetwork;

        Validate();
    }

    /// <summary>
    /// Адрес магазина
    /// </summary>
    public Address Address { get; set; }
    
    /// <summary>
    /// Номер магазина
    /// </summary>
    public int Number { get; set; }
    
    /// <summary>
    /// Номер телефона магазина
    /// </summary>
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Сеть аптек, к которой относится магазин
    /// </summary>
    public string DrugNetwork { get; set; }
    
    /// <summary>
    /// Навигационное свойство для связи DrugStore и DrugItem
    /// </summary>
    public List<DrugItem> DrugItems { get; set; } = new List<DrugItem>();
    
    /// <summary>
    /// Метод для проверки корректности данных с использованием DrugStoreValidator
    /// </summary>
    /// <exception cref="ValidationException">Выбрасывается при ошибках валидации</exception>
    public void Validate()
    {
        var validator = new DrugStoreValidator();
        ValidationResult result = validator.Validate(this);
        
        if (!result.IsValid)
        {
            var errors = string.Join(" | ", result.Errors.Select(x => x.ErrorMessage));
            throw new ValidationException(errors);
        }
    }
}
