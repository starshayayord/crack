using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //Сбалансированная строка имеет одинаковое кол-во L и R.
    //Из исходной строки получить максимальное кол-во сбалансированных.
    //RLRRLLRLRL =>"RL", "RRLL", "RL", "RL" (4)
    //RLLLLRRRLR => "RL", "LLLRRR", "LR" (3)
    //LLLLRRRR => LLLLRRRR (1)
    //RLRRRLLRLL => "RL", "RRRLLRLL" (2)
    //
    public class Task1221
    {
        public static int BalancedStringSplit(string s)
        {
            int b = 0;
            int r = 0;
            foreach (char c in s)
            {
                if (c == 'L') b--;
                else b++;
                if (b == 0)
                {
                    r++;
                }
            }

            return r;
        }

        public static int BalancedStringSplit_Stack(string s)
        {
            Stack<char> stack = new Stack<char>();
            int r = 0;
            foreach (char c in s)
            {
                // если стек пуст - значит ничего еще не положили (начало).
                // Если символ сверху тот же, что сейчас - добавим текущий в стек
                if (!stack.Any() || stack.Peek() == c)
                {
                    stack.Push(c);
                }
                // Если символ сверху другой, то мы сбалансировали его текущим. Убираем пару из стека
                else
                {
                    stack.Pop();
                }

                // Если после этого стек опустел, то произошла балансировка, результат++
                if (!stack.Any()) r++;
            }

            return r;
        }
    }
}
