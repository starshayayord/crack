using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1323_Tests
    {
        [TestCase(9669,ExpectedResult = 9969)]
        [TestCase(9996,ExpectedResult = 9999)]
        [TestCase(9999,ExpectedResult = 9999)]
        [TestCase(696,ExpectedResult = 996)]
        public int Should_Maximum69Number_4(int n)
        {
            return Task1323.Maximum69Number_4(n);
        }
        
        [TestCase(9669,ExpectedResult = 9969)]
        [TestCase(9996,ExpectedResult = 9999)]
        [TestCase(9999,ExpectedResult = 9999)]
        [TestCase(696,ExpectedResult = 996)]
        public int Should_Maximum69Number_3(int n)
        {
            return Task1323.Maximum69Number_3(n);
        }
        
        [TestCase(9669,ExpectedResult = 9969)]
        [TestCase(9996,ExpectedResult = 9999)]
        [TestCase(9999,ExpectedResult = 9999)]
        [TestCase(696,ExpectedResult = 996)]
        public int Should_Maximum69Number_2(int n)
        {
            return Task1323.Maximum69Number_2(n);
        }
        
        
        [TestCase(9669,ExpectedResult = 9969)]
        [TestCase(9996,ExpectedResult = 9999)]
        [TestCase(9999,ExpectedResult = 9999)]
        [TestCase(696,ExpectedResult = 996)]
        public int Should_Maximum69Number(int n)
        {
            return Task1323.Maximum69Number(n);
        }
    }
}
