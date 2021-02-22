using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter8
{
    // получить все перестановки строки
    public class Task7
    {
        public static List<string> GetPermutations(string src)
        {
            return GetPermutations(src, string.Empty, new List<string>());
        }

        private static List<string> GetPermutations(string src, string prefix, List<string> r)
        {
            // если нечего больше переставлять
            if (src.Length == 0)
            {
                r.Add(prefix);
            }
            else
            {
                //  берем первый символ, а к нему прибавляем перестановки оставшихся
                for (var i = 0; i < src.Length; i++)
                {
                    var newPrefix = prefix + $"{src[i]}";
                    var newSrc = src.Remove(i, 1);
                    GetPermutations(newSrc, newPrefix, r);
                }
            }

            return r;
        }

        // Генерация перестановок в массиве
        public static List<List<int>> GetPermutationsArray(List<int> src)
        {
            var permutations = new List<List<int>>();
            GetPermutationsArray(src, new List<int>(), permutations);
            return permutations;
        }

        private static void GetPermutationsArray(List<int> src, List<int> currentList,
            List<List<int>> permutations)
        {
            if (currentList.Count == src.Count)
            {
                permutations.Add(currentList);
                return;
            }

            foreach (var choice in src)
            {
                // Если в текущем варианте перестановки он уже есть, то пропускаем итерацию
                if (currentList.Contains(choice))
                {
                    continue;
                }

                // Добавляем выбранный символ в текущий вариант перестановки
                currentList.Add(choice);
                // Берем перестановки
                GetPermutationsArray(src, currentList, permutations);

                // Вышли из рекурсии, убираем последний вариант, который мы выбрали,
                // чтобы в следующей итерации взять другой символ для этой позиции.
                // На самом деле мы удалим два, т.к. один удалим сразу,
                // а второй потому что после удаления выйдем из рекурсии на стек выше и завершим этот foreach 
                currentList.RemoveAt(currentList.Count - 1);
            }
        }
    }
}
