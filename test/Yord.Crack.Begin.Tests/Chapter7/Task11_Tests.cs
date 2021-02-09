using NUnit.Framework;
using Yord.Crack.Begin.Chapter7;

namespace Yord.Crack.Begin.Tests.Chapter7
{
    [TestFixture]
    public class Task11_Tests
    {
        [Test]
        public void Should_UseFileSystem()
        {
            const string content = "this is a test content";
            var root = new Task11.Directory("root", null);
            var subDir =  new Task11.Directory("sub1", root);
            
            Assert.AreEqual(1, root.NumberOfFiles());
            Assert.AreEqual(0, root.Size);

            var file = new Task11.File("file1", subDir, content);
            subDir.AddEntry(file);
            
            Assert.AreEqual(2, root.NumberOfFiles());
            Assert.AreEqual(content.Length, root.Size);
            Assert.AreEqual($"{root.GetName}/{subDir.GetName}/{file.GetName}", file.GetFullPath());
            
        }
    }
}
