using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1332_Tests
    {
        [TestCase("ababa", ExpectedResult = 1)]
        [TestCase("abb", ExpectedResult = 2)]
        [TestCase("baabb", ExpectedResult = 2)]
        public int Should_RemovePalindromeSub(string s)
        {
            return Task1332.RemovePalindromeSub(s);
        }
    }
}
