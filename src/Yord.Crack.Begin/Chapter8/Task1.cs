using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter8
{
    // Ребенок поднимается по леснице из N  ступенек. За один шаг может переместиться на 1,2 или 3 ступеньки.
    // Рассчитать кол-во возможных вариантов перемещения
    public class Task1
    {
        // в массиве будет лежать не более N+1 значений
        public static int CountWays(int n)
        {
            var memo = new int[n + 1];
            for (var i = 0; i <= n; i++)
            {
                //  только для того, чтобы понимать, какие пути мы уже посчитали
                //m[i] = сколько вариантов путей до iой ступени
                //можно просто использовать словарь
                memo[i] = -1;
            }

            return CountWays(n, memo);
        }

        private static int CountWays(int n, int[] memo)
        {
            if (n < 0)
            {
                return 0;
            }

            // до 0 ступени можно добраться одним способом (не 0 способов). Это удобно для расчета CountWays(1):
            // CountWays(0) +  CountWays(-1) + CountWays(-2). В первом слагаемом полчаем 1 вариант.
            // Иначе пришлось бы описать больше крайних случаев.
            if (n == 0)
            {
                return 1;
            }

            // Для последнего числа степеней считаем F(n-1) + F(n-2) +F(n-3).
            // Для предпоследнего числа ступеней F(n-2) + F(n-3) +F(n-4), т.е. многие слагаемые повторяются.
            // Чтоб не считать одно и то же несколько раз, используем memo
            if (memo[n] > -1)
            {
                return memo[n];
            }

            // Добраться до Nой стпени можно несколькими способами:
            // 1. Встать на (N-1) и подняться на 1
            // 2. Встать на (N-2) и подняться на 2
            // 3. Встать на (N-3) и подняться на 3.
            // Необходимо СЛОЖИТЬ все варианты поднятия на (N-1), (N-2), (N-3), т.к. они взаимоисключающие 
            // То, что пути где-то в глубине пересекаются - не важно, потому что конец у них всегда разный, т.е.
            // последнее число 1, 2, или 3, поэтому пути разщные
            memo[n] = CountWays(n - 1, memo) + CountWays(n - 2, memo) + CountWays(n - 3, memo);
            return memo[n];
        }

        // в этом варианте в списке в итоге будет лежать столько значений, сколько вариантов реально было
        // занимает слишком много памяти и времени
        public static int CountWays2(int stairNumber)
        {
            if (stairNumber == 0) return 1;
            if (stairNumber < 3)
            {
                return stairNumber % 3;
            }

            var result = new ResultVars
            {
                Variants = new List<int> {1, 2, 3},
                IsFinished = false
            };

            while (!result.IsFinished)
            {
                result = AddSteps(result.Variants, stairNumber);
            }

            return result.Variants.Count;
        }

        private static ResultVars AddSteps(List<int> vars, int stairNumber)
        {
            var finished = true;
            var newVars = new List<int>();
            foreach (var v in vars)
            {
                if (v == stairNumber)
                {
                    newVars.Add(v);
                    continue;
                }

                if (v + 1 <= stairNumber)
                {
                    newVars.Add(v + 1);
                    finished = false;
                }

                if (v + 2 <= stairNumber)
                {
                    newVars.Add(v + 2);
                    finished = false;
                }

                if (v + 3 <= stairNumber)
                {
                    newVars.Add(v + 3);
                    finished = false;
                }
            }

            return new ResultVars
            {
                Variants = newVars,
                IsFinished = finished
            };
        }

        private class ResultVars
        {
            public bool IsFinished { get; set; }

            public List<int> Variants { get; set; }
        }
    }
}
