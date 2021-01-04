using NUnit.Framework;
using  Yord.Crack.Begin.Chapter5;

namespace Yord.Crack.Begin.Tests.Chapter5
{
    [TestFixture]
    public class Task3_Tests
    {
        [Test]
        public void Should_GetMaxSequence()
        {
            Assert.AreEqual(8, Task3.GetMaxSequence(1775));
            Assert.AreEqual(32, Task3.GetMaxSequence(-1));
        }
    }
}
