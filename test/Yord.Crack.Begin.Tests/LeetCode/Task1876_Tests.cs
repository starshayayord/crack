using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1876_Tests
    {
        [TestCase("xyzzaz", ExpectedResult = 1)]
        [TestCase("aababcabc", ExpectedResult = 4)]
        public int Should_CountGoodSubstrings(string s)
        {
            return Task1876.CountGoodSubstrings(s);
        }
        
        [TestCase("xyzzaz", ExpectedResult = 1)]
        [TestCase("aababcabc", ExpectedResult = 4)]
        public int Should_CountGoodSubstrings2(string s)
        {
            return Task1876.CountGoodSubstrings2(s);
        }
    }
}
