using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Events;
public static class EventEndpoints
{
    public static void MapEndpoints(IEndpointRouteBuilder app)
    {
        CreateEvent.MapEndpoint(app);
        CreateEventWithStatus.MapEndpoint(app);
        GetEvent.MapEndpoint(app);
        GetEvents.MapEndpoint(app);
        GetEventByLocation.MapEndpoint(app);

    }
}
