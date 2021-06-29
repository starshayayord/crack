using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task637_Tests
    {
        
        [Test]
        public void Should_GetLevelAvg2()
        {
            CollectionAssert.AreEqual(new[] {3.0, 14.5, 11.0}, Task637.AverageOfLevels2(
                new Task637.TreeNode(3
                    , new Task637.TreeNode(9), new Task637.TreeNode(20,
                        new Task637.TreeNode(15), new Task637.TreeNode(7)))));

            CollectionAssert.AreEqual(new[] {3.0, 14.5, 11.0}, Task637.AverageOfLevels2(
                new Task637.TreeNode(3,
                    new Task637.TreeNode(9, new Task637.TreeNode(15), new Task637.TreeNode(7)),
                    new Task637.TreeNode(20))));
        }
        
        [Test]
        public void Should_GetLevelAvg()
        {
            CollectionAssert.AreEqual(new[] {3.0, 14.5, 11.0}, Task637.AverageOfLevels(
                new Task637.TreeNode(3
                    , new Task637.TreeNode(9), new Task637.TreeNode(20,
                        new Task637.TreeNode(15), new Task637.TreeNode(7)))));

            CollectionAssert.AreEqual(new[] {3.0, 14.5, 11.0}, Task637.AverageOfLevels(
                new Task637.TreeNode(3,
                    new Task637.TreeNode(9, new Task637.TreeNode(15), new Task637.TreeNode(7)),
                    new Task637.TreeNode(20))));
        }
    }
}
