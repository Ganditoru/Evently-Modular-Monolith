using Evently.Modules.Events.Application.Events.GetEvent;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;


namespace Evently.Modules.Events.Presentation.Events;
internal static class GetEventByLocation
{
    public static void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("events-location", async (string? location, ISender sender) =>
        {
            EventResponse @event = await sender.Send(new GetEventByLocationQuerry(location));

            return @event is null ? Results.NotFound() : Results.Ok(@event);
        })
        .WithTags(Tags.Events);

    }

}
