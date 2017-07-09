using System.Collections.Generic;
using NUnit.Framework;

namespace AssertDemo.Test.NullsAndBooleanEquality
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldHaveDefaultGeneratedName()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Name, Is.Not.Empty);
        }

        [Test]
        public void ShouldNotHaveNickname()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Nickname, Is.Null);
        }

        [Test]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.IsNoob, Is.True);
        }
    }
}
