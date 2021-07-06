using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1399_Tests
    {
        [TestCase(13, ExpectedResult = 4)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(15, ExpectedResult = 6)]
        [TestCase(24, ExpectedResult = 5)]
        public int Should_CountLargestGroup(int n)
        {
            return Task1399.CountLargestGroup(n);
        }
    }
}
