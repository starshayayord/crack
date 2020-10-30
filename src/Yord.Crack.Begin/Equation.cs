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

        //целочисленные решения уравнения a^3 + b^3 = c^3 + d^3; a, b, c, d: [1,1000]
        public List<SolutionsDto> FindSolutions()
        {
            var solutions = new List<SolutionsDto>();
            for (var a = 1; a <= 1000; a++)
            {
                for (var b = 1; b <= 1000; b++)
                {
                    for (var c = 1; c <= 1000; c++)
                    {
                        var d = (int) Math.Pow(Math.Pow(a, 3) + Math.Pow(b, 3) - Math.Pow(c, 3), 1 / 3);
                        if (Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3))
                        {
                            solutions.Add(new SolutionsDto
                            {
                                A = a,
                                B = b,
                                C = c,
                                D = d
                            });
                        }
                    }
                }
            }

            return solutions;
        }
    }
}
