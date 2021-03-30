using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //0 <= element <= 1000000
    public class Task705
    {
        public class MyHashSet
        {

            private const double RehashCapacity = 0.75;
            private int Capacity = 10;
            private int Count;
            private LinkedList<int>[] Buckets;  
            public MyHashSet()
            {
                Buckets = new LinkedList<int>[Capacity];
            }
    
            public void Add(int key)
            {
                if (Contains(key)) return;
                if ((double) Count / Capacity > RehashCapacity)
                {
                    Capacity *= 2;
                    var newBuckets = new LinkedList<int>[Capacity];
                    foreach (var bucket in Buckets)
                    {
                        if (bucket == null) continue;
                        foreach (var l in bucket)
                        {
                            int newB = l % Capacity;
                            newBuckets[newB] ??= new LinkedList<int>();
                            newBuckets[newB].AddLast(l);
                        }
                    }

                    Buckets = newBuckets;
                }
                int b = key % Capacity;
                Buckets[b] ??= new LinkedList<int>();
                Buckets[b].AddLast(key);
                Count++;
            }
    
            public void Remove(int key) 
            {
                if (!Contains(key)) return;
                int b = key % Capacity;
                Buckets[b].Remove(key);
                Count--;
            }

            public bool Contains(int key)
            {
                int b = key % Capacity;
                return Buckets[b] != null && Buckets[b].Contains(key);
            }
        }

        
        public class MyHashSet_Bit
        {
            private int[] elements;

            public MyHashSet_Bit()
            {
                elements = new int[1000000 / 32 + 1];
            }

            public void Add(int key)
            {
                int idx = key / 32;
                elements[idx] |= GetMask(key);
            }

            public void Remove(int key)
            {
                int idx = key / 32;
                elements[idx] &= ~GetMask(key);
            }

            public bool Contains(int key)
            {
                int idx = key / 32;
                return (GetMask(key) & elements[idx]) != 0;
            }

            private int GetMask(int key)
            {
                var bit = key % 32;
                return 1 << bit;
            }
        }
    }
}
