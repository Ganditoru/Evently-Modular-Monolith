using Evently.Modules.Events.Application.Events.CreateEventWithStatus;
using Evently.Modules.Events.Domain.Events;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Events;
internal static class CreateEventWithStatus
{
    public static void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("events-with-status", async (CreateEventWithStatusRequest request, ISender sender) =>
        {
            var comand = new CreateEventWithStatusCommand(
                request.Title,
                request.Description,
                request.Location,
                request.StartsAtUtc,
                request.EndsAtUtc,
                request.Status
                );

            Guid eventId = await sender.Send(comand);

            return Results.Ok(eventId);
        })
        .WithTags(Tags.Events);
    }

    internal sealed class CreateEventWithStatusRequest
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime StartsAtUtc { get; set; }

        public DateTime? EndsAtUtc { get; set; }

        public EventStatus Status {  get; set; }
    }
}
