using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task12_Tests
    {
        [Test]
        public void Should()
        {
            var routes = Task12.GetAllRoutesForNumber(GetTree(), 8);
            
           Assert.AreEqual(3, routes);
        }

        public Task12.BTNode GetTree()
        {
            return new Task12.BTNode
            {
                Value = 10,
                Right = new Task12.BTNode {Value = -3, Right = new Task12.BTNode {Value = 11}},
                Left = new Task12.BTNode
                {
                    Value = 5,
                    Right = new Task12.BTNode {Value = 1, Right = new Task12.BTNode {Value = 2}},
                    Left = new Task12.BTNode
                        {Value = 3, Left = new Task12.BTNode {Value = 3}, Right = new Task12.BTNode {Value = -2}}
                }
            };
        }
    }
}
