using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //Вернуть true, если строка соответствует паттерну 
    public class Task290
    {
        public static bool WordPattern(string pattern, string s)
        {
            var arr = s.Split(' ');
            if (arr.Length != pattern.Length)
            {
                return false;
            }

            var mapStr = new Dictionary<string, int>();
            var mapChar = new int[26];
            for (var i = 0; i < pattern.Length; i++)
            {
                if (mapChar[pattern[i]-'a'] != mapStr.GetValueOrDefault(arr[i], 0))
                {
                    return false;
                }

                // можно не делать мапу друг на друга, а присвоить некоторый уникальный символ замапленным значениям
                // например i+1 (чтоб считать 0 за отсутствие)
                mapChar[pattern[i]-'a'] = i + 1;
                mapStr[arr[i]] = i + 1;

            }

            return true;
        }
    }
}
