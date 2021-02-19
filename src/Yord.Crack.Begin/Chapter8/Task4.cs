using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter8
{
    //Вернуть все подмножества данного множества
    public class Task4
    {
        public static List<List<int>> GetAllSubsets(int[] arr)
        {
            var includeMask = (int)Math.Pow(2, arr.Length) -1;
            var subsets = new List<List<int>>();
            while (includeMask >=0)
            {
                var tempMask = includeMask;
                var i = 0;
                var subset = new List<int>();
                while (tempMask > 0)
                {
                    if ((tempMask & 1) == 1)
                    {
                        subset.Add(arr[i]);
                    }

                    tempMask >>= 1;
                    i++;
                }

                includeMask--;
                subsets.Add(subset);
            }

            return subsets;
        }

        public static List<List<int>> GetAllSubsetsRec(int[] arr)
        {
            return GetAllSubsets(arr.ToList(), 0);
        }

        // добавилили в решение пустое подмножество ->
        // добавили в пустое подмножество первый элемент, добавили в решение  ->
        // к пустому подсножеству добавили второй элемент, к подмножеству из первого - второй. Добавили в решение -> и т.д.
        private static List<List<int>> GetAllSubsets(List<int> subset, int index)
        {
            List<List<int>> allSubsets;
            if (subset.Count == index) //  базовый случай - пустое подможество
            {
                allSubsets = new List<List<int>>{new List<int>()};
            }
            else //  для непустого подмножества
            {
                // ищем все подмножества для следующего индекса (от index+1 до конца)
                allSubsets = GetAllSubsets(subset, index + 1);
                // а потом вставляем элемент subset[index] в каждое из получившихся подмножеств
                var item = subset[index]; 
                var moreSubsets = allSubsets.Select(s => new List<int>(s) {item}).ToList();
                allSubsets.AddRange(moreSubsets);
            }

            return allSubsets;
        }
    }
}
