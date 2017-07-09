using System.Collections.Generic;
using NUnit.Framework;

namespace AssertDemo.Test.RangeEquality
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldHaveIncreasedHealthOnSleep()
        {
            var sut = new PlayerCharacter() { Health = 100 };
            sut.Sleep();
            Assert.That(sut.Health, Is.GreaterThan(100));
        }
        
        [Test]
        public void ShouldHaveIncreasedHealthOnSleep_Range()
        {
            var sut = new PlayerCharacter() { Health = 100 };
            sut.Sleep();
            Assert.That(sut.Health, Is.InRange(101, 200));
        }
        
        // Also Available
        //  Is.GreaterThanOrEqualTo
        //  Is.LessThan
        //  Is.LessThanOrEqualTo
    }
}
