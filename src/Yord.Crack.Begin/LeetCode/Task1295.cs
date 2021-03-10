using System;
using System.Linq;
namespace Yord.Crack.Begin.LeetCode
{
    // вернуть кол-во чисел с четным кол-вом цифр (1 <= nums[i] <= 10^5)
    public class Task1295
    {
        public static int FindNumbers(int[] nums)
        {
            return nums.Count(n => n.ToString().Length % 2 == 0);
        }
        
        public static int FindNumbers_Constraints(int[] nums)
        {
            return nums.Count(n => n>9 && n<100 || n>999 && n<10000 || n==100000);
        }

        //Log10(1..9) =>0; Log10(10...99) = 1;... Log(100..999) = 2
        // Если логарифм нечетный, то нечетный, то четное кол-во цифр. Иначе - нечетное
        public static int FindNumbers_Log(int[] nums)
        {
            return nums.Count(n => ((int) Math.Log10(n) & 1) == 1);
        }
    }
}
