using System;

namespace Yord.Crack.Begin.Chapter8
{
    // Определить волшебный индекс для массива (arr[i] = i).
    // Массив отсортирован и состоиз из уникальных элементов
    public class Task3
    {
        public static int? FindMagicIndex(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (arr[mid] == mid)
                {
                    return mid;
                }

                if (arr[mid] > mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return null;
        }

        // Если элементы повторяются (в этом случае нельзя понять, слева или справа волшебный индекс).
        // -10    -5    2    2    2    3    4    7    9    12    13
        //  0      1    2    3    4    5    6    7    8    9     10
        // Берем A[5]=3. Т.к. A[mid] < mid. Волшебный элемент находится слева или справа.
        // Если он слева, то он не где угодно слева, т.к.
        // чтобы A[4] был вошлебным, надо, чтоб его значение было равно 4. А оно мб только <=3 
        // Значит волшебный индекс лежит от 0 до Min(mid-1, A[mid]) - индекс не мб больше, чем значение
        // Если он справа, то он от [Max(A[mid], mid +1), a.Length-1] - индекс не мб меньше, чем значение
        public static int? FindMagicIndexWithRepeats(int[] arr)
        {
            return FindMagicIndexWithRepeats(arr, 0, arr.Length - 1);
        }

        private static int? FindMagicIndexWithRepeats(int[] arr, int l, int r)
        {
            while (l <= r)
            {
                var mid = (l + r) / 2;
                if (arr[mid] == mid)
                {
                    return mid;
                }

                return FindMagicIndexWithRepeats(arr, l, Math.Min(arr[mid], mid - 1)) ??
                       FindMagicIndexWithRepeats(arr, Math.Max(arr[mid], mid + 1), r);
            }

            return null;
        }

        public static int? FindMagicIndexWithRepeatsIter(int[] arr)
        {
            var start = 0;
            var end = arr.Length - 1;
            var mid = (start + end) / 2;
            if (arr[mid] == mid)
            {
                return mid;
            }

            var r = Math.Max(arr[mid], mid + 1);
            var l = Math.Min(arr[mid], mid - 1);
            while (l >= start)
            {
                mid = (start + l) / 2;
                if (arr[l] == l)
                {
                    return l;
                }

                l = Math.Min(arr[mid], mid - 1);
            }

            while (r <= end)
            {
                mid = (r + end) / 2;
                if (arr[r] == r)
                {
                    return r;
                }

                r = Math.Max(arr[mid], mid + 1);
            }

            return null;
        }
    }
}
