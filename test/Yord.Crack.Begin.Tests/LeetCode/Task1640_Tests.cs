using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1640_Tests
    {
        [Test]
        public void Should_CanFormArray()
        {
            Assert.IsTrue(Task1640.CanFormArray(new[] {85}, new[] {new[] {85}}));
            Assert.IsTrue(Task1640.CanFormArray(new[] {15, 88}, new[] {new[] {88}, new[] {15}}));
            Assert.IsFalse(Task1640.CanFormArray(new[] {49, 18, 16}, new[] {new[] {16, 18, 49}}));
            Assert.IsTrue(Task1640.CanFormArray(new[] {91, 4, 64, 78}, new[] {new[] {78}, new[] {4, 64}, new[] {91}}));
            Assert.IsFalse(Task1640.CanFormArray(new[] {1, 3, 5, 7}, new[] {new[] {2, 4, 6, 8}}));
        }
        
        [Test]
        public void Should_CanFormArray_Map()
        {
            Assert.IsTrue(Task1640.CanFormArray_Map(new[] {85}, new[] {new[] {85}}));
            Assert.IsTrue(Task1640.CanFormArray_Map(new[] {15, 88}, new[] {new[] {88}, new[] {15}}));
            Assert.IsFalse(Task1640.CanFormArray_Map(new[] {49, 18, 16}, new[] {new[] {16, 18, 49}}));
            Assert.IsTrue(Task1640.CanFormArray_Map(new[] {91, 4, 64, 78}, new[] {new[] {78}, new[] {4, 64}, new[] {91}}));
            Assert.IsFalse(Task1640.CanFormArray_Map(new[] {1, 3, 5, 7}, new[] {new[] {2, 4, 6, 8}}));
        }
        
        [Test]
        public void Should_CanFormArray_Map2()
        {
            Assert.IsTrue(Task1640.CanFormArray_Map2(new[] {85}, new[] {new[] {85}}));
            Assert.IsTrue(Task1640.CanFormArray_Map2(new[] {15, 88}, new[] {new[] {88}, new[] {15}}));
            Assert.IsFalse(Task1640.CanFormArray_Map2(new[] {49, 18, 16}, new[] {new[] {16, 18, 49}}));
            Assert.IsTrue(Task1640.CanFormArray_Map2(new[] {91, 4, 64, 78}, new[] {new[] {78}, new[] {4, 64}, new[] {91}}));
            Assert.IsFalse(Task1640.CanFormArray_Map2(new[] {1, 3, 5, 7}, new[] {new[] {2, 4, 6, 8}}));
        }
    }
}
