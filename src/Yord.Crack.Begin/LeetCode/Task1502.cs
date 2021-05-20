using System;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1502
    {
        public static bool CanMakeArithmeticProgressionN(int[] arr)
        {
            var min = int.MaxValue;
            var max = int.MinValue;
            foreach (var n in arr)
            {
                min = Math.Min(min, n);
                max = Math.Max(max, n);
            }

            var gap = max - min;
            if (gap % (arr.Length - 1) != 0) return false;
            var diff = gap / (arr.Length - 1);

            var i = 0;
            while (i< arr.Length)
            {
                if (arr[i] == min + i * diff) i++; //нашли место в последовательности, переходим к следующему элементу
                // если разница между минимумом и элементом не делится нацело на дифф
                else if ((arr[i] - min) % diff != 0) return false;
                else//поход на эл-т последовательности не на своем месте
                {
                    //ищем реальную позицию и свапаем
                    var pos = (arr[i] - min) / diff;
                    //если его нельзя вставить в текущую последоватльность, то выходим. Иначе - свапаем
                    if (arr[pos] == arr[i]) return false;
                    var t = arr[i];
                    arr[i] = arr[pos];
                    arr[pos] = t;
                }
            }

            return true;
        }
        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            var diff = arr[1] - arr[0];
            for (var i = 1; i < arr.Length-1; i++)
            {
                if (arr[i + 1] - arr[i] != diff)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
