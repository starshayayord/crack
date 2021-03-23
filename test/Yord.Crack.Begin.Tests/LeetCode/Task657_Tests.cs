using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task657_Tests
    {
        [TestCase("UD", ExpectedResult = true)]
        [TestCase("LL", ExpectedResult = false)]
        [TestCase("RRDD", ExpectedResult = false)]
        [TestCase("LDRRLRUULR", ExpectedResult = false)]
        public bool Should_JudgeCircle(string s)
        {
            return Task657.JudgeCircle(s);
        }
    }
}
