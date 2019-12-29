using Kata.Domain;
using NUnit.Framework;

namespace Kata.Test
{
    [TestFixture]
    public class HumanReadableTimeTest
    {
        [TestCase(0, ExpectedResult = "00:00:00")]
        [TestCase(359999, ExpectedResult = "99:59:59")]
        [TestCase(5, ExpectedResult = "00:00:05")]
        [TestCase(86399, ExpectedResult = "23:59:59")]
        [TestCase(86400, ExpectedResult = "24:00:00")]
        [TestCase(60, ExpectedResult = "00:01:00")]
        [TestCase(172800, ExpectedResult ="48:00:00")]
        public string GetHumanReadableTime(int timeAsInteger)
        {
            return TimeFormat.GetReadableTime(timeAsInteger);
        }
    }
}