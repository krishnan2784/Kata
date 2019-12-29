using NUnit.Framework;

namespace Kata.Domain
{
    [TestFixture]
    public class HumanReadableTimeTest
    {
        [TestCase(0, "00:00:00")]
        public string GetHumanReadableTime(int timeAsInteger)
        {
            return TimeFormat.GetReadableTime(timeAsInteger);
        }
    }
}