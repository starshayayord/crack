using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task944_Tests
    {
        [TestCase]
        public void Should_MinDeletionSize()
        {
            Assert.AreEqual(1, Task944.MinDeletionSize(new[] {"cba", "daf", "ghi"}));
            Assert.AreEqual(0, Task944.MinDeletionSize(new[] {"a", "b"}));
            Assert.AreEqual(3, Task944.MinDeletionSize(new[] {"zyx", "wvu", "tsr"}));
        }
    }
}
