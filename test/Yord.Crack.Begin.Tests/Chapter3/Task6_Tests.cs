using NUnit.Framework;
using Yord.Crack.Begin.Chapter3;

namespace Yord.Crack.Begin.Tests.Chapter3
{
    [TestFixture]
    public class Task6_Tests
    {
        [Test]
        public void Should_WorkAsShelter_Successfully()
        {
            var shelter = Initialize();

            Assert.AreEqual("cat1", shelter.DequeueCat().Name);
            Assert.AreEqual("dog1", shelter.DequeueDog().Name);
            Assert.AreEqual("cat2", shelter.DequeueAnimal().Name);
            shelter.Enqueue(new Task6.Cat("cat5"));
            Assert.AreEqual("cat3", shelter.DequeueAnimal().Name);
        }

        private Task6.Shelter Initialize()
        {
            var s = new Task6.Shelter();
            s.Enqueue(new Task6.Cat("cat1"));
            s.Enqueue(new Task6.Cat("cat2"));
            s.Enqueue(new Task6.Dog("dog1"));
            s.Enqueue(new Task6.Cat("cat3"));
            s.Enqueue(new Task6.Cat("cat4"));
            s.Enqueue(new Task6.Dog("dog2"));
            return s;
        }
    }
}
