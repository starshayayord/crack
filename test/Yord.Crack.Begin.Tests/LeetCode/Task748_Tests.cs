using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task748_Tests
    {
        [Test]
        public void Should_ShortestCompletingWord()
        {
            Assert.AreEqual("steps",
                Task748.ShortestCompletingWord("1s3 PSt", new[] {"step", "steps", "stripe", "stepple"}));
            Assert.AreEqual("pest", Task748.ShortestCompletingWord("1s3 456", new[] {"looks", "pest", "stew", "show"}));
            Assert.AreEqual("husband",
                Task748.ShortestCompletingWord("Ah71752",
                    new[]
                    {
                        "suggest", "letter", "of", "husband", "easy", "education", "drug", "prevent", "writer", "old"
                    }));
            Assert.AreEqual("enough",
                Task748.ShortestCompletingWord("OgEu755",
                    new[] {"enough", "these", "play", "wide", "wonder", "box", "arrive", "money", "tax", "thus"}));
            Assert.AreEqual("simple",
                Task748.ShortestCompletingWord("iMSlpe4",
                    new[]
                    {
                        "claim", "consumer", "student", "camera", "public", "never", "wonder", "simple", "thought",
                        "use"
                    }));
        }

        [Test]
        public void Should_ShortestCompletingWord_Math()
        {
            Assert.AreEqual("present",
                Task748.ShortestCompletingWord_Math("tR28607",
                    new[]
                    {
                        "present", "fall", "make", "change", "everything", "performance", "owner", "beat", "name",
                        "serve"
                    }));
            Assert.AreEqual("steps",
                Task748.ShortestCompletingWord_Math("1s3 PSt", new[] {"step", "steps", "stripe", "stepple"}));
            Assert.AreEqual("pest",
                Task748.ShortestCompletingWord_Math("1s3 456", new[] {"looks", "pest", "stew", "show"}));
            Assert.AreEqual("husband",
                Task748.ShortestCompletingWord_Math("Ah71752",
                    new[]
                    {
                        "suggest", "letter", "of", "husband", "easy", "education", "drug", "prevent", "writer", "old"
                    }));
            Assert.AreEqual("enough",
                Task748.ShortestCompletingWord_Math("OgEu755",
                    new[] {"enough", "these", "play", "wide", "wonder", "box", "arrive", "money", "tax", "thus"}));
            Assert.AreEqual("simple",
                Task748.ShortestCompletingWord_Math("iMSlpe4",
                    new[]
                    {
                        "claim", "consumer", "student", "camera", "public", "never", "wonder", "simple", "thought",
                        "use"
                    }));
        }
    }
}
