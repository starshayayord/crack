using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yord.Crack.Begin.LeetCode
{
    //можно менять местами только четные или нечетные буквы в слове.
    //вернуть кол-во групп, которые становятся одинаковыми после этого
    public class Task893
    {
        public class State
        {
            public int[] Odd = new int[26];
            public int[] Even = new int[26];
        }

        public static int NumSpecialEquivGroups3(string[] words)
        {
            var groups = new HashSet<string>();
            foreach (var word in words)
            {
                var even = new int[26];
                var odd = new int[26];
                for (int i = 0; i < word.Length; i += 2)
                {
                    even[word[i] - 'a']++;
                }

                for (int i = 1; i < word.Length; i += 2)
                {
                    odd[word[i] - 'a']++;
                }

                
                groups.Add($"{new string(even.Select(x => (char)x).ToArray())}{new string(odd.Select(x => (char)x).ToArray())}");
            }

            return groups.Count;
        }
        
        public static int NumSpecialEquivGroups2(string[] words)
        {
            var groups = new HashSet<string>();
            var sbEven = new StringBuilder();
            var sbOdd = new StringBuilder();
            foreach (var word in words)
            {
                sbEven.Clear();
                sbOdd.Clear();
                for (int i = 0; i < word.Length; i += 2)
                {
                    sbEven.Append(word[i]);
                }

                for (int i = 1; i < word.Length; i += 2)
                {
                    sbOdd.Append(word[i]);
                }

                var e = sbEven.ToString().ToCharArray();
                var o = sbOdd.ToString().ToCharArray();
                Array.Sort(e);
                Array.Sort(o);
                groups.Add($"{new string(e)}{new string(o)}");
            }

            return groups.Count;
        }

        public static int NumSpecialEquivGroups(string[] words)
        {
            var s = new State[words.Length];
            for (var i = 0; i < words.Length; i++)
            {
                s[i] = new State();
                for (var j = 0; j < words[0].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        s[i].Even[words[i][j] - 'a']++;
                    }
                    else
                    {
                        s[i].Odd[words[i][j] - 'a']++;
                    }
                }
            }

            var r = 0;
            var alreadyChecked = new HashSet<int>();
            for (var i = 0; i < words.Length; i++)
            {
                if (alreadyChecked.Contains(i))
                {
                    continue;
                }

                for (var j = i + 1; j < words.Length; j++)
                {
                    var equal = true;
                    for (int b = 0; b < 26; b++)
                    {
                        if (s[i].Even[b] != s[j].Even[b] || s[i].Odd[b] != s[j].Odd[b])
                        {
                            equal = false;
                            break;
                        }
                    }

                    if (equal)
                    {
                        alreadyChecked.Add(j);
                    }
                }

                r++;
            }

            return r;
        }
    }
}
