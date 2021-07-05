using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task806
    {
        public static int[] NumberOfLines(int[] widths, string s)
        {
            var linesCount = 0;
            var curLineWidth = 0;
            foreach (var width in s.Select(t => widths[t - 'a']))
            {
                if (curLineWidth + width > 100)
                {
                    curLineWidth = width;
                    linesCount++;
                }
                else
                {
                    curLineWidth += width;
                }
            }

            return new[] {curLineWidth > 0 ? linesCount + 1 : linesCount, curLineWidth};
        }
    }
}
