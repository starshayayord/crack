using System;
using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task10_Tests
    {
        [Test]
        public void Should_CheckIfSubtree_Successfully()
        {
            var trees = GetTrees();

            Assert.IsTrue(Task10.IsSubTree(trees.Item1, trees.Item2));
        }

        private Tuple<Task10.BTNode, Task10.BTNode> GetTrees()
        {
            var t2 = new Task10.BTNode
            {
                Value = 5,
                Left = new Task10.BTNode {Value = 6}, Right = new Task10.BTNode {Value = 7}
            };
            var t1 = new Task10.BTNode
            {
                Value = 1,
                Left = new Task10.BTNode {Value = 2},
                Right = new Task10.BTNode
                {
                    Value = 3,
                    Left = new Task10.BTNode {Value = 4},
                    Right = t2
                }
            };
            return new Tuple<Task10.BTNode, Task10.BTNode>(t1, t2);
        }
    }
}
