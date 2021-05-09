namespace Yord.Crack.Begin.LeetCode
{
    //развернуть слова в строке
    public class Task557
    {
        public static string ReverseWords(string s)
        {
            var res = s.ToCharArray();
            var l = 0;
            for (int i = 0; i < res.Length; i++)
            {
                int r;
                if (res[i] == ' ')
                {
                    r = i - 1;
                }
                else if (i == res.Length - 1)
                {
                    r = i;
                }
                else
                {
                    continue;
                }

                for (; l < r; l++, r--)
                {
                    var t = res[l];
                    res[l] = res[r];
                    res[r] = t;
                }

                l = i + 1;
            }

            return new string(res);
        }
    }
}
