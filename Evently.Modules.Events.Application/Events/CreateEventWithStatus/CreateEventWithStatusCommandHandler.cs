using Evently.Modules.Events.Application.Abstractions.Data;
using Evently.Modules.Events.Domain.Events;
using MediatR;

namespace Evently.Modules.Events.Application.Events.CreateEventWithStatus;
internal sealed class CreateEventWithStatusCommandHandler(IEventRepository eventRepository, IUnitOfWork unitOfWork)
    : IRequestHandler<CreateEventWithStatusCommand, Guid>
{

    public async Task<Guid> Handle(CreateEventWithStatusCommand request, CancellationToken cancellationToken)
    {
        var @event = Event.Create(
            request.Title,
            request.Description,
            request.Location,
            request.StartsAtUtc,
            request.EndsAtUtc,
            request.Status);

        eventRepository.Insert(@event);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return @event.Id;
    }
}

