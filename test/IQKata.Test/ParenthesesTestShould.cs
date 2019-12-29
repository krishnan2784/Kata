
using Kata.Domain;
using NUnit.Framework;

namespace Kata.Test
{
    [TestFixture]
    public class ParenthesesTestShould
    {
        [TestCase("()", ExpectedResult = true)]
        [TestCase(")(()))", ExpectedResult = false)]
        [TestCase("(", ExpectedResult = false)]
        [TestCase("(())((()())())", ExpectedResult = true)]
        [TestCase(")((((", ExpectedResult =false)]
        [TestCase("())", ExpectedResult = true)]
        [TestCase("", ExpectedResult = true)]
        public bool CheckParentThesesTest(string testString)
        {
            return ParentThesesService.Check(testString);
        }
    }
}