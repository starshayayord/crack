using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class NumberPalindrome_Tests
    {
        [TestCase(1, ExpectedResult = true)]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(121, ExpectedResult = true)]
        [TestCase(98289, ExpectedResult = true)]
        [TestCase(123321, ExpectedResult = true)]
        [TestCase(12312321, ExpectedResult = false)]
        [TestCase(1231, ExpectedResult = false)]
        public bool Should_CheckIfPalindrome(int x)
        {
            return NumberPalindrome.IsPalindrome(x);
        }
    }
}
