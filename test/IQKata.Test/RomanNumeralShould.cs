using NUnit.Framework;

namespace Kata.Test
{
    [TestFixture]
    public class RomanNumeralShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(500, "D")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(1000, "M")]
        [TestCase(1954, "MCMLIV")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        [TestCase(2014, "MMXIV")]
        public void Test(int value, string expected)
        {
            Assert.AreEqual(expected, Kata.Domain.RomanConvert.Solution(value));
        }
    }
}