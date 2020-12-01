using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task6_Tests
    {
        [Test]
        public void Should_GetNext2_Successfully()
        {
            Assert.AreEqual(3, Task6.GetNext(GetRoot()).Value);
            Assert.AreEqual(1, Task6.GetNext(GetRLeft()).Value);
            Assert.AreEqual(2, Task6.GetNext(GetLeft()).Value);
        }

        private Task6.BTNode GetRoot()
        {
            var root = new Task6.BTNode {Value = 1};
            var rLeft = new Task6.BTNode {Value = 2, Parent = root};
            var rRight =  new Task6.BTNode {Value = 3, Parent = root};
            root.Left = rLeft;
            root.Right = rRight;
            var left = new Task6.BTNode {Value = 4, Parent = rLeft};
            rLeft.Left = left;
            return root;
        }
        
        private Task6.BTNode GetRLeft()
        {
            var root = new Task6.BTNode {Value = 1};
            var rLeft = new Task6.BTNode {Value = 2, Parent = root};
            var rRight =  new Task6.BTNode {Value = 3, Parent = root};
            root.Left = rLeft;
            root.Right = rRight;
            var left = new Task6.BTNode {Value = 4, Parent = rLeft};
            rLeft.Left = left;
            return rLeft;
        }
        
        private Task6.BTNode GetLeft()
        {
            var root = new Task6.BTNode {Value = 1};
            var rLeft = new Task6.BTNode {Value = 2, Parent = root};
            var rRight =  new Task6.BTNode {Value = 3, Parent = root};
            root.Left = rLeft;
            root.Right = rRight;
            var left = new Task6.BTNode {Value = 4, Parent = rLeft};
            rLeft.Left = left;
            return left;
        }
    }
}
