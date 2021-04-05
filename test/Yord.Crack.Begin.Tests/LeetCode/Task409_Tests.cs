using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task409_Tests
    {

        [TestCase("abccccdd", ExpectedResult = 7)]
        [TestCase("ccc", ExpectedResult = 3)]
        [TestCase("a", ExpectedResult = 1)]
        [TestCase("bb", ExpectedResult = 2)]
        public int Should_FindLongestPalindrome(string s)
        {
            return Task409.LongestPalindrome(s);
        }
    }
}
