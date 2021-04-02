using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // есть массив уникальных чисел (arr) и массив массивов уникальных чисел. 
    // Можно ли сформировать arr соединяя pieces? 1 <= pieces.length <= arr.length <= 100
    //sum(pieces[i].length) == arr.length, 1 <= pieces[i].length <= arr.length, 1 <= arr[i], pieces[i][j] <= 100
    public class Task1640
    {
        public static bool CanFormArray(int[] arr, int[][] pieces)
        {
            int i = 0;
            while (i < arr.Length)
            {
                int found = -1;
                for (int p = 0; p < pieces.Length; p++)
                {
                    if (pieces[p][0] == arr[i])
                    {
                        found = p;
                        break;
                    }
                }

                if (found == -1)
                {
                    return false;
                }

                for (int j = 0; j < pieces[found].Length; j++)
                {
                    if (pieces[found][j] != arr[i++])
                    {
                        return false;
                    }
                }
            }


            return true;
        }

        public static bool CanFormArray_Map(int[] arr, int[][] pieces)
        {
            //первое число - индекс
            var map = new Dictionary<int, int>();
            for (int i = 0; i < pieces.Length; i++)
            {
                map[pieces[i][0]] = i;
            }

            for (int i = 0; i < arr.Length;)
            {
                if (!map.TryGetValue(arr[i], out int p))
                {
                    return false;
                }

                for (int j = 0; j < pieces[p].Length; j++)
                {
                    if (arr[i++] != pieces[p][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        
        public static bool CanFormArray_Map2(int[] arr, int[][] pieces)
        {
            //первое число - индекс
            var map = new int [101];
            for (int i = 0; i < pieces.Length; i++)
            {
                map[pieces[i][0]] = i + 1;
            }

            for (int i = 0; i < arr.Length;)
            {
                var p = map[arr[i]] - 1;
                if (p == -1)
                {
                    return false;
                }

                for (int j = 0; j < pieces[p].Length; j++)
                {
                    if (arr[i++] != pieces[p][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
