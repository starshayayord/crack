using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть макс элементы сумма которых больше, чем сумма оставшихся
    //1 <= nums[i] <= 100
    public class Task1403
    {
        public static IList<int> MinSubsequence(int[] nums)
        {
            var max = 100;
            var freq = new int[max + 1];
            var sum = 0;
            foreach (var n in nums)
            {
                freq[n]++;
                sum += n;
            }

            var r = new List<int>();
            var curSum = 0;
            for (var i = max; i > 0;)
            {
                if (freq[i] == 0)
                {
                    i--;
                    continue;
                }

                r.Add(i);
                curSum += i;
                if (sum - curSum < curSum)
                {
                    break;
                }

                freq[i]--;
            }

            return r;
        }
    }
}
