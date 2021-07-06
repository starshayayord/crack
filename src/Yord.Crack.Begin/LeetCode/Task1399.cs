namespace Yord.Crack.Begin.LeetCode
{
    //1 <= n <= 10^4
    public class Task1399
    {
        public static int CountLargestGroup(int n)
        {
            var groups = new int [28];
            var maxSize = 0;
            var maxGroupsCount = 0;
            for (var i = 1; i <= n; i++)
            {
                var sum = GetDigitSum(i);
                groups[sum]++;
                var groupSize = groups[sum];
                if (groupSize == maxSize)
                {
                    maxGroupsCount++;
                    continue;
                }
                if (groupSize > maxSize)
                {
                    maxSize = groupSize;
                    maxGroupsCount = 1;
                }
            }

            return maxGroupsCount;
        }

        private static int GetDigitSum(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }
    }
}
