using System.Collections;
using NUnit.Framework;

namespace AttributesDemo.Tests.DataDriven.SharingTestsDataTests
{
    [TestFixture]
    public class MemoryCalculatorTests
    {
        [TestCaseSource(typeof(ExampleTestCaseSource))]
        public void ShouldSubtractTwoNegativeNumbers(int firstNum, int secondNum, int expectedNum)
        {
            var sut = new MemoryCalculator();
            sut.Subtract(firstNum);
            sut.Subtract(secondNum);
            Assert.That(sut.CurrentValue, Is.EqualTo(expectedNum));
        }
    }

    public class ExampleTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] { -5, -10, 15 };
            yield return new[] { -5, -5, 10 };
            yield return new[] { 0, -10, 10 };
            yield return new[] { 0, 0, 0 };
        }
    }
}

