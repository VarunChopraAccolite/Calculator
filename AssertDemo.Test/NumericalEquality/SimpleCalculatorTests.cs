using NUnit.Framework;

namespace AssertDemo.Test.NumericalEquality
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

        [Test]
        public void ShouldAddTwoDoubleNumbers()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act
            var result = sut.Add(1.1, 2.2);

            // Assert
            Assert.That(result, Is.Not.EqualTo(3.3));
        }

        [Test]
        public void ShouldAddTwoDoubleNumbers_WithTolerance()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act
            var result = sut.Add(1.1, 2.2);

            // Assert
            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void ShouldAddTwoDoubleNumbers_WithPercentTolerance()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act
            var result = sut.Add(50d, 50d);

            // Assert
            Assert.That(result, Is.EqualTo(101d).Within(1).Percent);
        }

        [Test]
        public void ShouldAddTwoDoubleNumbers_WithBadTolerance()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act
            var result = sut.Add(1.1d, 2.1d);

            // Assert
            Assert.That(result, Is.EqualTo(30).Within(100));
        }
        
        // Also Available
        //  Is.Positive
        //  Is.Negative
        //  Is.NaN
    }
}
