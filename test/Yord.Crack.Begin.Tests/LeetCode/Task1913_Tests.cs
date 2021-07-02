using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1913_Tests
    {
        [Test]
        public void Should_MaxProductDifference()
        {
            Assert.AreEqual(34, Task1913.MaxProductDifference(new[] {5, 6, 2, 7, 4}));
            Assert.AreEqual(64, Task1913.MaxProductDifference(new[] {4, 2, 5, 9, 7, 4, 8}));
        }
    }
}
