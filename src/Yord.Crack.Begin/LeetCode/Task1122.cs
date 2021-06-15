namespace Yord.Crack.Begin.LeetCode
{
    // arr2 уникальные, все элементы arr2 есть в arr1. Вернуть отсортированный arr1:
    // чтобы элементы были в том же порядке, что в arr2 0 <= arr1[i], arr2[i] <= 1000
    //Элементы, которых нет в arr2, надо положить в конец в возрастающем порядке
    public class Task1122
    {
        //аналогично, просто складываем результат  в исходный массив
        public static int[] RelativeSortArray_InPlace(int[] arr1, int[] arr2)
        {
            var inArr1 = new int [1001];
            foreach (var e in arr1)
            {
                inArr1[e]++;
            }

            var idx = 0;
            foreach (var e in arr2)
            {
                while (inArr1[e]-- > 0)
                {
                    arr1[idx++] = e;
                }
            }

            for (var n = 0; n < inArr1.Length; n++)
            {
                while (inArr1[n]-- > 0)
                {
                    arr1[idx++] = n;
                }
            }

            return arr1;
        }

        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var inArr1 = new int [1001];
            for (var i = 0; i < arr1.Length; i++)
            {
                inArr1[arr1[i]]++;
            }

            var r = new int[arr1.Length];
            var idx = 0;
            foreach (var elem in arr2)
            {
                while (inArr1[elem] > 0)
                {
                    r[idx++] = elem;
                    inArr1[elem]--;
                }
            }

            for (var i = 0; i < inArr1.Length; i++)
            {
                while (inArr1[i] > 0)
                {
                    r[idx++] = i;
                    inArr1[i]--;
                }
            }

            return r;
        }
    }
}
