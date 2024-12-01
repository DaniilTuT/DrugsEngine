using MediatR;

namespace Domain.Interface;

/// <summary>
/// Интерфейс для доменных событий, реализующих шаблон "уведомление"
/// </summary>
public interface IDomainEvent : INotification;