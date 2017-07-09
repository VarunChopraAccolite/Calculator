using System.Collections.Generic;
using NUnit.Framework;

namespace AssertDemo.Test.ReferenceEquality
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldNotHaveSameReference()
        {
            var player1 = new PlayerCharacter();
            var player2 = new PlayerCharacter();
            Assert.That(player1, Is.Not.SameAs(player2));
        }

        [Test]
        public void ShouldHaveSameReference()
        {
            var player1 = new PlayerCharacter();
            var somePlayer = player1;
            Assert.That(player1, Is.SameAs(somePlayer));
        }
    }
}
