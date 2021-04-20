using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task26_Tests
    {
        [Test]
        public void Should_RemoveDuplicates()
        {
            var nums = new[] {1, 1, 2};
            Assert.AreEqual(2, Task26.RemoveDuplicates(nums));
            CollectionAssert.AreEqual(new[] {1,2,2}, nums);
        }
    }
}
