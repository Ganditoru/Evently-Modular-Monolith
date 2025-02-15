namespace Evently.Modules.Events.Domain.Abstraction;

public abstract class DomainEvent : IDomainEvent
{
    protected DomainEvent()
    {
        Id = Guid.NewGuid();
        OccuredOnUtc = DateTime.UtcNow;
    }

    public Guid Id { get; init; }

    public DateTime OccuredOnUtc { get; init; }
}
