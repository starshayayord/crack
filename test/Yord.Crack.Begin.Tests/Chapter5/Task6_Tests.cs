using NUnit.Framework;
using Yord.Crack.Begin.Chapter5;

namespace Yord.Crack.Begin.Tests.Chapter5
{
    [TestFixture]
    public class Task6_Tests
    {
        [TestCase(1, 1, ExpectedResult = 0)]
        [TestCase(29, 15, ExpectedResult = 2)]
        public int Should_CountDifferentBits(int a, int b)
        {
            return Task6.CountDifferentBits(a, b);
        }
    }
}
