using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Start
{
    public class Equation
    {
        public class SolutionsDto
        {
            public int A { get; set; }

            public int B { get; set; }

            public int C { get; set; }

            public int D { get; set; }
        }

        //целочисленные решения уравнения a^3 + b^3 = c^3 + d^3; a, b, c, d: [1,100]
        public List<SolutionsDto> FindSolutions()
        {
            var c3d3Results = new Dictionary<int, List<Tuple<int, int>>>();
            for (var c = 1; c <= 100; c++)
            {
                var c3 = Math.Pow(c, 3);
                for (var d = 1; d <= 100; d++)
                {
                    var c3d3Result = (int) (c3 + Math.Pow(d, 3));
                    if (c3d3Results.TryGetValue(c3d3Result, out var currentList))
                    {
                        currentList.Add(new Tuple<int, int>(c, d));
                    }
                    else
                    {
                        c3d3Results[c3d3Result] = new List<Tuple<int, int>>
                        {
                            new Tuple<int, int>(c, d)
                        };
                    }
                }
            }

            var solutions = new List<SolutionsDto>();
            foreach (var (_, pairList) in c3d3Results)
            {
                foreach (var (a, b) in pairList)
                {
                    foreach (var (c, d) in pairList)
                    {
                        solutions.Add(new SolutionsDto
                        {
                            A = a, B = b, C = c, D = d
                        });
                    }
                }
            }

            return solutions;
        }
    }
}
