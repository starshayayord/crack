using System.Globalization;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть, отсортированы ли слова по алфавиту из order
    public class Task953
    {
        public static bool IsAlienSorted(string[] words, string order)
        {
            var map = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                map[order[i] - 'a'] = i;
            }

            for (int i = 1; i < words.Length; i++)
            {
                if (IsBigger(words[i - 1], words[i], map))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsBigger(string word1, string word2, int[] map)
        {
            for (int j = 0; j < word1.Length && j < word2.Length; j++)
            {
                if (word1[j] != word2[j])
                {
                    return map[word1[j] - 'a'] > map[word2[j] - 'a'];
                }
            }

            return word2.Length < word1.Length;
        }
    }
}
