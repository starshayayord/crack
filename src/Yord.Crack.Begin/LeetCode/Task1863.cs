using System;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть сумму XOR всех элементов для всех подмассивов, 1 <= nums.length <= 12
    public class Task1863
    {
        public int SubsetXORSum2(int[] nums)
        {
            var n = nums.Length;
            var bits = 0;
            //ищем все биты, которые могут быть установленны числами из массива
            for (var i = 0; i < n; i++)
            {
                bits |= nums[i];
            }

            //каждый бит даст 2^n-1,т.к.
            // пусть массив состоит из N элементов, и M из них имеют Iый бит
            // Чтоб получить подмассив с iым битом, надо, что кол-во элементов в этим битом было нечетным (иначе 0)
            // Значит кол-во вариантов выбора элементов без этого бита 2^(n-m), а с ним mC1 + mC3 + mC5 …. = 2^(m-1)
            //получается всего 2^(n-m+m-1)=2^(n-1).
            //если массиве число, в котором iый бит установлен, то все подмассивы будут давать 2^(n-1+i) от суммы
            return bits * (1 << n - 1); //(bits * 2*(n-1))
        }
        
        public static int SubsetXORSum(int[] nums)
        {
            var sum = 0;
            var n = (int)Math.Pow(2, nums.Length) - 1;
            while (n>0)
            {
                sum += SubsetXORSum(n, nums);
                n -= 1;
            }
            return sum;
        }

        private static int SubsetXORSum(int n, int[] nums)
        {
            var sum = 0;
            var i = 0;
            while (n>0)
            {
               if ((n & 1) > 0)
               {
                   sum ^= nums[i];
               }
               n >>= 1;
               i++;
            }

            return sum;
        }
    }
}
