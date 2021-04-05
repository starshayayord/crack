namespace Yord.Crack.Begin.LeetCode
{
    //вернуть длину самого длинного палиндрома из строки
    public class Task409
    {
        public static int LongestPalindrome(string s)
        {
            var map = new int[128];
            int r = 0;
            for (int i = 0; i < s.Length; i++)
            {
                map[s[i]]++;
                if ((map[s[i]] & 1) == 0)
                {
                    r += 2;
                }
            }

            return s.Length > r ? r + 1 : r;
        }
    }
}
