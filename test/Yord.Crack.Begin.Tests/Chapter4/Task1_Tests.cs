using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task1_Tests
    {
        [Test]
        public void Should_CheckGraph_Successfully()
        {
            var graph = Generate();

            Assert.IsTrue(Task1.IsConnected(graph.Nodes[0], graph.Nodes[0].Adjacents[0].Adjacents[0]));
            Assert.IsFalse(Task1.IsConnected(graph.Nodes[1], graph.Nodes[0]));
        }

        private static Task1.Graph<int> Generate()
        {
            return new Task1.Graph<int>
            {
                Nodes = new[]
                {
                    new Task1.Graph<int>.GraphNode
                    {
                        Value = 1,
                        Adjacents = new[]
                        {
                            new Task1.Graph<int>.GraphNode
                            {
                                Value = 2,
                                Adjacents = new[]
                                {
                                    new Task1.Graph<int>.GraphNode
                                    {
                                        Value = 3,
                                        Adjacents = new[] {new Task1.Graph<int>.GraphNode {Value = 4}}
                                    },
                                    new Task1.Graph<int>.GraphNode
                                    {
                                        Value = 5,
                                        Adjacents = new[] {new Task1.Graph<int>.GraphNode {Value = 6}}
                                    },
                                }
                            }
                        }
                    },
                    new Task1.Graph<int>.GraphNode {Value = 7}
                }
            };
        }
    }
}
