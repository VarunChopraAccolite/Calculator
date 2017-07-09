using System;
using NUnit.Framework;

namespace AssertDemo.Test.Exceptions
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShouldErrorWhenDivideByZero()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act and Assert
            Assert.That(() => sut.Divide(200, 0), Throws.Exception);
        }

        [Test]
        public void ShouldErrorWhenDivideByZero_ExplicitExceptionType()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act and Assert
            Assert.That(() => sut.Divide(99, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void ShouldErrorWhenNumberTooBig_ExplicitExceptionType()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act and Assert
            Assert.That(() => sut.Divide(200, 0), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ShouldErrorWhenNumberTooBig_MoreExplicitExceptionType()
        {
            // Arrange
            var sut = new SimpleCalculator();

            // Act and Assert
            Assert.That(() => sut.Divide(200, 0),
                Throws.TypeOf<ArgumentOutOfRangeException>().With
                    .Matches<ArgumentOutOfRangeException>(x => x.ParamName == "value"));
        }
    }
}
