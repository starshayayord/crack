namespace Yord.Crack.Begin.LeetCode
{
    // Взять самый маленький символ, добавить к результату, взять следующий самый маленький...
    // Взять самый большой, добавить к результату, взять самый большой из оставшихся...
    // Повторять предыдщие шаги, пока символы не закончатся.
    public class Task1370
    {
        public static string SortString(string s)
        {
            char[] r = new char[s.Length];
            int[] map = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                map[s[i] - 'a']++;
            }

            int j = 0;
            while (j < s.Length)
            {
                for (int i = 0; i < map.Length; i++)
                {
                    if (map[i] > 0)
                    {
                        r[j++] = (char) (i + 'a');
                        map[i]--;
                    }
                }

                for (int i = map.Length - 1; i >= 0; i--)
                {
                    if (map[i] > 0)
                    {
                        r[j++] = (char) (i + 'a');
                        map[i]--;
                    }
                }
            }

            return new string(r);
        }
    }
}
