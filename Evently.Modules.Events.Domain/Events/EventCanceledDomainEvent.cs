using Evently.Modules.Events.Domain.Abstraction;

namespace Evently.Modules.Events.Domain.Events;
public sealed class EventCanceledDomainEvent(Guid eventId) : DomainEvent
{
    public Guid EventId { get; set; } = eventId;
}
