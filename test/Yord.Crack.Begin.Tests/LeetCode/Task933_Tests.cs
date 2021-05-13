using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task933_Tests
    {
        [Test]
        public void Should_CountCalls()
        {
            var r = new Task933.RecentCounter();
            
            Assert.AreEqual(1, r.Ping(1));
            Assert.AreEqual(2, r.Ping(100));
            Assert.AreEqual(3, r.Ping(3001));
            Assert.AreEqual(3, r.Ping(3002));
        }
    }
}
