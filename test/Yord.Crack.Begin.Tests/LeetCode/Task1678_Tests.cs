using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1678_Tests
    {
        [Test]
        public void Should_ParseGoal()
        {
            Assert.AreEqual("Goal", Task1678.Interpret("G()(al)"));
            Assert.AreEqual("Gooooal", Task1678.Interpret("G()()()()(al)"));
            Assert.AreEqual("alGalooG", Task1678.Interpret("(al)G(al)()()G"));
        }
        
        [Test]
        public void Should_ParseGoal_Regex()
        {
            Assert.AreEqual("Goal", Task1678.Interpret_Regex("G()(al)"));
            Assert.AreEqual("Gooooal", Task1678.Interpret_Regex("G()()()()(al)"));
            Assert.AreEqual("alGalooG", Task1678.Interpret_Regex("(al)G(al)()()G"));
        }
    }
}
