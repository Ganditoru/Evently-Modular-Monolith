﻿using Evently.Common.Domain;

namespace Evently.Modules.Ticketing.Domain.Events;
public static class TicketTypeErrors
{
    public static Error NotFound(Guid ticketTypeId) =>
        Error.NotFound("TicketTypes.NotFound", $"The ticket type with the identifier {ticketTypeId} was not found");
}
