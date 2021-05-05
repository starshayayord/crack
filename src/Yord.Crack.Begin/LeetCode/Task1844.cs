namespace Yord.Crack.Begin.LeetCode
{
    public class Task1844
    {
        public static string ReplaceDigits(string s)
        {
            var a = s.ToCharArray();
            for (int i = 0; i < a.Length - 1; i += 2)
            {
                a[i + 1] = (char) (a[i] + a[i+1] - '0');
            }

            return new string(a);
        }
    }
}
