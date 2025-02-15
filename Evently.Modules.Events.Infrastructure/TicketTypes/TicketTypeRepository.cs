using Evently.Modules.Events.Domain.TicketTypes;
using Evently.Modules.Events.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Evently.Modules.Events.Infrastructure.TicketTypes;
internal sealed class TicketTypeRepository(EventsDbContext context) : ITicketTypeRepository
{
    public void Insert(TicketType ticketType)
    {
        context.TicketTypes.Add(ticketType);
    }

    public Task<bool> ExistsAsync(Guid eventId, CancellationToken cancellationToken = default)
    {
        return context.TicketTypes.AnyAsync(x => x.Id == eventId, cancellationToken);
    }

    public Task<TicketType?> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return context.TicketTypes.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
