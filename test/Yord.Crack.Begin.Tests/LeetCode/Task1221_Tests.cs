using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1221_Tests
    {
        [TestCase("RLRRLLRLRL", ExpectedResult = 4)]
        [TestCase("RLLLLRRRLR", ExpectedResult = 3)]
        [TestCase("LLLLRRRR", ExpectedResult = 1)]
        [TestCase("RLRRRLLRLL", ExpectedResult = 2)]
        public int Should_SplitBalancedString(string s)
        {
            return Task1221.BalancedStringSplit(s);
        }
    }
}
