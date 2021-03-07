namespace Yord.Crack.Begin.LeetCode
{
    // сделать функцию ToLower
    public class Task709
    {
        public static string ToLowerCase(string str)
        {
            char[] s = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    s[i] = (char) (str[i] + ('a'- 'A'));
                }
                else
                {
                    s[i] = str[i];
                }
            }

            return new string(s);
        }
    }
}
