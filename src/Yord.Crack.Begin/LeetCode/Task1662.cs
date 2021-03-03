namespace Yord.Crack.Begin.LeetCode
{
    //Проверить, представляет ли собой сумма строк одну и ту же строку.
    //word1 = ["ab", "c"], word2 = ["a", "bc"] => abc => true
    //word1 = ["a", "cb"], word2 = ["ab", "c"] => acb!=abc => false
    public class Task1662
    {
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {

            int w2i = 0;
            int w2j = 0;
            for (int w1i = 0; w1i < word1.Length; w1i++)
            {
                for (int w1j = 0; w1j < word1[w1i].Length; w1j++)
                {
                    if (w2j > word2[w2i].Length-1)
                    {
                        w2j=0;
                        w2i++;
                    }

                    if (w2i > word2.Length - 1 || word1[w1i][w1j] != word2[w2i][w2j])
                    {
                        return false;
                    }

                    w2j++;
                }
            }

            return w2i != word2.Length - 1 || w2j != word2[w2i].Length - 1;
        }
    }
}
