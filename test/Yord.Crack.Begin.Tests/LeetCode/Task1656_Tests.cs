using System.Collections.Generic;
using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1656_Tests
    {
        [Test]
        public void Should_CheckOrderedStream()
        {
            var s = new Task1656.OrderedStream(5);
            CollectionAssert.AreEqual(new string[] {}, s.Insert(3,"ccccc"));
            CollectionAssert.AreEqual(new[] {"aaaaa"}, s.Insert(1,"aaaaa"));
            CollectionAssert.AreEqual(new[] {"bbbbb", "ccccc"}, s.Insert(2,"bbbbb"));
            CollectionAssert.AreEqual(new string[] {}, s.Insert(5,"eeeee"));
            CollectionAssert.AreEqual(new[] {"ddddd", "eeeee"}, s.Insert(4,"ddddd"));
        }
    }
}
