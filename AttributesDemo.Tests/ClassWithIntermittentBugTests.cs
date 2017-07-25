using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AttributesDemo.Tests
{
    [TestFixture]
    [Category("Intermittent Bug")]
    public class ClassWithIntermittentBugTests
    {
        [Test]
        [Repeat(10000)]
        public void ShouldDoWork()
        {
            var sut = new ClassWithIntermittentBug();
            sut.DoWork();
        }
    }
}
