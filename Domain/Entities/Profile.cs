using Domain.ValueObjects;

namespace Domain.Entities;

/// <summary>
/// Профиль пользователя
/// /// </summary>
public class Profile : BaseEntity<Profile>
{
    /// <summary>
    /// Конструктор для инициализации профиля пользователя
    /// </summary>
    /// <param name="externalId">Внешний уникальный идентификатор пользователя</param>
    /// <param name="favoriteDrugs">Список избранных лекарств пользователя</param>
    /// <param name="email">Электронная почта пользователя</param>
    public Profile(string externalId, List<FavoriteDrug> favoriteDrugs, Email? email)
    {
        ExternalId = externalId;
        FavoriteDrugs = favoriteDrugs;
        Email = email;
    }


    /// <summary>
    /// Внешний уникальный идентификатор пользователя
    /// </summary>
    public string ExternalId { get; private init; }
    
    /// <summary>
    /// Список избранных лекарств пользователя
    /// </summary>
    public List<FavoriteDrug> FavoriteDrugs { get; set; }
    
    /// <summary>
    /// Электронная почта пользователя
    /// </summary>
    public Email? Email { get; set; }
}