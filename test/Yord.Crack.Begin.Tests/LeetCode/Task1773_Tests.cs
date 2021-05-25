using System.Collections.Generic;
using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1773_Tests
    {
        [Test]
        public void Should_CountMatches()
        {
            Assert.AreEqual(1, Task1773.CountMatches(new IList<string>[]
            {
                new[] {"phone", "blue", "pixel"}, new[] {"computer", "silver", "lenovo"},
                new[] {"phone", "gold", "iphone"}
            }, "color", "silver"));
            
            Assert.AreEqual(2, Task1773.CountMatches(new IList<string>[]
            {
                new[] {"phone", "blue", "pixel"}, new[] {"computer", "silver", "lenovo"},
                new[] {"phone", "gold", "iphone"}
            }, "type", "phone"));
        }
    }
}
