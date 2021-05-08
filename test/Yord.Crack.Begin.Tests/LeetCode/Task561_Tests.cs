using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task561_Tests
    {
        [Test]
        public void Should_ArrayPairSum()
        {
            Assert.AreEqual(4, Task561.ArrayPairSum(new[] {1, 4, 3, 2}));
            Assert.AreEqual(9, Task561.ArrayPairSum(new[] {6, 2, 6, 5, 1, 2}));
        }
    }
}
