using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1688_Tests
    {
        [TestCase(7, ExpectedResult = 6)]
        [TestCase(14, ExpectedResult = 13)]
        [TestCase(2, ExpectedResult = 1)]
        public int Should_CountNumberOfMatches_Bit(int n)
        {
            return Task1688.NumberOfMatches_Bit(n);
        }
        
        [TestCase(7, ExpectedResult = 6)]
        [TestCase(14, ExpectedResult = 13)]
        [TestCase(2, ExpectedResult = 1)]
        public int Should_CountNumberOfMatches(int n)
        {
            return Task1688.NumberOfMatches(n);
        }
    }
}
