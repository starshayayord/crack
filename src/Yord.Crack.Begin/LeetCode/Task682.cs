using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть ко-во очков
    public class Task682
    {
        public static int CalPoints2(string[] ops)
        {

            var scores = new Stack<int>();
            var sum = 0;
            foreach (var s in ops)
            {
                switch (s)
                {
                    case "C":
                        sum -= scores.Pop();
                        break;
                    case "D":
                        var d = scores.Peek() * 2;
                        scores.Push(d);
                        sum += d;
                        break;
                    case "+":
                        var x = scores.Pop();
                        var y = scores.Peek();
                        scores.Push(x);
                        scores.Push(x+y);
                        sum += x+y;
                        break;
                    default:
                        var i = ConvertToInt(s);
                        scores.Push(i);
                        sum += i;
                        break;
                }
            }

            return sum;

        }
        
        public static int CalPoints(string[] ops)
        {

            var scores = new List<int>();
            foreach (var s in ops)
            {
                switch (s)
                {
                    case "C":
                        scores.RemoveAt(scores.Count-1);
                        break;
                    case "D":
                        scores.Add(scores[^1]*2);
                        break;
                    case "+":
                        scores.Add(scores[^1]+scores[^2]);
                        break;
                    default: scores.Add(ConvertToInt(s));
                        break;
                }
            }

            return scores.Sum();

        }

        private static int ConvertToInt(string s)
        {
            var r = 0;
            var isNegative = s[0] == '-';
            var i = isNegative ? 1 : 0;
            for (; i < s.Length; i++)
            {
                r = r * 10 + s[i] - '0';
            }

            return isNegative ? -1 * r : r;
        }
    }
}
