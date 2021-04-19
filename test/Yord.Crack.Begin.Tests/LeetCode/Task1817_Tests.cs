using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1817_Tests
    {
        [Test]
        public void Should_FindActiveMinutes()
        {
            CollectionAssert.AreEqual(new[] {0,2,0,0,0}, Task1817.FindingUsersActiveMinutes(new []
            {
                new []{0,5},
                new []{1,2},
                new []{0,2},
                new []{0,5},
                new []{1,3}
            }, 5));
            
            CollectionAssert.AreEqual(new[] {1,1,0,0}, Task1817.FindingUsersActiveMinutes(new []
            {
                new []{1,1},
                new []{2,2},
                new []{2,3}
            }, 4));
        }
    }
}
