using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task9_Tests
    {
        [Test]
        public void Should_CheckIfRotated_Successfully()
        {
            Assert.IsTrue(Task9.IsRotated("erbottlewat", "waterbottle"));
            Assert.IsFalse(Task9.IsRotated("erbottlewat", "tawerbottle"));
        }
    }
}
