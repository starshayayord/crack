using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task8_Tests
    {
        [Test]
        public void Should_FindAncestor_SameSide()
        {
            var tree = GetTreeSameSide();

            var ancestor = Task8.GetAncestor(tree.Root, tree.N1, tree.N2);
            
            Assert.AreEqual(tree.Ancestor, ancestor);
        }
        
        [Test]
        public void Should_FindAncestor_Successfully()
        {
            var tree = GetTree();

            var ancestor = Task8.GetAncestor( tree.Root, tree.N1, tree.N2);
            
            Assert.AreEqual(tree.Ancestor, ancestor);
        }
        
        private AncestorResult GetTreeSameSide()
        {
            var n2 = new Task8.BTNode
            {
                Value = 3
            };
            var n1 = new Task8.BTNode
            {
                Value = 2,
                Left = n2
            };
           
            var root = new Task8.BTNode
            {
                Value = 1,
                Left = n1
            };
            return new AncestorResult
            {
                Root = root,
                Ancestor = n1,
                N1 = n1,
                N2 = n2
            };
        }

        private AncestorResult GetTree()
        {
            var n1 = new Task8.BTNode
            {
                Value = 2
            };
            var n2 = new Task8.BTNode
            {
                Value = 4
            };
            var root = new Task8.BTNode
            {
                Value = 1,
                Left = n1,
                Right = new Task8.BTNode
                {
                    Value = 3,
                    Right = n2
                }
            };
            return new AncestorResult
            {
                Root = root,
                Ancestor = root,
                N1 = n1,
                N2 = n2
            };
        }

        private class AncestorResult
        {
            public Task8.BTNode Root;
            public Task8.BTNode N1;
            public Task8.BTNode N2;
            public Task8.BTNode Ancestor;
        }
    }
}
