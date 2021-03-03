using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1684_Tests
    {
        [Test]
        public void Should_CountConsistentStrings_Set()
        {
            Assert.AreEqual(2, Task1684.CountConsistentStrings_Set("ab",new []{"ad","bd","aaab","baa","badab"}));
            Assert.AreEqual(7, Task1684.CountConsistentStrings_Set("abc",new []{"a","b","c","ab","ac","bc","abc"}));
            Assert.AreEqual(4, Task1684.CountConsistentStrings_Set("cad",new []{"cc","acd","b","ba","bac","bad","ac","d"}));
        }
        
        [Test]
        public void Should_CountConsistentStrings_Array()
        {
            Assert.AreEqual(2, Task1684.CountConsistentStrings_Array("ab",new []{"ad","bd","aaab","baa","badab"}));
            Assert.AreEqual(7, Task1684.CountConsistentStrings_Array("abc",new []{"a","b","c","ab","ac","bc","abc"}));
            Assert.AreEqual(4, Task1684.CountConsistentStrings_Array("cad",new []{"cc","acd","b","ba","bac","bad","ac","d"}));
        }
    }
}
