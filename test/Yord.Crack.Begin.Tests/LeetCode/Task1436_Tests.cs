using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1436_Tests
    {
        [Test]
        public void Should_GetDestination()
        {
            var dest = Task1436.DestCity(new[]
            {
                new[] {"London", "New York"},
                new[] {"New York", "Lima"},
                new[] {"Lima", "Sao Paulo"}
            });
            Assert.AreEqual("Sao Paulo", dest);
        }

        [Test]
        public void Should_GetDestination_2()
        {
            var dest = Task1436.DestCity(new[]
            {
                new[] {"B", "C"},
                new[] {"D", "B"},
                new[] {"C", "A"}
            });
            Assert.AreEqual("A", dest);
        }

        [Test]
        public void Should_GetDestination_3()
        {
            var dest = Task1436.DestCity(new[]
            {
                new[] {"A", "Z"}
            });
            Assert.AreEqual("z", dest);
        }
    }
}
