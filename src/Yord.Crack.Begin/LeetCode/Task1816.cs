namespace Yord.Crack.Begin.LeetCode
{
    public class Task1816
    {
        public static string TruncateSentence(string s, int k)
        {
            for (var i = 0; i < s.Length; ++i) {
                if (s[i] == ' ' && --k==0) return s.Substring(0, i);
            }
            return s;
        }
    }
}
