using System.Collections.Generic;
using NUnit.Framework;

namespace AssertDemo.Test.Collections
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldNotHaveEmptyDefaultWeapons()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Is.All.Not.Empty);
        }

        [Test]
        public void ShouldHaveShortBow()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Contains.Item("Short Bow"));
        }

        [Test]
        public void ShouldHaveAtleastOneKindOfSword()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.Some?.Contains("Sword"));
        }

        [Test]
        public void ShouldHaveTwoBows()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.Exactly(2).EndsWith("Bow"));
        }

        [Test]
        public void ShouldNotHaveMoreThanOneTypeOfGivenWeapon()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Is.Unique);
        }

        [Test]
        public void ShouldNotHaveMagicStaffWeapon()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.None.EqualTo("Magic Staff"));
        }

        [Test]
        public void ShouldHaveAllExpectedWeapons()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Is.EquivalentTo(new List<string>
            {
                "Short Sword",
                "Long Bow",
                "Short Bow"
            }));
        }

        [Test]
        public void ShouldHaveAllDefaultWeaponsInAlphabeticalOrder()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Is.Ordered);
        }
    }
}
