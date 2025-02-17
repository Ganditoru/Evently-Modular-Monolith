using Evently.Common.Application.Clock;

namespace Evently.Common.Clock;
internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
