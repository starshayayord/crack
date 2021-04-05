using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task387_Tests
    {
        [TestCase("leetcode", ExpectedResult = 0)]
        [TestCase("loveleetcode", ExpectedResult = 2)]
        [TestCase("aabb", ExpectedResult = -1)]
        public int Should_FindUnique_Pointer(string s)
        {
            return Task387.FirstUniqChar_Pointer(s);
        }
        
        [TestCase("leetcode", ExpectedResult = 0)]
        [TestCase("loveleetcode", ExpectedResult = 2)]
        [TestCase("aabb", ExpectedResult = -1)]
        public int Should_FindUnique_Arr(string s)
        {
            return Task387.FirstUniqChar_Arr(s);
        }
    }
}
