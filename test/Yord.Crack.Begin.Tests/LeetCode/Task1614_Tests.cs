using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1614_Test
    {
        [TestCase("(1+(2*3)+((8)/4))+1", ExpectedResult = 3)]
        [TestCase("(1)+((2))+(((3)))", ExpectedResult = 3)]
        [TestCase("1+(2*3)/(2-1)", ExpectedResult = 1)]
        [TestCase("1", ExpectedResult = 0)]
        public int Should_GetMaxDepth(string s)
        {
            return Task1614.MaxDepth(s);
        }
    }
}
