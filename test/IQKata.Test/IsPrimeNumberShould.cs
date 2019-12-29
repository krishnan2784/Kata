using NUnit.Framework;

namespace Kata.Test
{
    [TestFixture]
    public class IsPrimeNumberShould
    {
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(3, ExpectedResult = true)]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = true)]
        [TestCase(4, ExpectedResult = false)]
        [TestCase(6, ExpectedResult = false)]
        [TestCase(8, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = false)]
        public bool IsPrimeShould(int number)
        {
            return Kata.Domain.PrimeNumberService.IsPrime(number);
        }
    }
}