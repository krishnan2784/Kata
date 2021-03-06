﻿using Kata.Domain;
using NUnit.Framework;

namespace Kata.Test
{
    [TestFixture]
    [TestFixture]
    public class CleanStringTest
    {
        [TestCase("abc#d##c", ExpectedResult = "ac")]
        [TestCase("abc####d##c#", ExpectedResult = "")]
        public string SampleTest(string testString)
        {
           return CleanStringService.CleanString(testString);
        }
    }
}