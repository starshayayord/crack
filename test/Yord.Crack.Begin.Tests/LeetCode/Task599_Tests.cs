using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task599_Tests
    {
        [Test]
        public void Should_FindRestaurant()
        {
            CollectionAssert.AreEquivalent(new[] {"Shogun"},
                Task599.FindRestaurant(new[] {"Shogun", "Tapioca Express", "Burger King", "KFC"},
                    new[] {"Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"}));
            CollectionAssert.AreEquivalent(new[] {"Shogun"},
                Task599.FindRestaurant(new[] {"Shogun", "Tapioca Express", "Burger King", "KFC"},
                    new[] {"KFC", "Shogun", "Burger King"}));
            CollectionAssert.AreEquivalent(new[] {"KFC", "Burger King", "Tapioca Express", "Shogun"},
                Task599.FindRestaurant(new[] {"Shogun", "Tapioca Express", "Burger King", "KFC"},
                    new[] {"KFC", "Burger King", "Tapioca Express", "Shogun"}));
            CollectionAssert.AreEqual(new[] {"KFC", "Burger King", "Tapioca Express", "Shogun"},
                Task599.FindRestaurant(new[] {"Shogun", "Tapioca Express", "Burger King", "KFC"},
                    new[] {"KFC", "Burger King", "Tapioca Express", "Shogun"}));
            CollectionAssert.AreEquivalent(new[] {"KFC"}, Task599.FindRestaurant(new[] {"KFC"}, new[] {"KFC"}));
        }
    }
}
