using System;
using NUnit.Framework;
using Yord.Crack.Begin.Start;

namespace Yord.Crack.Begin.Tests.Start
{
    [TestFixture]
    public class NoteTests
    {
        [Test]
        public void Should_FindJournal_Successfully()
        {
            var journals = new[]
            {
                "ab cd ab",
                "ab cd",
                "ab cd ab cd",
                "ab ab"
            };
            var note = "cd ab ab";

            var resultNumbers = Note.IsFromJournal(journals, note);
            
            CollectionAssert.AreEquivalent(new [] {0, 2}, resultNumbers);
        }
        
        [Test]
        public void ShouldNot_FindJournal_WhenNotPossible()
        {
            var journals = new[]
            {
                "ab cd ab",
                "ab cd",
                "ab cd ab cd",
                "ab ab"
            };
            var note = "cd ab ab z";

            var resultNumbers = Note.IsFromJournal(journals, note);
            
            CollectionAssert.AreEquivalent(Array.Empty<int>(), resultNumbers);
        }
    }
}
