using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task2_Tests
    {
        [Test]
        public void Should_CreateMinBST_Successfully()
        {
            var bst = Task2.CreateMinBST(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11});
        }
        
        [Test]
        public void Should_CreateBST_Successfully()
        {
            var bst = Task2.CreateBinarySearchTree2(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11});
        }
    }
}
