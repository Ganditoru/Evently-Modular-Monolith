using System.Reflection;
using Evently.ArhitectureTest.Abstraction;
using Evently.Modules.Events.Domain.Events;
using Evently.Modules.Events.Infrastructure;
using Evently.Modules.Ticketing.Domain.Tickets;
using Evently.Modules.Ticketing.Infrastructure;
using Evently.Modules.Users.Domain.Users;
using Evently.Modules.Users.Infrastructure;
using NetArchTest.Rules;

namespace Evently.ArhitectureTest.Layers;
public class ModuleTests: BaseTest
{
    [Fact]
    public void TicketingModule_ShouldNotHaveDependencieyOn_AnyOtherModule()
    {
        string[] otherModules = [EventsNamingsapce, UserNamingsapce];
        string[] integrationsEventsModules = [
            EventsDomainEventsNamesapce,
            UserIntegrationEventsNamesapce
            ];

        List<Assembly> ticketingAssemblies = [
                typeof(Ticket).Assembly,
                Modules.Ticketing.Application.AssemblyReference.Assembly,
                Modules.Ticketing.Presentation.AssemblyReference.Assembly,
                typeof(TicketingModule).Assembly
            ];

        Types.InAssemblies(ticketingAssemblies)
            .That()
            .DoNotHaveDependencyOnAny(integrationsEventsModules)
            .Should()
            .NotHaveDependencyOnAny(otherModules)
            .GetResult()
            .ShouldBeSuccessful();
    }

    [Fact]
    public void UsersModule_ShouldNotHaveDependencieyOn_AnyOtherModule()
    {
        string[] otherModules = [EventsNamingsapce, TicketingNamingsapce];
        string[] integrationsEventsModules = [];

        List<Assembly> usersAssemblies = [
                typeof(User).Assembly,
                Modules.Users.Application.AssemblyReference.Assembly,
                Modules.Users.Presentation.AssemblyReference.Assembly,
                typeof(UsersModule).Assembly
            ];

        Types.InAssemblies(usersAssemblies)
            .That()
            .DoNotHaveDependencyOnAny(integrationsEventsModules)
            .Should()
            .NotHaveDependencyOnAny(otherModules)
            .GetResult()
            .ShouldBeSuccessful();
    }

    [Fact]
    public void EventsModule_ShouldNotHaveDependencieyOn_AnyOtherModule()
    {
        string[] otherModules = [TicketingNamingsapce, TicketingNamingsapce];
        string[] integrationsEventsModules = [];

        List<Assembly> eventsAssemblies = [
                typeof(Event).Assembly,
                Modules.Events.Application.AssemblyReference.Assembly,
                Modules.Events.Presentation.AssemblyReference.Assembly,
                typeof(EventsModule).Assembly
            ];

        Types.InAssemblies(eventsAssemblies)
            .That()
            .DoNotHaveDependencyOnAny(integrationsEventsModules)
            .Should()
            .NotHaveDependencyOnAny(otherModules)
            .GetResult()
            .ShouldBeSuccessful();
    }
}
