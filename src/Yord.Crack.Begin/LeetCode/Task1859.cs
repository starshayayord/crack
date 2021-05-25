using System.Collections.Generic;
using System.Text;

namespace Yord.Crack.Begin.LeetCode
{
    //2 <= s.length <= 200 вернуть отсортированную строку
    public class Task1859
    {
        public static string SortSentence2(string s) {
            var words = s.Split(" "); 
            var ans = new string[words.Length];
            foreach (var word in words) {
                var i = word.Length - 1;
                ans[word[i] - '1'] = word.Substring(0, i);
            }
            return string.Join(" ", ans);
        }
        
        public static string SortSentence(string s)
        {
            var map = new Dictionary<char, string>();
            var start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    map[s[i - 1]] = s.Substring(start, i - start - 1);
                    start = i + 1;
                }
                else if (i == s.Length - 1)
                {
                    map[s[i]] = s.Substring(start, i - start);
                }
            }

            var sb = new StringBuilder();
            for (int i = 1; i <= map.Count; i++)
            {
                sb.Append($"{map[(char) (i + '0')]}" + (i == map.Count ? "": " "));
            }
            return sb.ToString();
        }
    }
}
