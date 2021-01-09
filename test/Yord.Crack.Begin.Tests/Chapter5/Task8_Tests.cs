using NUnit.Framework;
using Yord.Crack.Begin.Chapter5;
namespace Yord.Crack.Begin.Tests.Chapter5
{
    [TestFixture]
    public class Task8_Tests
    {
        [Test]
        public void Should_DrawLine()
        {
            var screen = new byte[] {
                0, 0, 0, 0, 0, 0, //[0] Y
                0, 0, 0, 0, 0, 0, //[1] Y
                0, 0, 0, 0, 0, 0, //[2] Y
                0, 0, 0, 0, 0, 0, //[3] Y
            };
            Task8.DrawLine(screen, 6*8, 9, 35, 1);
            CollectionAssert.AreEqual(new byte[] {
                0, 0, 0, 0, 0, 0,         //[0] Y
                0, 127, 255, 255, 240, 0, //[1] Y
                0, 0, 0, 0, 0, 0,         //[2] Y
                0, 0, 0, 0, 0, 0,         //[3] Y
            }, screen);
        }
    }
}
