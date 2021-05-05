using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1844_Tests
    {
        [TestCase("a1c1e1", ExpectedResult = "abcdef")]
        [TestCase("a1b2c3d4e", ExpectedResult = "abbdcfdhe")]
        public string Should_ReplaceDigits(string s)
        {
            return Task1844.ReplaceDigits(s);
        }
    }
}
