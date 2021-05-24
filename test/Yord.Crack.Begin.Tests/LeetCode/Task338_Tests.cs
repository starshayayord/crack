using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task338_Tests
    {
        [Test]
        public void Should_Count1()
        {
            CollectionAssert.AreEqual(new [] {0,1,1,2,1,2,2,3,1}, Task338.CountBits2(8));
        }
    }
}
