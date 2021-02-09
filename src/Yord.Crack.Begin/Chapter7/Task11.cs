using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter7
{
    // Файловая система, хранящаяся в оперативной памяти.
    public class Task11
    {
        public class File : Entry
        {
            private string _content;

            public File(string name, Directory parent, string content = null) : base(name, parent)
            {
                _content = content;
            }

            public string GetContent => _content;

            public void SetContent(string content)
            {
                _content = content;
            }
            public override int Size => _content?.Length ?? 0;
        }

        // Папка. Может содержать файлы и другие папки
        public class Directory : Entry
        {
            protected List<Entry> _contents;

            public Directory(string name, Directory parent) : base(name, parent)
            {
                _contents = new List<Entry>();
            }

            public override int Size => _contents.Sum(c => c.Size);

            public int NumberOfFiles()
            {
                var numberOfFiles = 0;
                foreach (var content in _contents)
                {
                    if (content is Directory directory)
                    {
                        numberOfFiles += directory.NumberOfFiles();
                    }
                    numberOfFiles++;// каталог - тоже файл
                }

                return numberOfFiles;
            }

            public bool DeleteEntry(Entry e)
            {
                return _contents.Remove(e);
            }

            public void AddEntry(Entry e)
            {
                if (e.ParentDirectory != this)
                {
                    e.SetParent(this);
                    _contents.Add(e);
                }
            }

            public List<Entry> Contents => _contents;
        }

        // Общие характеристики файлов и папок
        public abstract class Entry
        {
            protected Directory Parent;
            protected long Created;
            protected long LastUpdated;
            protected long LastAccess;
            protected string Name;

            public Entry(string name, Directory parent)
            {
                Name = name;
                var date = DateTime.UtcNow.Ticks;
                Created = date;
                LastUpdated = date;
                LastAccess = date;
                parent?.AddEntry(this);
            }

            public bool Delete()
            {
                return Parent != null && Parent.DeleteEntry(this);
            }

            public abstract int Size { get; }

            public string GetFullPath()
            {
                if (Parent == null)
                {
                    return Name;
                }

                return Parent.GetFullPath() + "/" + Name;
            }

            public DateTime CreatedAt
            {
                get => new DateTime(Created);
                set => Created = value.Ticks;
            }
            
            public DateTime UpdatedAt
            {
                get => new DateTime(LastUpdated);
                set => LastUpdated = value.Ticks;
            }
            
            public DateTime AccessAt
            {
                get => new DateTime(LastAccess);
                set => LastAccess = value.Ticks;
            }

            public void SetParent(Directory parent)
            {
                Parent = parent;
            }

            public Directory ParentDirectory => Parent;

            public string GetName => Name;
        }
    }
}
