using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task463_Tests
    {
        [Test]
        public void Should_GetPerimeter()
        {
            Assert.AreEqual(16, Task463.IslandPerimeter(new[]
            {
                new[] {0, 1, 0, 0},
                new[] {1, 1, 1, 0},
                new[] {0, 1, 0, 0},
                new[] {1, 1, 0, 0}
            }));

            Assert.AreEqual(4, Task463.IslandPerimeter(new[]
            {
                new[] {1}
            }));

            Assert.AreEqual(4, Task463.IslandPerimeter(new[]
            {
                new[] {1},
                new[] {0}
            }));

            Assert.AreEqual(10, Task463.IslandPerimeter(new[]
            {
                new[] {0, 1, 1},
                new[] {1, 1, 0}
            }));
            
            Assert.AreEqual(4, Task463.IslandPerimeter(new[]
            {
                new[] {0},
                new[] {1}
            }));
            
            Assert.AreEqual(12, Task463.IslandPerimeter(new[]
            {
                new[] {1,1,1},
                new[] {1,0,1}
            }));
        }
        
        [Test]
        public void Should_GetPerimeter_Simple()
        {
            Assert.AreEqual(16, Task463.IslandPerimeter_Simple(new[]
            {
                new[] {0, 1, 0, 0},
                new[] {1, 1, 1, 0},
                new[] {0, 1, 0, 0},
                new[] {1, 1, 0, 0}
            }));

            Assert.AreEqual(4, Task463.IslandPerimeter_Simple(new[]
            {
                new[] {1}
            }));

            Assert.AreEqual(4, Task463.IslandPerimeter_Simple(new[]
            {
                new[] {1},
                new[] {0}
            }));

            Assert.AreEqual(10, Task463.IslandPerimeter_Simple(new[]
            {
                new[] {0, 1, 1},
                new[] {1, 1, 0}
            }));
            
            Assert.AreEqual(4, Task463.IslandPerimeter_Simple(new[]
            {
                new[] {0},
                new[] {1}
            }));
            
            Assert.AreEqual(12, Task463.IslandPerimeter_Simple(new[]
            {
                new[] {1,1,1},
                new[] {1,0,1}
            }));
        }
        
        [Test]
        public void Should_GetPerimeter_2()
        {
            Assert.AreEqual(16, Task463.IslandPerimeter_2(new[]
            {
                new[] {0, 1, 0, 0},
                new[] {1, 1, 1, 0},
                new[] {0, 1, 0, 0},
                new[] {1, 1, 0, 0}
            }));

            Assert.AreEqual(4, Task463.IslandPerimeter_2(new[]
            {
                new[] {1}
            }));

            Assert.AreEqual(4, Task463.IslandPerimeter_2(new[]
            {
                new[] {1},
                new[] {0}
            }));

            Assert.AreEqual(10, Task463.IslandPerimeter_2(new[]
            {
                new[] {0, 1, 1},
                new[] {1, 1, 0}
            }));
            
            Assert.AreEqual(4, Task463.IslandPerimeter_2(new[]
            {
                new[] {0},
                new[] {1}
            }));
            
            Assert.AreEqual(12, Task463.IslandPerimeter_2(new[]
            {
                new[] {1,1,1},
                new[] {1,0,1}
            }));
        }
    }
}
