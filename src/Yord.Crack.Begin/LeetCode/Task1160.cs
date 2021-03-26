using System;

namespace Yord.Crack.Begin.LeetCode
{
    // выдать сумму длин слов, которые мб составлены из символов
    public class Task1160
    {
        public  static int CountCharacters(string[] words, string chars)
        {
            int[] charMap = new int [26];
            for (int i = 0; i < chars.Length; i++)
            {
                charMap[chars[i] - 'a']++;
            }
            int r = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int[] charMapCp = new int [26];
                Array.Copy(charMap, charMapCp, charMap.Length);
                bool match = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (--charMapCp[words[i][j] - 'a'] < 0)
                    {
                        match = false;
                        break;

                    }
                }

                if (match)
                {
                    r += words[i].Length;
                }
            }

            return r;
        }
    }
}
