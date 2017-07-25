using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AttributesDemo.Tests.DataDriven.CombinatorialTests
{
    [TestFixture]
    public class MemoryCalculatorCombinatorialTests
    {
        [Test]
        [Category("Checks Breaking")]
        public void ShouldAddAndDivide([Values(10, 20, 30)] int numToAdd, [Values(2, 1, 10)] int numToDivideBy)
        {
            var sut = new MemoryCalculator();
            sut.Add(numToAdd);
            sut.Divide(numToDivideBy);
        }
    }
}
