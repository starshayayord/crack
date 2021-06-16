namespace Yord.Crack.Begin.LeetCode
{
    //a-0, b-1...j-9; каждая строка преставляет собой число acb - 021 (21)
    //true, если firstWord+secondWord=targetWord
    public class Task1880
    {
        public static bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            return GetConcatValue(firstWord) + GetConcatValue(secondWord) == GetConcatValue(targetWord);
        }

        private static int GetConcatValue(string word)
        {
            //return word.Aggregate(0, (current, t) => current * 10 + (t - 'a'));
            var result = 0;
            foreach (var t in word)
            {
                result = result * 10 + (t - 'a');
            }

            return result;
        }
    }
}
