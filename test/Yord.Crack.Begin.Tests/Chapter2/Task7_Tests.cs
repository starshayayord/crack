using NUnit.Framework;
using Yord.Crack.Begin.Chapter2;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    [TestFixture]
    public class Task7_Tests
    {
        [Test]
        public void Should_GetIntersection2_WhenNone()
        {
            var source1 = GenerateList(new[] {9, 0, 0, 9});
            var source2 = GenerateList(new[] {9, 1, 2, 3});
            
            var inter = Task7.Node.GetIntersection2(source1, source2);

            Assert.IsNull(inter);
        }
        
        [Test]
        public void Should_GetIntersection2_WhenMiddle()
        {
            var source1 = GenerateList(new[] {9, 0, 0, 9});
            var source2 = GenerateList(new[] {9, 1});
            source2._next = source1;

            var inter = Task7.Node.GetIntersection2(source1, source2);

            Assert.AreEqual(source1, inter);
        }
        
        [Test]
        public void Should_GetIntersection_WhenNone()
        {
            var source1 = GenerateList(new[] {9, 0, 0, 9});
            var source2 = GenerateList(new[] {9, 1, 2, 3});
            
            var inter = Task7.Node.GetIntersection(source1, source2);

            Assert.IsNull(inter);
        }
        
        [Test]
        public void Should_GetIntersection_WhenMiddle()
        {
            var source1 = GenerateList(new[] {9, 0, 0, 9});
            var source2 = GenerateList(new[] {9, 1, 2, 3});
            source2._next = source1;

            var inter = Task7.Node.GetIntersection(source1, source2);

            Assert.AreEqual(source1, inter);
        }

        private Task7.Node GenerateList(int[] array)
        {
            var head = new Task7.Node(array[0]);
            for (var i = 1; i < array.Length; i++)
            {
                head.Append(array[i]);
            }

            return head;
        }
    }
}
