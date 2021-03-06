using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // отсортировать по кол-ву единиц в бинарной отображении. Если одинаковое, то по убыванию десятичного
    //1 <= arr.length <= 500
    //0 <= arr[i] <= 10^4
    public class Task1356
    {
        public static int[] SortByBits3(int[] arr)
        {
            var res = new int[arr.Length];
            //наибольшее число 10000, значит берем на 1 больше и умножим на кол-во единиц
            //добавим исходное число, что было, из чего восстановить + отсортировать числа с одинаковым кол-вом 1
            for (int i = 0; i < arr.Length; i++) {
                res[i] = Count1(arr[i])*10001 + arr[i];
            }
            //отсортируем полученный массив
            Array.Sort(res);
            //восстановим его
            for (int i = 0; i < arr.Length; i++) {
                res[i] %= 10001;
            }
        
            return res;
        }
        
        //макс число - 10^4. Число единиц более значимое, потом отсортируем по самому числа.
        //Представим число как число единиц*10000 + arr[i]
        public static int[] SortByBits2(int[] arr)
        {
            return arr.OrderBy(Count1).ToArray();
        }
        
        public static int[] SortByBits(int[] arr)
        {
            var map = new List<int>[15];
            var res = new List<int>();
            foreach (var n in arr)
            {
                var c = Count1(n);
                if (map[c] == null)
                {
                    map[c] = new List<int> {n};
                }
                else
                {
                    map[c].Add(n);
                }
            }

            foreach (var l in map)
            {
                if (l == null)
                {
                    continue;
                }

                l.Sort();
                res.AddRange(l);
            }

            return res.ToArray();
        }

        private static int Count1(int n)
        {
            var c = 0;
            while (n > 0)
            {
                if ((n & 1) != 0)
                {
                    c++;
                }

                n >>= 1;
            }

            return c;
        }
    }
}
