using NUnit.Framework;
using Yord.Crack.Begin.Chapter2;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    [TestFixture]
    public class Task6_Tests
    {
        [Test]
        public void Should_CheckIsPalindromeRec2_WhenNot()
        {
            var source = GenerateList(new[] {9, 0, 9, 1});

            var result = Task6.Node.IsPalindromeRec2(source);

            Assert.IsFalse(result);
        }
        
        [Test]
        public void Should_CheckIsPalindromeRec2_WhenOdd()
        {
            var source = GenerateList(new[] {9, 0, 9});

            var result = Task6.Node.IsPalindromeRec2(source);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void Should_CheckIsPalindromeRec2_WhenEven()
        {
            var source = GenerateList(new[] {9, 0, 0, 9});

            var result = Task6.Node.IsPalindromeRec2(source);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void Should_CheckIsPalindromeRec_WhenNot()
        {
            var source = GenerateList(new[] {9, 0, 9, 1});

            var result = Task6.Node.IsPalindromeRec(source);

            Assert.IsFalse(result);
        }
        
        [Test]
        public void Should_CheckIsPalindromeRec_WhenOdd()
        {
            var source = GenerateList(new[] {9, 0, 9});

            var result = Task6.Node.IsPalindromeRec(source);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void Should_CheckIsPalindromeRec_WhenEven()
        {
            var source = GenerateList(new[] {9, 0, 0, 9});

            var result = Task6.Node.IsPalindromeRec(source);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void Should_CheckIsPalindromeSQ_WhenNot()
        {
            var source = GenerateList(new[] {9, 0, 9, 1});

            var result = Task6.Node.IsPalindromeStackQueue(source);

            Assert.IsFalse(result);
        }
        
        [Test]
        public void Should_CheckIsPalindromeSQ_WhenOdd()
        {
            var source = GenerateList(new[] {9, 0, 9});

            var result = Task6.Node.IsPalindromeStackQueue(source);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void Should_CheckIsPalindromeSQ_WhenEven()
        {
            var source = GenerateList(new[] {9, 0, 0, 9});

            var result = Task6.Node.IsPalindromeStackQueue(source);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void Should_CheckIsPalindrome_WhenNot()
        {
            var source = GenerateList(new[] {9, 0, 9, 1});

            var result = Task6.Node.IsPalindrome(source);

            Assert.IsFalse(result);
        }
        
        [Test]
        public void Should_CheckIsPalindrome_WhenOdd()
        {
            var source = GenerateList(new[] {9, 0, 9});

            var result = Task6.Node.IsPalindrome(source);

            Assert.IsTrue(result);
        }
        
        [Test]
        public void Should_CheckIsPalindrome_WhenEven()
        {
            var source = GenerateList(new[] {9, 0, 0, 9});

            var result = Task6.Node.IsPalindrome(source);

            Assert.IsTrue(result);
        }
        
        private Task6.Node GenerateList(int[] array)
        {
            var head = new Task6.Node(array[0]);
            for (var i = 1; i < array.Length; i++)
            {
                head.Append(array[i]);
            }

            return head;
        }
    }
}
