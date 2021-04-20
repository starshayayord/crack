namespace Yord.Crack.Begin.LeetCode
{
    //вернуть кол-во уникальных символов  переставить уникальные подряд в исходном отсортированном массиве
    //[0,0,1,1,1,2,2,3,3,4] =>5 уникальных, nums = [0,1,2,3,4,...(2,2,3,3,4)]
    //
    public class Task26
    {
        public static int RemoveDuplicates(int[] nums) {
            int r = nums.Length==0? 0 : 1;
            var j = 1;
            for(var i=1; i< nums.Length;i++)
            {
                if (nums[i-1]!=nums[i])
                {
                    r++;
                    nums[j++]=nums[i];
                }
            
            }
            return r;
        }
    }
}
