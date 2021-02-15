using System.Collections.Generic;
using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class Task2_Tests
    {
        
        [Test]
        public void Should_FindWayCache()
        {
            var grid = new bool[4][];
            grid[0] = new[] {true, true, true, true, false};
            grid[1] = new[] {true, true, false, true, true};
            grid[2] = new[] {true, true, true, true, true};
            grid[3] = new[] {true, false, true, true, true};

            var way = Task2.FindWay(grid);

            CollectionAssert.AreEqual(new List<Task2.Point>
            {
                new Task2.Point(0, 0),
                new Task2.Point(1, 0),
                new Task2.Point(2, 0),
                new Task2.Point(2, 1),
                new Task2.Point(2, 2),
                new Task2.Point(3, 2),
                new Task2.Point(3, 3),
                new Task2.Point(3, 4)
            }, way);
        }
        
        
        [Test]
        public void Should_FindWay()
        {
            var grid = new int[3][];
            grid[0] = new[] {1, 0, 1};
            grid[1] = new[] {1, 0, 1};
            grid[2] = new[] {1, 1, 1};

            var way = Task2.FindWay2(grid);

            CollectionAssert.AreEqual(new List<Task2.Coordinate>
            {
                new Task2.Coordinate(0, 0),
                new Task2.Coordinate(1, 0),
                new Task2.Coordinate(2, 0),
                new Task2.Coordinate(2, 1),
                new Task2.Coordinate(2, 2)
            }, way);
        }

        [Test]
        public void Should_FindWay2()
        {
            var grid = new int[3][];
            grid[0] = new[] {1, 1, 1};
            grid[1] = new[] {1, 1, 1};
            grid[2] = new[] {1, 0, 1};

            var way = Task2.FindWay2(grid);

            CollectionAssert.AreEqual(new List<Task2.Coordinate>
            {
                new Task2.Coordinate(0, 0),
                new Task2.Coordinate(1, 0),
                new Task2.Coordinate(1, 1),
                new Task2.Coordinate(1, 2),
                new Task2.Coordinate(2, 2)
            }, way);
        }

        [Test]
        public void Should_FindWay3()
        {
            var grid = new int[4][];
            grid[0] = new[] {1, 1, 1, 1, 0};
            grid[1] = new[] {1, 1, 0, 1, 1};
            grid[2] = new[] {1, 1, 1, 1, 1};
            grid[3] = new[] {1, 0, 1, 1, 1};

            var way = Task2.FindWay2(grid);

            CollectionAssert.AreEqual(new List<Task2.Coordinate>
            {
                new Task2.Coordinate(0, 0),
                new Task2.Coordinate(1, 0),
                new Task2.Coordinate(2, 0),
                new Task2.Coordinate(2, 1),
                new Task2.Coordinate(2, 2),
                new Task2.Coordinate(3, 2),
                new Task2.Coordinate(3, 3),
                new Task2.Coordinate(3, 4),
            }, way);
        }

        [Test]
        public void ShouldNot_FindWay()
        {
            var grid = new int[3][];
            grid[0] = new[] {1, 0, 1};
            grid[1] = new[] {1, 0, 1};
            grid[2] = new[] {0, 1, 1};

            var way = Task2.FindWay2(grid);

            Assert.IsNull(way);
        }
    }
}
