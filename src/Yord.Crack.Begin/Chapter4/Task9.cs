using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter4
{
    // БДП создано обходом массива слева направо и вставкой каждого элемента
    // вывести всевозможные массивы, которые могли привести к созданию БДП (элементы уникальны)
    public class Task9
    {
        public static List<LinkedList<int>> GetInitialArrays(BSTNode root)
        {
            var result = new List<LinkedList<int>>();
            if (root == null)
            {
                result.Add(new LinkedList<int>());
                return result;
            }

            var prefix = new LinkedList<int>();
            //фиксируем текущую ноду (корень, т.к. она должна быть вставлена вперед)
            prefix.AddFirst(root.Value);
            // получаем все возможные варианты исходных массивов, которые могли быть для левого и для правого поддерева
            var leftSeq = GetInitialArrays(root.Left);
            var rightSeq = GetInitialArrays(root.Right);
            // перед префиксом миксуем все варианты для исходных массивов левого и правого поддеревьев
            foreach (var l in leftSeq)
            {
                foreach (var r in rightSeq)
                {
                    var weaved = new List<LinkedList<int>>();
                    WeaveLists(l, r, prefix, weaved);
                    result.AddRange(weaved);
                }
            }

            return result;
        }


        //объединим два списка всеми возможными способами
        //получим все перестановки
        private static void WeaveLists(LinkedList<int> f, LinkedList<int> s, LinkedList<int> prefix,
            List<LinkedList<int>> results)
        {
            if (f.Count == 0 || s.Count == 0)
            {
                var result = new LinkedList<int>(prefix);
                foreach (var e in f)
                {
                    result.AddLast(e);
                }

                foreach (var e in s)
                {
                    result.AddLast(e);
                }

                results.Add(result);
                return;
            }
 
            //последовательно фиксируем в префиксе первый массив
            var headF = f.First;
            f.RemoveFirst();
            prefix.AddLast(headF);
            WeaveLists(f, s, prefix, results);
            //откат изменений
            prefix.RemoveLast();
            f.AddFirst(headF);

            //последовательно фиксируем в префиксе второй массив
            var headS = s.First;
            s.RemoveFirst();
            prefix.AddLast(headS);
            WeaveLists(f, s, prefix, results);
            //откат изменений
            prefix.RemoveLast();
            s.AddFirst(headS);
        }

        public class BSTNode
        {
            public int Value;
            public BSTNode Left;
            public BSTNode Right;
        }
    }
}
