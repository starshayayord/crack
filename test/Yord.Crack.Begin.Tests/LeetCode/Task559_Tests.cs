using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task559_Tests
    {
        [Test]
        public void Should_FindMaxDepth()
        {
            Assert.AreEqual(3, Task559.MaxDepth(new Task559.Node(1, new[]
            {
                new Task559.Node(3, new[] {new Task559.Node(5), new Task559.Node(6)}),
                new Task559.Node(2),
                new Task559.Node(4)
            })));

            Assert.AreEqual(5, Task559.MaxDepth(new Task559.Node(1, new[]
            {
                new Task559.Node(2),
                new Task559.Node(3,
                    new[]
                    {
                        new Task559.Node(6),
                        new Task559.Node(7, new[] {new Task559.Node(11, new[] {new Task559.Node(14)})})
                    }),
                new Task559.Node(4, new[] {new Task559.Node(8, new[] {new Task559.Node(12)})}),
                new Task559.Node(5, new[] {new Task559.Node(9, new[] {new Task559.Node(13)}), new Task559.Node(10)})
            })));
        }
    }
}
