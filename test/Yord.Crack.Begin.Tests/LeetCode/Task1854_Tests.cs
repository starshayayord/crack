using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1854_Tests
    {
        [Test]
        public void Should_MaximumPopulation()
        {
            Assert.AreEqual(1993, Task1854.MaximumPopulation(new[]
            {
                new[] {1993, 1999},
                new[] {2000, 2010}
            }));
            
            Assert.AreEqual(1960, Task1854.MaximumPopulation(new[]
            {
                new[] {1950, 1961},
                new[] {1960, 1971},
                new[] {1970, 1981}
            }));
        }
    }
}
