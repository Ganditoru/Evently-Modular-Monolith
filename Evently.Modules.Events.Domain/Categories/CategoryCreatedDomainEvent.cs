﻿using Evently.Modules.Events.Domain.Abstraction;

namespace Evently.Modules.Events.Domain.Categories;
public sealed class CategoryCreatedDomainEvent(Guid categoryId) : DomainEvent
{
    public Guid CategoryId { get; init; } = categoryId;
}
