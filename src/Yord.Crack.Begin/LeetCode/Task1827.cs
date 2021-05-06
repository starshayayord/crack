namespace Yord.Crack.Begin.LeetCode
{
    // можно инкрементить эл-т на 1. вернуть кол-во операций, чтоб сделать массив возврастающим
    //1 <= nums[i] <= 104
    public class Task1827
    {
        public static int MinOperations(int[] nums)
        {
            var r = 0;
            for (var i = 0; i < nums.Length -1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    continue;
                }
                var diff = nums[i] - nums[i + 1] + 1;
                r += diff;
                nums[i + 1] += diff;
            }

            return r;
        }
    }
}
