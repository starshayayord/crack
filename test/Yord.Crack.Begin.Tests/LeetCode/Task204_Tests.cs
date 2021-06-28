using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task204_Tests
    {
        [TestCase(10, ExpectedResult = 4)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(499979, ExpectedResult = 41537)]
        public int Should_CountPrimes_Simple(int n)
        {
            return Task204.CountPrimes_Simple(n);
        }
        
        [TestCase(10, ExpectedResult = 4)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(499979, ExpectedResult = 41537)]
        public int Should_CountPrimes(int n)
        {
            return Task204.CountPrimes(n);
        }
        
        [TestCase(10, ExpectedResult = 4)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(499979, ExpectedResult = 41537)]
        public int Should_CountPrimes_LinearErato(int n)
        {
            return Task204.CountPrimes_LinearErato(n);
        }
    }
}
