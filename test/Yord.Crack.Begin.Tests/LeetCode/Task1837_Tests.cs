using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1837_Tests
    {
        [Test]
        public void Should_SumBase()
        {
            Assert.AreEqual(9, Task1837.SumBase(34, 6));
            Assert.AreEqual(1, Task1837.SumBase(10, 10));
        }
    }
}
