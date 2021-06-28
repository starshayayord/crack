using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task206_Tests
    {
        [Test]
        public void Should_Reverse()
        {
            var head = new Task206.ListNode(1,
                new Task206.ListNode(2,
                    new Task206.ListNode(3,
                        new Task206.ListNode(4, new Task206.ListNode(5, new Task206.ListNode(6))))));
            Assert.AreEqual(6, Task206.ReverseList(head).val);

            head = new Task206.ListNode(1, new Task206.ListNode(2));
            Assert.AreEqual(2, Task206.ReverseList(head).val);
            Assert.AreEqual(null, Task206.ReverseList(null));
        }
        
        [Test]
        public void Should_Reverse2()
        {
            var head = new Task206.ListNode(1,
                new Task206.ListNode(2,
                    new Task206.ListNode(3,
                        new Task206.ListNode(4, new Task206.ListNode(5, new Task206.ListNode(6))))));
            Assert.AreEqual(6, Task206.ReverseList2(head).val);

            head = new Task206.ListNode(1, new Task206.ListNode(2));
            Assert.AreEqual(2, Task206.ReverseList2(head).val);
            Assert.AreEqual(null, Task206.ReverseList2(null));
        }
    }
}
