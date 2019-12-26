using NUnit.Framework;
using System;
using IQKata.Domain;

namespace IQKata.Test
{
    
    [TestFixture]
    public class IqTests
    { 
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, Iq.Test("2 4 7 8 10"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Iq.Test("1 2 2"));
        }
    }
}