using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1370_Tests
    {
        [TestCase("aaaabbbbcccc", ExpectedResult = "abccbaabccba")]
        [TestCase("leetcode", ExpectedResult = "cdelotee")]
        [TestCase("rat", ExpectedResult = "art")]
        [TestCase("ggggggg", ExpectedResult = "ggggggg")]
        [TestCase("spo", ExpectedResult = "ops")]
        public string Should_SortString(string s)
        {
            return Task1370.SortString(s);
        }
    }
}
