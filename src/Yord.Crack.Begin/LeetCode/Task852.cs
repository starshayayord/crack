namespace Yord.Crack.Begin.LeetCode
{
    // дана карта высот, вернуть индекс пика, т.е.
    //arr[0] < arr[1] < ... arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
    public class Task852
    {
        public static int PeakIndexInMountainArrayN(int[] arr)
        {
            var i = 0;
            for (; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    break;
                }
            }

            return i;
        }

        public static int PeakIndexInMountainArray(int[] arr)
        {
            var l = 0;
            var h = arr.Length - 1;
            while (l < h)
            {
                var m = l + (h - l) / 2;
                if (arr[m] < arr[m + 1])
                {
                    l = m + 1;
                }
                else
                {
                    h = m;
                }
            }

            return l;
        }
    }
}
