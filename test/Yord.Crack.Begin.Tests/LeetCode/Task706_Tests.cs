using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task706_Tests
    {
        [Test]
        public void Should_CheckDictionary()
        {
            var t = new Task706.MyHashMap();
            t.Remove(27);
            t.Put(65,65);
            t.Remove(19);
            t.Remove(0);
            Assert.AreEqual(-1, t.Get(18));
            t.Remove(3);
            t.Put(42,0);
            Assert.AreEqual(-1, t.Get(19));
            t.Remove(42);
            t.Put(17,90);
            t.Put(31,76);
            t.Put(48,71);
            t.Put(5,50);
            t.Put(7,68);
            t.Put(73,74);
            t.Put(85,18);
            t.Put(74,95);
            t.Put(84,82);
            t.Put(59,29);
            t.Put(71,71);
            t.Remove(42);
            t.Put(51,40);
            t.Put(33,76);
            Assert.AreEqual(90, t.Get(17));
            t.Put(89,95);
            Assert.AreEqual(-1, t.Get(95));
            t.Put(30,31);
            t.Put(37,99);
            Assert.AreEqual(40, t.Get(51));
            t.Put(95,35);
            t.Remove(65);
            t.Remove(81);
            t.Put(61,46);
            t.Put(50,33);
            Assert.AreEqual(29, t.Get(59));
            t.Remove(5);
            t.Put(75,89);
            t.Put(80,17);
            t.Put(35,94);
            Assert.AreEqual(17, t.Get(80));
            t.Put(19,68);
            t.Put(13,17);
            t.Remove(70);
            t.Put(28,35);
            t.Remove(99);
            t.Remove(37);
            t.Remove(13);
            t.Put(90,83);
            t.Remove(41);
            Assert.AreEqual(33, t.Get(50));
            t.Put(29,98);
            t.Put(54,72);
            t.Put(6,8);
            t.Put(51,88);
            t.Remove(13);
            t.Put(8,22);
            Assert.AreEqual(18, t.Get(85));
            t.Put(31,22);
            t.Put(60,9);
            Assert.AreEqual(-1, t.Get(96));
            t.Put(6,35);
            t.Remove(54);
            Assert.AreEqual(-1, t.Get(15));
            Assert.AreEqual(35, t.Get(28));
            t.Remove(51);
            t.Put(80,69);
            t.Put(58,92);
            t.Put(13,12);
            t.Put(91,56);
            t.Put(83,52);
            t.Put(8,48);
            Assert.AreEqual(-1, t.Get(62));
            Assert.AreEqual(-1, t.Get(54));
            t.Remove(25);
            t.Put(36,4);
            t.Put(67,68);
            t.Put(83,36);
            t.Put(47,58);
            Assert.AreEqual(-1, t.Get(82));
            t.Remove(36);
            t.Put(30,85);
            t.Put(33,87);
            t.Put(42,18);
            t.Put(68,83);
            t.Put(50,53);
            t.Put(32,78);
            t.Put(48,90);
            t.Put(97,95);
            t.Put(13,8);
            t.Put(15,7);
            t.Remove(5);
            t.Remove(42);
            Assert.AreEqual(-1, t.Get(20));
            t.Remove(65);
            t.Put(57,9);
            t.Put(2,41);
            t.Remove(6);
            Assert.AreEqual(87, t.Get(33));
            t.Put(16,44);
            t.Put(95,30);

        }
    }
}
