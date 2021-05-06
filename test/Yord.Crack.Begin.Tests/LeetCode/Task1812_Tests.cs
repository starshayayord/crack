using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1812_Tests
    {
        [TestCase("a1", ExpectedResult = false)]
        [TestCase("h3", ExpectedResult = true)]
        [TestCase("c7", ExpectedResult = false)]
        public bool Should_DetermineColor(string s)
        {
            return Task1812.SquareIsWhite(s);
        }
    }
}
