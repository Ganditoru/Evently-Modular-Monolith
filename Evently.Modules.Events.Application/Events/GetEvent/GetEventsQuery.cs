using MediatR;

namespace Evently.Modules.Events.Application.Events.GetEvent;
public sealed record GetEventsQuery() : IRequest<IEnumerable<EventResponse>>;
