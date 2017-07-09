using NUnit.Framework;

namespace AssertDemo.Test.StringEquality
{
    [TestFixture]
    public class NameJoinerTests
    {
        [Test]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();
            var result = sut.Join("Jon", "Arryn");
            Assert.That(result, Is.EqualTo("Jon Arryn"));
        }

        [Test]
        public void ShouldJoinNames_CaseInsensitiveAssertDemo()
        {
            var sut = new NameJoiner();
            var result = sut.Join("Jon", "Arryn");
            Assert.That(result, Is.EqualTo("JON ARRYN").IgnoreCase);
        }

        [Test]
        public void ShouldJoinNames_NotEqualsDemo()
        {
            var sut = new NameJoiner();
            var result = sut.Join("Jon", "Arryn");
            Assert.That(result, Is.Not.EqualTo("Lysa Arryn"));
        }
    }
}
