using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task5_Tests
    {
        [Test]
        public void Should_CheckRemove_Successfully()
        {
            Assert.IsTrue(Task5.IsOneModification("pale", "ple"));
            Assert.IsTrue(Task5.IsOneModification2("pale", "ple"));
            Assert.IsTrue(Task5.IsOneModification3("pale", "ple"));
        }
        
        [Test]
        public void Should_CheckAdd_Successfully()
        {
            Assert.IsTrue(Task5.IsOneModification("pale", "pales"));
            Assert.IsTrue(Task5.IsOneModification2("pale", "pales"));
            Assert.IsTrue(Task5.IsOneModification3("pale", "pales"));
        }
        
        [Test]
        public void Should_CheckModify_Successfully()
        {
            Assert.IsTrue(Task5.IsOneModification("pale", "bale"));
            Assert.IsTrue(Task5.IsOneModification2("pale", "bale"));
            Assert.IsTrue(Task5.IsOneModification3("pale", "bale"));
        }
        
        [Test]
        public void Should_CheckModifications_WhenMoreThanOne()
        {
            Assert.IsFalse(Task5.IsOneModification("pale", "bake"));
            Assert.IsFalse(Task5.IsOneModification2("pale", "bake"));
            Assert.IsFalse(Task5.IsOneModification3("pale", "bake"));
        }
        
        [Test]
        public void Should_CheckModifications_WhenNoModifications()
        {
            Assert.IsFalse(Task5.IsOneModification("pale", "pale"));
            Assert.IsFalse(Task5.IsOneModification2("pale", "pale"));
            Assert.IsFalse(Task5.IsOneModification3("pale", "pale"));
        }
    }
}
