using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task476_Tests
    {
        [TestCase(5, ExpectedResult = 2)]
        [TestCase(1, ExpectedResult = 0)]
        public int Should_FindComplement(int n)
        {
            return Task476.FindComplement(n);
        }
        
        [TestCase(5, ExpectedResult = 2)]
        [TestCase(1, ExpectedResult = 0)]
        public int Should_FindComplement2(int n)
        {
            return Task476.FindComplement2(n);
        }
    }
}
