using System;
using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1863_Tests
    {
        [Test]
        public void Should_SubsetXORSum()
        {
            Assert.AreEqual(0, Task1863.SubsetXORSum(Array.Empty<int>()));
            Assert.AreEqual(6, Task1863.SubsetXORSum(new[] {1, 3}));
            Assert.AreEqual(28, Task1863.SubsetXORSum(new[] {1, 5, 6}));
            Assert.AreEqual(480, Task1863.SubsetXORSum(new[] {3, 4, 5, 6, 7, 8}));
        }
    }
}
