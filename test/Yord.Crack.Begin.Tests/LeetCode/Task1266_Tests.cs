using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1266_Tests
    {
        [Test]
        public void Should_MinTimeToVisitAllPoints()
        {
            Assert.AreEqual(7, Task1266.MinTimeToVisitAllPoints(new []
            {
                new []{1,1}, new []{3,4}, new []{-1,0}
            }));
            
            Assert.AreEqual(5, Task1266.MinTimeToVisitAllPoints(new []
            {
                new []{3,2}, new []{-2,2}
            }));
        }
    }
}
