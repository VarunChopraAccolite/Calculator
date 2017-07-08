using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act
            var result = sut.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act
            var result = sut.Multiply(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
