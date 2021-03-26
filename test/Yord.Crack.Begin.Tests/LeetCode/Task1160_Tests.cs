using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1160_Tests
    {
        [Test]
        public void Should_CountChars()
        {
           Assert.AreEqual(6, Task1160.CountCharacters(new []{"cat","bt","hat","tree"}, "atach"));
           Assert.AreEqual(10, Task1160.CountCharacters(new []{"hello","world","leetcode"}, "welldonehoneyr"));
        }
    }
}
