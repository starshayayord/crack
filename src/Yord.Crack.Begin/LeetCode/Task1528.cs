namespace Yord.Crack.Begin.LeetCode
{
    // дана строка и массив чисел. В массиве записано, на какой позиции должна стоять буква из строки
    // "e, t, t, s" [1,3,0,2]=> "test" 
    public class Task1528
    {
        public static string RestoreString(string s, int[] indices)
        {
            var r = new char[s.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                r[indices[i]] = s[i];
            }

            return new string(r);
        }
        
        //  альтернативно можно применить циклическую сортировку
        public static string RestoreString_Sort(string s, int[] indices)
        {
            var charArr = s.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                // меняем местами, пока не найдем нужное, затем переходим на следующий индекс
                while (i != indices[i])
                {
                    Swap(charArr, i, indices[i]);
                    Swap(indices, i, indices[i]);
                }
            }

            return new string(charArr);
        }

        private static void Swap(char[] a, int i1, int i2)
        {
            var temp = a[i1];
            a[i1] = a[i2];
            a[i2] = temp;
        }
        
        private static void Swap(int[] a, int i1, int i2)
        {
            var temp = a[i1];
            a[i1] = a[i2];
            a[i2] = temp;
        }
    }
}
