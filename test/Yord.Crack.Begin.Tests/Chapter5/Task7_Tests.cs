using NUnit.Framework;
using Yord.Crack.Begin.Chapter5;

namespace Yord.Crack.Begin.Tests.Chapter5
{
    [TestFixture]
    public class Task7_Tests
    {
        [TestCase(329, ExpectedResult = 646)]
        public int Should_SwapBits(int n)
        {
            return Task7.SwapBits(n);
        }
    }
}
