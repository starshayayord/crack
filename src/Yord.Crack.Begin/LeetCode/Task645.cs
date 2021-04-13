namespace Yord.Crack.Begin.LeetCode
{
    // Масси должен содержать номера от 1 до N. Но одно число задудлировалось. 
    // Вернуть повторяющееся число и верное число
    public class Task645
    {
        public static int[] FindErrorNums(int[] nums)
        {
            int repeated = 0;
            int expectedSum = 0;
            int actualSum = 0;
            var map = new bool [10000 + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                if (map[nums[i]])
                {
                    repeated = nums[i];
                }

                expectedSum += i + 1;
                actualSum += nums[i];
                map[nums[i]] = true;
            }

            //(expectedSum+repeated) - это actualSum (в ней уже есть повтор) + искомый номер, который пропущен
            //(expectedSum+repeated) = actualSum + expectedNumber => 
            //expectedNumber = expectedSum+repeated - actualSum
            return new[] {repeated, expectedSum + repeated - actualSum};
        }
    }
}
