using Domain.Interface;
using MediatR;

namespace Domain.DomainEvents;

public class DrugItemUpdatedEvent : IDomainEvent
{
    public Guid DrugItemId { get; set; }
    internal DrugItemUpdatedEvent()
    {
        
    }
}
