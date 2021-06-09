using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task876_Tests
    {
        [Test]
        public void Should_GetMiddle()
        {
            var head1 = new Task876.ListNode(1,
                new Task876.ListNode(2, new Task876.ListNode(3, new Task876.ListNode(4, new Task876.ListNode(5)))));
            var m1 = Task876.MiddleNode(head1);
            Assert.AreEqual(3, m1.val);
            var head2 = new Task876.ListNode(1,
                new Task876.ListNode(2,
                    new Task876.ListNode(3,
                        new Task876.ListNode(4, new Task876.ListNode(5, new Task876.ListNode(6))))));
            var m2 = Task876.MiddleNode(head2);
            Assert.AreEqual(4, m2.val);
        }
    }
}
