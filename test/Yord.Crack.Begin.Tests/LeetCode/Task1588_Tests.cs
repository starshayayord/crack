using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1588_Tests
    {
        [Test]
        public void Should_SumOddLengthSubArrays()
        {
            Assert.AreEqual(58, Task1588.SumOddLengthSubArrays(new[] {1, 4, 2, 5, 3}));
            Assert.AreEqual(3, Task1588.SumOddLengthSubArrays(new[] {1, 2}));
            Assert.AreEqual(66, Task1588.SumOddLengthSubArrays(new[] {10, 11, 12}));
        }
    }
}
