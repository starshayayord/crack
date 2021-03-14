namespace Yord.Crack.Begin.LeetCode
{
    // Смерджить строки побуквенно, начиная с world1. Если строка длиннее, оставшиеся символы в конец строки
    public class Task1768
    {
        public static string MergeAlternately(string word1, string word2)
        {
            char[] r = new char[word1.Length + word2.Length];
            int j = 0;
            for (int i = 0; i < word1.Length || i < word2.Length; i++)
            {
                if (i < word1.Length)
                {
                    r[j] = word1[i];
                    j++;
                }

                if (i < word2.Length)
                {
                    r[j] = word2[i];
                    j++;
                }
            }

            return new string(r);
        }
    }
}
