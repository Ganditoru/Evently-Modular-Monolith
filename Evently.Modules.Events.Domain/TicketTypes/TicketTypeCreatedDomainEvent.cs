using Evently.Modules.Events.Domain.Abstraction;

namespace Evently.Modules.Events.Domain.TicketTypes;
public sealed class TicketTypeCreatedDomainEvent(Guid ticketTypeId) : DomainEvent
{
    public Guid TicketTypeId { get; init; } = ticketTypeId;
}
