namespace Yord.Crack.Begin.LeetCode
{
    //половина массива четная, половина нечетная. поставить четные на четные, а нечетные на нечетные
    public class Task922
    {
        public static int[] SortArrayByParityII(int[] nums)
        {
            var j = 1;
            for (int i = 0; i < nums.Length - 1 && j < nums.Length; i += 2)
            {
                if ((nums[i] & 1) == 0)
                {
                    continue; //четное, на месте
                }

                //ищем четное на нечетных местах
                for (; j < nums.Length; j += 2)
                {
                    if ((nums[j] & 1) == 0)
                    {
                        var t = nums[i];
                        nums[i] = nums[j];
                        nums[j] = t;
                        j += 2;
                        break;
                    }
                }
            }

            return nums;
        }

        public static int[] SortArrayByParityII2(int[] nums)
        {
            int i = 0, j = 1, n = nums.Length;
            while (i < n && j < n)
            {
                while (i < n && nums[i] % 2 == 0)
                {
                    //четное, на месте
                    i += 2;
                }

                while (j < n && nums[j] % 2 == 1)
                {
                    // нечетное, на месте
                    j += 2;
                }

                //если еще не дошли до конца и пришли сюда, значит меняем местами
                if (i < n && j < n)
                {
                    var t = nums[i];
                    nums[i] = nums[j];
                    nums[j] = t;
                }
            }

            return nums;
        }
    }
}
