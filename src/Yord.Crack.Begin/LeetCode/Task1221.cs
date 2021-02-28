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
    }
}
