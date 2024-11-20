using Domain.DomainEvents;
using Domain.Validators;
using FluentValidation;
using FluentValidation.Results;

namespace Domain.Entities;

/// <summary>
/// Промежуточная сущность для связи Drug и DrugStore
/// </summary>
public class DrugItem : BaseEntity<DrugItem>
{
    /// <summary>
    /// Конструктор сущности DrugItem
    /// </summary>
    /// <param name="drugId">Внешний ключ для Drug</param>
    /// <param name="drugStoreId">Внешний ключ для DrugStore</param>
    /// <param name="count">Количество лекарства в магазине</param>
    /// <param name="cost">Стоимость лекарства в магазине</param>
    /// <param name="drug">Объект типа Drug, связанный с DrugItem</param>
    /// <param name="drugStore">Объект типа DrugStore, связанный с DrugItem</param>
    /// <exception cref="ValidationException">Выбрасывается, если валидация не пройдена</exception>
    public DrugItem(Guid drugId, Guid drugStoreId, double count, decimal cost, Drug drug, DrugStore drugStore)
    {
        DrugId = drugId;
        DrugStoreId = drugStoreId;
        Count = count;
        Cost = cost;
        Drug = drug;
        DrugStore = drugStore;
        
        ValidateEntity(new DrugItemValidator());
    }

    /// <summary>
    /// Внешний ключ для Drug
    /// </summary>
    public Guid DrugId { get; set; }

    /// <summary>
    /// Внешний ключ для DrugStore
    /// </summary>
    public Guid DrugStoreId { get; set; }

    /// <summary>
    /// Количество лекарства в магазине
    /// </summary>
    public double Count { get; set; }

    /// <summary>
    /// Стоимость лекарства в магазине 
    /// </summary>
    public decimal Cost { get; set; }

    /// <summary>
    /// Навигационное свойство для связи Drug и DrugItem
    /// </summary>
    public Drug Drug { get; set; }

    /// <summary>
    /// Навигационное свойство для связи DrugStore и DrugItem
    /// </summary>
    public DrugStore DrugStore { get; set; }
 

    public void UpdateDrugCount(double count)
    {
        Count = count;
        ValidateEntity(new DrugItemValidator());
        AddDomainEvent(new DrugItemUpdatedEvent());
    }
}
