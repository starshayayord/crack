using System.Linq;

namespace Yord.Crack.Begin
{
    public static class SimpleSearch
    {
        public static int GetIndex(int[] sortedArray, int element)
        {
            var result = 0;
            while (true)
            {
                if (sortedArray.Length == 0) return -1;
                var middleIndex = sortedArray.Length / 2;
                result += middleIndex;
                if (sortedArray[middleIndex] == element) return result;
                if (sortedArray[middleIndex] > element)
                {
                    result = 0;
                    sortedArray = sortedArray.Take(middleIndex).ToArray();
                }
                else
                {
                    sortedArray = sortedArray.Skip(middleIndex).ToArray();
                }
            }
        }
    }
}
