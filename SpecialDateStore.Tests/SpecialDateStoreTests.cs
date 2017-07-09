using System;
using NUnit.Framework;

namespace SpecialDateStore.Tests
{
    [TestFixture]
    public class SpecialDateStoreTests
    {
        [Test]
        public void ShouldHaveCorrectMilleniumDate()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDate.NewMillenium);
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0)));
        }

        [Test]
        public void ShouldHaveIncorrectMilleniumDate()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDate.NewMillenium);
            Assert.That(result, Is.Not.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)));
        }

        [Test]
        public void ShouldHaveCorrectMilleniumDate_WithTolerance()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDate.NewMillenium);
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)).Within(TimeSpan.FromMilliseconds(1)));
        }

        [Test]
        public void ShouldHaveCorrectMilleniumDate_WithTimeTolerance()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDate.NewMillenium);
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)).Within(1).Milliseconds);
        }

    }
}
