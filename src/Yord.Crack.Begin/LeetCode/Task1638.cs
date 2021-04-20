namespace Yord.Crack.Begin.LeetCode
{
    // кол-во вариантов, сколькими можно изменить s (только 1 символ), чтоб получить подстроку из t
    public class Task1638
    {
        //выбираем стартовые точки в каждой строке и сравниваем с них символы
        public static int CountSubstrings3(string s, string t)
        {
            int res = 0;
            for (int i = 0; i < s.Length; ++i)
                res += CountSub(s, t, i, 0);
            //j=1, чтобы i=0, j=0 учесть только 1 раз
            for (int j = 1; j < t.Length; ++j)
                res += CountSub(s, t, 0, j);
            return res;
        }

        //cur - число одинаковых последовательных символов
        //pre - предыдущее число одинаковых последовательных символов
        private static int CountSub(string s, string t, int i, int j)
        {
            int res = 0, pre = 0, cur = 0;
            for (int n = s.Length, m = t.Length; i < n && j < m; ++i, ++j)
            {
                cur++; //на этой итерации мы прошли +1 символ
                //если символы различаются, то мы обновим pre.
                //если не совпадает 1 символ посередине, то результат = совпадающие слева+1+совпадающие слева
                //если не совпадает более 1 символа подряд, то мы скинем pre, т.е. pre=1
                if (s[i] != t[j])
                {
                    pre = cur;
                    cur = 0;
                }

                res += pre;
            }

            return res;
        }

        public static int CountSubstrings2(string s, string t)
        {
            int r = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < t.Length; j++)
                {
                    if (s[i] != t[j])
                    {
                        int left = 1;
                        int right = 1;

                        while (i - left >= 0 && j - left >= 0 && s[i - left] == t[j - left])
                        {
                            ++left;
                        }

                        while (i + right < s.Length && j + right < t.Length && s[i + right] == t[j + right])
                        {
                            ++right;
                        }

                        // сколькими способами к r символам "справа" можно дописать lсимволов слева
                        // пусть r=1, l=1. к r(1)символам справа можно дописать l симвлов слева только1 способом (т.е. этот же самый символ)
                        // 3 символа r=2, l=1. к r(2) можно дописать l(1)одним способом
                        r += left * right;
                    }
                }
            }

            return r;
        }

        public static int CountSubstrings(string s, string t)
        {
            var sLen = s.Length;
            var tLen = t.Length;
            //массивы на 1 больше, чтоб, i=1, j=1, чтоб можно было брать предыдущее значение, равное 0 на первом символе
            var same = new int[sLen + 1][]; // кол-во точно таких же подстрок, кончающихся на s[i] и t[j];
            var diff1 = new int[sLen + 1][]; // кол-во подстрок c 1 jnkbxf.obvcz cbvdjkjv, кончающихся на s[i] и t[j];
            for (int i = 0; i < same.Length; i++)
            {
                same[i] = new int[tLen + 1];
                diff1[i] = new int[tLen + 1];
            }

            var r = 0;
            // i=1, j=1, чтоб можно было брать предыдущее значение, равное 0 на первом символе
            for (var i = 1; i <= sLen; i++)
            {
                for (var j = 1; j <= tLen; j++)
                {
                    //символы совпали
                    if (s[i - 1] == t[j - 1])
                    {
                        //кол-во одинаковых подстрок, заканчивающихся на s[i]t[j]
                        same[i][j] = same[i - 1][j - 1] + 1;
                        //кол-во разных на 1 символ подстрок, заканчивающихся на s[i]t[j]
                        diff1[i][j] = diff1[i - 1][j - 1];
                    }
                    else
                    {
                        //same[i][j] = 0, т.е. если два диффа подряд, то длина начинает считаться с 0
                        //значит при больше одного диффа длина никогда не будет больше 1
                        diff1[i][j] = same[i - 1][j - 1] + 1;
                    }

                    r += diff1[i][j];
                }
            }

            return r;
        }
    }
}
