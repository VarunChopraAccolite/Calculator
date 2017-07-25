using System.Diagnostics;
using NUnit.Framework;

namespace AttributesDemo.Tests
{
    /// <summary>
    /// Applicable for containing namespace <see cref="AttributesDemo.Tests.BeforeAndAfterNamespace"/>
    /// </summary>
    [SetUpFixture]
    public class SetupFixtureForSpecificNamespace
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTestsInNamespace()
        {
            Trace.WriteLine($"### Before any test in {nameof(SetupFixtureForSpecificNamespace)}");
        }

        [OneTimeTearDown]
        public void RunAfterAnyTestsInNamespace()
        {
            Trace.WriteLine($"### After any test in {nameof(SetupFixtureForSpecificNamespace)}");
        }
    }
}

