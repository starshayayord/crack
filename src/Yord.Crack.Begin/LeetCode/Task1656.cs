using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1656
    {
        
        public class OrderedStream
        {
            private int ptr = 0;
            private List<string> arr;
            public OrderedStream(int n)
            {
                arr = new List<string>(new string[n]);
            }
    
            // добавляет value на позицию idKey
            // возвращает все связные чанки после поинтера включительно
            public IList<string> Insert(int idKey, string value)
            {
                arr[idKey - 1] = value;
                int pptr = ptr;
                while (ptr < arr.Count && arr[ptr] != null)
                {
                    ptr++;
                }


                return arr.GetRange(pptr, ptr-pptr);
            }
        }
    }
}
