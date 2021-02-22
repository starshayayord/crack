using System.Collections.Generic;
using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class Task7_Tests
    {
        [Test]
        public void Check_AllPermutationsString()
        {
            var source = "abc";

            var permutations = Task7.GetPermutations(source);

            CollectionAssert.AreEquivalent(new[] {"abc", "acb", "bac", "bca", "cab", "cba"}, permutations);
        }

        [Test]
        public void Check_AllPermutationsArray()
        {
            var source = new List<int> {1, 2, 3};

            var permutations = Task7.GetPermutationsArray(source);

            CollectionAssert.AreEquivalent(new[]
            {
                new[]
                {
                    new[] {1, 2, 3},
                    new[] {1, 3, 2},
                    new[] {2, 1, 3},
                    new[] {2, 3, 1},
                    new[] {3, 1, 2},
                    new[] {3, 2, 1},
                }
            }, permutations);
        }
    }
}
