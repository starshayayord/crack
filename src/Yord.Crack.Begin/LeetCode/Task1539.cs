namespace Yord.Crack.Begin.LeetCode
{
    // найти kый пропущенный номер в массиве неубывающих положительных чисел, 1 <= arr.length <= 1000
    public class Task1539
    {
        public static int FindKthPositive2(int[] arr, int k)
        {
            int expected = 1;
            int skip = 0;
            int index = 0;
            while (skip < k && index < arr.Length)
            {
                if (expected == arr[index])
                {
                    index++;
                }
                else
                {
                    skip++;
                }

                expected++;
            }

            // expected- ожидаемый на этом месте номер.
            // (k - skip) - сколько еще осталось пропустить или лишнего пропущено

            return expected + (k - skip) - 1;
        }

        public static int FindKthPositiveBs(int[] arr, int k)
        {
            // ищем самый левый индекс, где кол-во пропущенных числа больше k, (или arr.Length, если такого нет)
            // т.к. кол-во пропущенных для i равно A[i] - i - 1.
            
            var l = 0;
            int r = arr.Length;
            while (l < r)
            {
                int m = l + r / 2;
                //-1, т.к. кол-во пропущенных равно номер-1, т.е. для 3 - это 1 и 2, т.е. 3-1
                if (arr[m] - m - 1 <= k)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            //на индексе l имеется arr[l] - l -1 пропущенных, результат= arr[l]-((arr[l]-(l+1))-k+1)=l+k;  т.е. 
            //число[большее, чем надо] - (сколько пропустили для него - сколько нужно было проустить [если найти 5ый, то пропустить надо было 4])
            //число[большее, чем надо] - сколько лишнего пропустили
            return l + k;
        }

        public static int FindKthPositive(int[] arr, int k)
        {
            var skip = arr[0] - 1;
            var prev = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (skip < k)
                {
                    skip += arr[i] - prev - 1;
                    prev = arr[i];
                }
                else
                {
                    break;
                }
            }

            //дошли до конца
            if (skip < k)
            {
                for (int i = skip; i < k; i++)
                {
                    prev++;
                }
            } // пропустили больше
            else
            {
                for (int i = skip; i >= k; i--)
                {
                    prev--;
                }
            }

            return prev;
        }
    }
}
