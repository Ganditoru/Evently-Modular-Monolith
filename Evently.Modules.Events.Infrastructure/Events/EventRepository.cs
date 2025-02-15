using Evently.Modules.Events.Domain.Events;
using Evently.Modules.Events.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Evently.Modules.Events.Infrastructure.Events;

internal sealed class EventRepository(EventsDbContext context) : IEventRepository
{
    public void Insert(Event @event)
    {
        context.Events.Add(@event);
    }

    public Task<Event?> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return context.Events.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
