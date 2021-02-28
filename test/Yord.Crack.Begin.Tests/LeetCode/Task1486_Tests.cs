using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1486_Tests
    {
        [TestCase(5, 0, ExpectedResult = 8)]
        [TestCase(4, 3, ExpectedResult = 8)]
        [TestCase(1, 7, ExpectedResult = 7)]
        [TestCase(10, 5, ExpectedResult = 2)]
        [TestCase(2, 1, ExpectedResult = 2)]
        public int Should_XorOperation(int n, int start)
        {
            return Task1486.XorOperation(n, start);
        }
    }
}
