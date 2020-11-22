using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Yord.Crack.Begin.Chapter3;

namespace Yord.Crack.Begin.Tests.Chapter3
{
    [TestFixture]
    public class Task5_Tests
    {
        [Test]
        public void Should_SortStack_Successfully()
        {
            var array = new[] {12, 1, 8, 5, 8};

            var sortedStack = Task5.Sort(Initialize(array));

            foreach (var a in array.OrderByDescending(i => i))
            {
                Assert.AreEqual(a, sortedStack.Pop());
            }
        }

        private Stack<int> Initialize(int[] array)
        {
            var stack = new Stack<int>();
            foreach (var i in array)
            {
                stack.Push(i);
            }

            return stack;
        }
    }
}
