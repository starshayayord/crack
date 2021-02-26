using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1342_Tests
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(8, ExpectedResult = 4)]
        [TestCase(14, ExpectedResult = 6)]
        public int Should_CountNumberOfSteps(int n)
        {
            return Task1342.NumberOfSteps(n);
        }
        
    }
}
