using Kata.Domain;
using NUnit.Framework;

namespace Kata.Test
{
    [TestFixture]
    public class RgbToHexConvertorShould
    {
        [TestCase(255, 255, 255, ExpectedResult = "FFFFFF")]
        [TestCase(255, 255, 300, ExpectedResult = "FFFFFF")]
        [TestCase(0, 0, 0, ExpectedResult = "000000")]
        [TestCase(148, 0, 211, ExpectedResult = "9400D3")]
        public string ConvertToHex(int redValue, int greenValue, int blueValue)
        {
            return ColourConvertor.ToRgb(redValue, greenValue, blueValue);
        }

    }
}