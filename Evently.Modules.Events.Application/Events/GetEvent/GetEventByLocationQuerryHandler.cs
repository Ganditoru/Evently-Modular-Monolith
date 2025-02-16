using System.Data.Common;
using Dapper;
using Evently.Modules.Events.Application.Abstractions.Data;
using MediatR;

namespace Evently.Modules.Events.Application.Events.GetEvent;

internal sealed class GetEventByLocationQuerryHandler(IDbConnectionFactory dbConnectionFactory)
    : IRequestHandler<GetEventByLocationQuerry, EventResponse?>
{
    public async Task<EventResponse?> Handle(GetEventByLocationQuerry request, CancellationToken cancellationToken)
    {
        await using DbConnection connection = await dbConnectionFactory.OpenConnectionAsync();

        const string sql =
            $"""
             SELECT
                id AS {nameof(EventResponse.Id)},
                title AS {nameof(EventResponse.Title)},
                description AS {nameof(EventResponse.Description)},
                location AS {nameof(EventResponse.Location)},
                starts_at_utc AS {nameof(EventResponse.StartsAtUtc)},
                ends_at_utc AS {nameof(EventResponse.EndsAtUtc)},
                status AS {nameof(EventResponse.Status)}
             FROM events.events
             WHERE location = @Location
            """;

        EventResponse? @event = await connection.QuerySingleOrDefaultAsync<EventResponse>(sql, request);

        return @event;
    }
}
