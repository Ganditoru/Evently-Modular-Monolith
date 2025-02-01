﻿namespace Evently.Modules.Events.Api.Events;

public sealed record EventResoinse(
    Guid id,
    string Title,
    string Description,
    string Location,
    DateTime StartsAtUtc,
    DateTime? EndsAtUtc);
