using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //последовательно удалять рядомстоящие двойки, пока это возможно
    public class Task1047
    {
        public static string RemoveDuplicatesStack(string s)
        {
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!stack.Any() || stack.Peek() != s[i])
                {
                    stack.Push(s[i]);
                }
                else
                {
                    stack.Pop();
                }
            }

            var chars = new char[stack.Count];
            for (var i = stack.Count - 1; i >= 0; i--)
            {
                chars[i] = stack.Pop();
            }

            return new string(chars);
        }

        //abbaca
        public static string RemoveDuplicates(string s)
        {
            int curIdx = 0;
            var chars = s.ToCharArray();
            foreach (var c in chars)
            {
                //если дубликатов не было, то работаем впустую.
                //если были, то на место первого из двух дубликатов встанет текущий символ
                chars[curIdx] = c;
                //если текущий символ и предыдущий от текущего индекса - дубликаты,
                //то откатываем текущий индекс на первый из дубликатов
                if (curIdx > 0 && chars[curIdx - 1] == c)
                {
                    curIdx--;
                }
                //если не дубликаты или находимся в самом начале, то смещаем текущий индекс
                else
                {
                    curIdx++;
                }
            }

            return new string(chars, 0, curIdx);
        }
    }
}
