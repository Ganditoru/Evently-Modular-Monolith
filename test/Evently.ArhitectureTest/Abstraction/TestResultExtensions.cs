using FluentAssertions;
using NetArchTest.Rules;

namespace Evently.ArhitectureTest.Abstraction;

internal static class TestResultExtensions
{
    internal static void ShouldBeSuccessful(this TestResult testResult)
    {
        testResult.FailingTypes?.Should().BeEmpty();
    }
}
