using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть самое длинное слово, которое мб построено из добавлением одного символа из предыдущих слов
    //если вариантов несколько, вернуть первый лексикографически
    public class Task720
    {
        private class TrieNode
        {
            public string Word = "";
            public TrieNode[] Children = new TrieNode[26];

            public void Insert(string s)
            {
                var curNode = this;
                foreach (var c in s)
                {
                    curNode.Children[c - 'a'] ??= new TrieNode();
                    curNode = curNode.Children[c - 'a'];
                }

                curNode.Word = s;
            }
        }

        public static string LongestWord_Dfs(string[] words)
        {
            var root = new TrieNode();
            foreach (var word in words)
            {
                root.Insert(word);
            }

            return Dfs(root);
        }

        private static string Dfs(TrieNode node)
        {
            var res = node.Word;
            foreach (var child in node.Children)
            {
                if (child != null && child.Word.Length != 0)
                {
                    var childWord = Dfs(child);
                    if (childWord.Length > res.Length ||
                        (childWord.Length == res.Length && string.Compare(res, childWord) > 0))
                    {
                        res = childWord;
                    }
                }
            }

            return res;

        }
        
        public static string LongestWord_Sort(string[] words)
        {
            Array.Sort(words);
            var r = string.Empty;
            var s = new HashSet<string>();
            foreach (var word in words)
            {
                if (word.Length == 1
                    || s.Contains(word.Substring(0, word.Length - 1)))
                {
                    if ( r.Length < word.Length)
                    {
                        r = word;
                    }

                    s.Add(word);
                }
            }

            return r;
        }

        public static string LongestWord(string[] words)
        {
            var s = words.ToHashSet();
            var r = string.Empty;
            foreach (var word in words)
            {
                if (word.Length < r.Length)
                {
                    continue;
                }

                var ok = true;
                for (int i = 1; i < word.Length; i++)
                {
                    if (!s.Contains(word.Substring(0, i)))
                    {
                        ok = false;
                        break;
                    }
                }

                if (!ok) continue;
                if (r.Length < word.Length || r.Length == word.Length && string.Compare(r, word) == 1)
                {
                    r = word;
                }
            }

            return r;
        }
    }
}
