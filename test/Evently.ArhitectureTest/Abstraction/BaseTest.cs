namespace Evently.ArhitectureTest.Abstraction;
#pragma warning disable CA1515 // Consider making public types internal
public abstract class BaseTest
#pragma warning restore CA1515 // Consider making public types internal
{
    protected const string UserNamingsapce = "Evently.Modules.Users";
    protected const string UserIntegrationEventsNamesapce = "Evently.Modules.Users.IntegrationEvents";

    protected const string EventsNamingsapce = "Evently.Modules.Events";
    protected const string EventsIntegrationEventsNamesapce = "Evently.Modules.Events.IntegrationEvents";
    protected const string EventsDomainEventsNamesapce = "Evently.Modules.Events.PublicApi";

    protected const string TicketingNamingsapce = "Evently.Modules.Ticketing";
    protected const string TicketingIntegrationEventsNamesapce = "Evently.Modules.Ticketing.IntegrationEvents";

}
