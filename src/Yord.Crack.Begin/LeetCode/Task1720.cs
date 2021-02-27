namespace Yord.Crack.Begin.LeetCode
{
    // Раскодировать массив, который состоит из N неотрицательных целых чисел.
    // Массив зашифрован в encoded, длиной N-1, так, что encoded[i] = arr[i] XOR arr[i + 1]
    // [1,0,2,1] => encoded = [1,2,3]. Также есть first - первый элемент ИСХОДНОГО массива
    // XOR,  одинаковые биты - 0, иначе - 1. Т.е. биты одинаковые -> 0, иначе выполянется логическая И 
    public class Task1720
    {
        public static int[] Decode(int[] encoded, int first)
        {
            int[] arr = new int[encoded.Length + 1];
            arr[0] = first;
            for(int i = 0;  i < encoded.Length; i++)
            {
                //  т.к. обратная операция для XOR - это сама XOR
                arr[i + 1] = arr[i] ^ encoded[i];
            }

            return arr;
        }
    }
}
