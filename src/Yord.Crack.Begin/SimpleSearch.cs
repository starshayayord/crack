namespace Yord.Crack.Begin
{
    public static class SimpleSearch
    {
        // Найти индекс элемента в отсортированном массиве. Элементы массива уникальны.
        public static int GetIndex(int[] sortedArray, int element)
        {
            var left = 0;
            var right = sortedArray.Length - 1;
            while (left <= right)
            {
                var middle = (right + left) / 2;
                if (sortedArray[middle] == element) return middle;
                if (sortedArray[middle] > element)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }

        public static int GetIndexRec(int[] sortedArray, int element)
        {
            return Rec(sortedArray, element, 0, sortedArray.Length - 1);
        }

        private static int Rec(int[] sortedArray, int element, int l, int r)
        {
            if (l > r) return -1;
            var middle = (r + l) / 2;
            if (sortedArray[middle] == element) return middle;
            return sortedArray[middle] > element
                ? Rec(sortedArray, element, l, middle - 1)
                : Rec(sortedArray, element, middle + 1, r);
        }
    }
}
