using System.Collections.Generic;
using System.Text;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task804
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            string[] morse = new[]
            {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
                ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };
            HashSet<string> set = new HashSet<string>();
            StringBuilder sb = new StringBuilder();
            for (int i =0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    sb.Append(morse[words[i][j] - 'a']);
                }

                set.Add(sb.ToString());
                sb.Clear();
            }

            return set.Count;
            
        }

        public static int UniqueMorseRepresentations_Map(string[] words)
        {
            Dictionary<char, string> morseMap = new Dictionary<char, string>
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."}
            };
            HashSet<string> set = new HashSet<string>();
            foreach (var word in words)
            {
                var sb = new StringBuilder();
                foreach (var c in word)
                {
                    sb.Append(morseMap[c]);
;                }

                set.Add(sb.ToString());
            }

            return set.Count;
        }
    }
}
