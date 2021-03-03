using System;

namespace Yord.Crack.Begin.LeetCode
{
    //Вернуть максимальную глубину вложенности
    public class Task1614
    {
        public  static int MaxDepth(string s)
        {

            int depth = 0;
            int max = 0;
            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        max = Math.Max(++depth, max);
                        break;
                    case ')':
                        depth--;
                        break;
                }
            }

            return max;
        }
    }
}
