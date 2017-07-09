using NUnit.Framework;

namespace AssertDemo.Test.ObjectTypesAndProperties
{
	[TestFixture]
    public class EnemyFactoryTests
    {
        [Test]
        public void ShouldCreateNormalEnemy()
        {
            var sut = new EnemyFactory();
            var normalEnemy = sut.Create(false);
            Assert.That(normalEnemy, Is.TypeOf<NormalEnemy>());
        }

        [Test]
        public void ShouldCreateBossEnemy()
        {
            var sut = new EnemyFactory();
            var bossEnemy = sut.Create(true);
            Assert.That(bossEnemy, Is.TypeOf<BossEnemy>());
        }

        [Test]
        public void ShouldBeOfBaseType()
        {
            var sut = new EnemyFactory();
            var bossEnemy = sut.Create(true);
            Assert.That(bossEnemy, Is.InstanceOf<IEnemy>());
        }

        [Test]
        public void ShouldHaveExtraPowerForBoss()
        {
            var sut = new EnemyFactory();
            var bossEnemy = sut.Create(true);
            Assert.That(bossEnemy, Has.Property("ExtraPower"));
        }
    }
}
