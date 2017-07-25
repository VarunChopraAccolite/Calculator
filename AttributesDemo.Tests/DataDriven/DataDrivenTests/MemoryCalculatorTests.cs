using System.Diagnostics;
using NUnit.Framework;

namespace AttributesDemo.Tests.DataDriven.DataDrivenTests
{
    [TestFixture]
    public class MemoryCalculatorTests
    {
        [TestCase(-5, -10, 15)]
        [TestCase(-5, -5, 10)]
        [TestCase(0, -10, 10)]
        public void ShouldSubtractTwoNegativeNumbers(int firstNum, int secondNum, int expectedNum)
        {
            var sut = new MemoryCalculator();
            sut.Subtract(firstNum);
            sut.Subtract(secondNum);
            Assert.That(sut.CurrentValue, Is.EqualTo(expectedNum));
        }
    }
}

