using NUnit.Framework;
using Yord.Crack.Begin.Chapter5;

namespace Yord.Crack.Begin.Tests.Chapter5
{
    [TestFixture]
    public class Task5_Tests
    {
        [Test]
        public void Should_CheckCode()
        {
            var r = Task5.GetNumbersTill(8);
            CollectionAssert.AreEqual(new []{0, 1, 2, 4, 8}, r);
        }
    }
}
