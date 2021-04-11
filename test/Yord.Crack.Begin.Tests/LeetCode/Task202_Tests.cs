using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task202_Tests
    {
        [TestCase(19, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = false)]
        public bool Should_IsHappy(int n)
        {
            return Task202.IsHappy(n);
        }
    }
}
