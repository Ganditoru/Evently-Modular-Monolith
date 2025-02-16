using Evently.Modules.Events.Domain.Events;
using MediatR;

namespace Evently.Modules.Events.Application.Events.CreateEventWithStatus;
public sealed record CreateEventWithStatusCommand(
    string Title,
    string Description,
    string Location,
    DateTime StartsAtUtc,
    DateTime? EndsAtUtc,
    EventStatus Status) : IRequest<Guid>;
