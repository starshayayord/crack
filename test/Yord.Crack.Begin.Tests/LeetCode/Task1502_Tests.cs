using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1502_Tests
    {
        [Test]
        public void Should_CanMakeArithmeticProgression()
        {
            Assert.IsTrue(Task1502.CanMakeArithmeticProgression(new[] {3, 5, 1}));
            Assert.IsFalse(Task1502.CanMakeArithmeticProgression(new[] {1, 2, 4}));
        }
        
        [Test]
        public void Should_CanMakeArithmeticProgressionN()
        {
            Assert.IsTrue(Task1502.CanMakeArithmeticProgressionN(new[] {3, 5, 1}));
            Assert.IsFalse(Task1502.CanMakeArithmeticProgressionN(new[] {1, 2, 4}));
        }
    }
}
