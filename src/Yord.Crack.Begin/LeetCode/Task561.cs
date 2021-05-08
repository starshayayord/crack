using System;

namespace Yord.Crack.Begin.LeetCode
{
    // поделить на пары так, чтоб сумма минимальных чисел из пар была максимульной. вернуть сумму
    // 1 <= n <= 10000, -10000 <=nums[i]<=10000
    //nLog(n)
    public class Task561
    {
        public static int ArrayPairSum(int[] nums) 
        {
            Array.Sort(nums);
            var r = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                r += nums[i];
            }

            return r;
        }
        
        //O(n)
        public static int ArrayPairSum2(int[] nums) 
        {
            var exist = new int[20001];
            // по сути мы сортируем массив, т.к. инткрементим кол-во у чисел, индекс которых равен числу из массива
            // -10000 <=nums[i]<=10000, так что массив на 20001
            for (int i = 0; i < nums.Length; i ++)
            {
                exist[nums[i] + 10000]++;
            }
            var r = 0;
            var odd = true;
            //а затем складываем 1ое, 3е, 5ое числа.. т.к. они будут минимальными из пар
            for (int i = 0; i < exist.Length; i++)
            {
                while (exist[i]>0)
                {
                    if (odd)
                    {
                        r += i - 1000;
                    }

                    odd = !odd;
                    exist[i]--;
                }
            }

            return r;
        }
    }
}
