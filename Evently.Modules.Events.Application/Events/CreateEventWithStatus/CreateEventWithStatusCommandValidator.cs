using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evently.Modules.Events.Domain.Events;
using FluentValidation;

namespace Evently.Modules.Events.Application.Events.CreateEventWithStatus;
internal sealed class CreateEventWithStatusCommandValidator : AbstractValidator<CreateEventWithStatusCommand>
{
    public CreateEventWithStatusCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.Location).NotEmpty();
        RuleFor(c => c.StartsAtUtc).NotEmpty();
        RuleFor(c => c.EndsAtUtc).Must((cmd, endsAtUtc) => endsAtUtc > cmd.StartsAtUtc).When(c => c.EndsAtUtc.HasValue);
        RuleFor(c => c.Status).NotEqual(EventStatus.Draft);
    }
}
