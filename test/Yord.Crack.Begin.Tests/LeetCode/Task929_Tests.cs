using System.Threading.Tasks;
using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task929_Tests
    {
        [Test]
        public void Should_NumUniqueEmails()
        {
            Assert.AreEqual(2, Task929.NumUniqueEmails(new []{"test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"}));
            Assert.AreEqual(3, Task929.NumUniqueEmails(new []{"a@leetcode.com","b@leetcode.com","c@leetcode.com"}));
            Assert.AreEqual(2, Task929.NumUniqueEmails(new []{"test.email+alex@leetcode.com","test.email.leet+alex@code.com"}));
        }
        
        [Test]
        public void Should_NumUniqueEmails2()
        {
            Assert.AreEqual(1, Task929.NumUniqueEmails2(new []{"test.email+alex@leetcode.com", "test.email@leetcode.com"}));
            Assert.AreEqual(2, Task929.NumUniqueEmails2(new []{"test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"}));
            Assert.AreEqual(3, Task929.NumUniqueEmails2(new []{"a@leetcode.com","b@leetcode.com","c@leetcode.com"}));
            Assert.AreEqual(2, Task929.NumUniqueEmails2(new []{"test.email+alex@leetcode.com","test.email.leet+alex@code.com"}));
        }
    }
}
