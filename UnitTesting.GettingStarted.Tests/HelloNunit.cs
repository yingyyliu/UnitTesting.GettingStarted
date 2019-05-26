using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class HelloNUnit
    {
        [Test]
        public void TestHelloNunit()
        {
            Assert.That(true, Is.True);
        }
    }
}
