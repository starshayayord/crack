using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1281_Tests
    {
        [Test]
        public void Should_SubtractProductAndSum()
        {
            Assert.AreEqual(21, Task1281.SubtractProductAndSum(4421));
        }
    }
}
