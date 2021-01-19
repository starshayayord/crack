using NUnit.Framework;
using Yord.Crack.Begin.Chapter6;

namespace Yord.Crack.Begin.Tests.Chapter6
{
    [TestFixture]
    public class Task10_Tests
    {

        [Test]
        public void Should_FindPoisonedBottle()
        {
            var model = new Task10();
            
            Assert.AreEqual(model.PoisonedBottleNumber, model.FindBottle());
        }
    }
}
