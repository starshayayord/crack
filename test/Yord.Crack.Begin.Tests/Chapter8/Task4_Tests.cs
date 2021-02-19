using System.Collections.Generic;
using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class Task4_Tests
    {
        [Test]
        public void Should_GetAllSubsets()
        {
            var subsets = Task4.GetAllSubsets(new[] {1, 2, 3});
            CollectionAssert.AreEquivalent(new List<List<int>>
            {
                new List<int>(),
                new List<int> {1},
                new List<int> {2},
                new List<int> {3},
                new List<int> {1, 2},
                new List<int> {2, 3},
                new List<int> {1, 3},
                new List<int> {1, 2, 3},
            }, subsets);
        }
        
        [Test]
        public void Should_GetAllSubsets_Rec()
        {
            var subsets = Task4.GetAllSubsetsRec(new[] {1, 2, 3});
            CollectionAssert.AreEquivalent(new List<List<int>>
            {
                new List<int>(),
                new List<int> {1},
                new List<int> {2},
                new List<int> {3},
                new List<int> {2, 1},
                new List<int> {3, 2},
                new List<int> {3, 1},
                new List<int> {3, 2, 1}
            }, subsets);
        }
    }
}
