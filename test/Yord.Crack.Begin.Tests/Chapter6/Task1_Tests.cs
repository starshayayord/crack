using NUnit.Framework;
using Yord.Crack.Begin.Chapter6;

namespace Yord.Crack.Begin.Tests.Chapter6
{
    [TestFixture]
    public class Task1_Tests
    {
        [Test]
        public void Should_FindInvalidBottle()
        {
            var heavyBottleNumber = 5;
            Assert.AreEqual(heavyBottleNumber, Task1.FindHeavyBottle(heavyBottleNumber));
        }
    }
}
