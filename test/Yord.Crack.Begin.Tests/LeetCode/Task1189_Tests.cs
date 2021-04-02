using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1189_Tests
    {
        [TestCase("nlaebolko", ExpectedResult = 1)]
        [TestCase("loonbalxballpoon", ExpectedResult = 2)]
        [TestCase("leetcode", ExpectedResult = 0)]
        public int Should_MaxNumberOfBalloons_Hash(string text)
        {
            return Task1189.MaxNumberOfBalloons_Hash(text);
        }
        
        [TestCase("nlaebolko", ExpectedResult = 1)]
        [TestCase("loonbalxballpoon", ExpectedResult = 2)]
        [TestCase("leetcode", ExpectedResult = 0)]
        public int Should_MaxNumberOfBalloons(string text)
        {
            return Task1189.MaxNumberOfBalloons(text);
        }
    }
}
