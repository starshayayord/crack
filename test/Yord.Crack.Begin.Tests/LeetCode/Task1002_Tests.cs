using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1002_Tests
    {
        [Test]
        public void Should_CommonChars()
        {
            CollectionAssert.AreEquivalent(new[] {"e", "l", "l"},
                Task1002.CommonChars(new[] {"bella", "label", "roller"}));

            CollectionAssert.AreEquivalent(new[] {"c", "o"},
                Task1002.CommonChars(new[] {"cool", "lock", "cook"}));
        }
    }
}
