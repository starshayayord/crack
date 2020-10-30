using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin
{
    public class Equation
    {
        public class SolutionsDto
        {
            public int A { get; set; }

            public int B { get; set; }

            public int C { get; set; }

            public int D { get; set; }

            public bool Equals(SolutionsDto other)
            {
                return A == other.A && B == other.B && C == other.C && D == other.D;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != GetType()) return false;
                return Equals((SolutionsDto) obj);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(A, B, C, D);
            }
        }

        //целочисленные решения уравнения a^3 + b^3 = c^3 + d^3; a, b, c, d: [1,100]

        public class C3D3Combination
        {
            public int C { get; set; }

            public int D { get; set; }

        }
        
        public List<SolutionsDto> FindSolutions()
        {
            var c3d3results = new Dictionary<int, List<C3D3Combination>>();
            for (var c = 1; c <= 100; c++)
            {
                for (var d = 1; d <= 100; d++)
                {

                    var c3d3result = (int)(Math.Pow(c, 3) + Math.Pow(d, 3));
                    if (c3d3results.TryGetValue(c3d3result, out var currentList))
                    {
                        currentList.Add(new C3D3Combination
                        {
                            C = c,
                            D = d
                        });
                    }
                    else
                    {
                        c3d3results[c3d3result] = new List<C3D3Combination> {new C3D3Combination
                        {
                            C = c,
                            D = d
                        }};
                    }
                }
            }

            var solutions = new List<SolutionsDto>();
            foreach (var (_, pairList) in c3d3results)
            {
                foreach (var pair1 in pairList)
                {
                    foreach (var pair2 in pairList)
                    {
                        solutions.Add(new SolutionsDto
                        {
                            A = pair1.C,
                            B = pair1.D,
                            C = pair2.C,
                            D = pair2.D
                        });
                    }
                }
            }

            return solutions;
        }
    }
}
