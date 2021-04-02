using System;

namespace Yord.Crack.Begin.LeetCode
{
    // сделать словарь, 0 <= key, value <= 106
    public class Task706
    {
        public class MyHashMap
        {

            private int Capacity = 10;
            private int Size;
            private int[] Buckets;
            private Kvp[] Data;
            private int freeList;
            private int freeCount;
            /** Initialize your data structure here. */
            public MyHashMap() {
                Buckets = new int [Capacity];
                for (int i=0; i < Buckets.Length; i++)
                {
                    Buckets[i] = -1;
                }

                Data = new Kvp[Capacity];
                freeList = -1;
            }
    
            /** value will always be non-negative. */
            public void Put(int key, int value) {
                var b = key % Buckets.Length;
                var i = Buckets[b];
                for (; i > -1; i = Data[i].Next)
                {
                    if (Data[i].Key == key)
                    {
                        Data[i].Value = value;
                        return;
                    }
                }

                int index;
                if (freeCount > 0)
                {
                    index = freeList;
                    freeCount--;
                    freeList = Data[index].Next;
                }
                else
                {
                    if (Size == Data.Length)
                    {
                        Rehash();
                        b = key % Buckets.Length;
                    }

                    index = Size;
                    
                }
                Size++;
                Data[index] = new Kvp
                {
                    Key = key,
                    Value = value,
                    Next = Buckets[b]
                };
                Buckets[b] = index;
            }

            private void Rehash()
            {
                Capacity *= 2;
                var newBucket = new int [Capacity];
                for (int i=0; i< newBucket.Length; i++)
                {
                    newBucket[i] = -1;
                }

                var newData = new Kvp[Capacity];
                Array.Copy(Data, newData, Data.Length);
                for (int i = 0; i < Data.Length; i++)
                {
                    var e = Data[i];
                    if (e.Value > -1)
                    {
                        var b = e.Key % newBucket.Length;
                        e.Next = newBucket[b];
                        newBucket[b] = i;
                    }
                }

                Data = newData;
                Buckets = newBucket;
            }
    
            /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
            public int Get(int key)
            {
                var b = key % Buckets.Length;
                var i = Buckets[b];
                for (; i > -1; i = Data[i].Next)
                {
                    if (Data[i].Key == key)
                    {
                        return Data[i].Value;
                    }
                }

                return -1;
            }
    
            /** Removes the mapping of the specified value key if this map contains a mapping for the key */
            public void Remove(int key) 
            {
                var b = key % Buckets.Length;
                var i = Buckets[b];
                var prev = -1;
                for (; i > -1; prev = i, i = Data[i].Next)
                {
                    if (Data[i].Key == key)
                    {
                        Size--;
                        Data[i].Key = -1;
                        Data[i].Value = -1;
                        if (prev != -1)
                        {
                            Data[prev].Next = Data[i].Next;
                        }
                        else
                        {
                            Buckets[b] = Data[i].Next;
                        }
                        
                        Data[i].Next = freeList;
                        freeList = i;
                        freeCount++;
                    }
                }
            }

            private class Kvp
            {
                public int Key;
                public int Value;
                public int Next;
            }
        }
    }
}
