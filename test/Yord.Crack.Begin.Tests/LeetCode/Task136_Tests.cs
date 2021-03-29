using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task136_Tests
    {
        [Test]
        public void Should_FindSingle()
        {
            Assert.AreEqual(1, Task136.SingleNumber(new []{2,2,1}));
            Assert.AreEqual(4, Task136.SingleNumber(new []{4,1,2,1,2}));
            Assert.AreEqual(1, Task136.SingleNumber(new []{1}));
        }
    }
}
