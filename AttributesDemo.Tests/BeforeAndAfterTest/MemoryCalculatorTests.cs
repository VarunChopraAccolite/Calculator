using System;
using System.Diagnostics;
using NUnit.Framework;

namespace AttributesDemo.Tests.BeforeAndAfterTest
{
    [TestFixture]
    public class MemoryCalculatorTests
    {
        private MemoryCalculator _sut = new MemoryCalculator();

        [OneTimeSetUp]
        public void BeforeFixture()
        {
            Trace.WriteLine($"NormalBeforeAndAfterTest::Before {nameof(MemoryCalculatorTests)}");
            _sut = new MemoryCalculator();
        }

        [OneTimeTearDown]
        public void AfterFixture()
        {
            Trace.WriteLine($"NormalBeforeAndAfterTest::After {nameof(MemoryCalculatorTests)}");
            _sut = null;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            Trace.WriteLine($"BeforeAndAfterTest::Before {TestContext.CurrentContext.Test.Name}");
            _sut = new MemoryCalculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Trace.WriteLine($"BeforeAndAfterTest::After {TestContext.CurrentContext.Test.Name}");
            _sut = null;
        }

        [Test]
        public void ShouldAdd()
        {
            _sut.Add(5);
            _sut.Add(5);
            Assert.That(_sut.CurrentValue, Is.EqualTo(10));
        }

        [Test]
        public void ShouldSubtract()
        {
            _sut.Subtract(5);
            Assert.That(_sut.CurrentValue, Is.EqualTo(-5));
        }
    }
}
