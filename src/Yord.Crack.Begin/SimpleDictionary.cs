using System;

namespace Yord.Crack.Begin
{
    //реализовать словарь на базе связных списков
    public class SimpleDictionary<TKey, TValue>
        // where TKey : IComparable<TKey> только если нужно хранить ключи упорядоченно
    {
        public SimpleDictionary(int capacity)
        {
            int size = capacity * 2;
            buckets = new int[size];
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = -1;
            }

            entries = new Entry[size];
            freeList = -1;
            freeCount = size;
        }

        private struct Entry
        {
            public int hashCode;
            public int next; // на случай коллизии. ==-1 если элемент последний в списке
            public TKey key;
            public TValue value;
        }
        

        // Все записи лежат в массиве записей.
        // Пока элементы не удаляли, записи будут храниться в массиве последовательно.
        // При удалении появляется "дыра", которая будет сохранена в freeList и кол-во дыр freeCount.
        // Эти пустые записи будут связаны с помощью Entry.next 
        private Entry[] entries;


        // каждое значение указывает на индекс в entries, в котором хранится первая запись по этому бакету.
        // То есть хэш-код элемента Entry маппится на индекс из buckets.
        // чтобы решить, какое значение имеется ввиду, используется chaining (next).
        private int[] buckets;

        // при удалении freeList становится равен индексу пустого элемента в entities (последнего удаленного по порядку,
        // но первого удаленного в списке удаленных)
        // то есть entities[freeList].next указывает на следующий индекс удаленного и т.д.
        private int freeList;

        // кол-во освободившихся мест при удалении
        private int freeCount;

        //кол-во элементов в entities, в том числе условно свободных
        private int count;
        
        // кол-во элементов в словаре равно количеству минус кол-во дырок
        public int Count
        {
            get { return count - freeCount; }
        }
        
        public void Insert(TKey key, TValue value)
        {
            //считаем хеш ключа, убирая отрицательные значения
            int hashCode = key.GetHashCode() & 0x7FFFFFFF;

            // считаем бакет для элемента. Функция, чтоб равномерно распределить элементы по бакетам
            int targetBucket = hashCode % buckets.Length;

            // проходимся по всем элементам выбранного бакета (next - это следующий элемент в цепочке, если была коллизия)
            // Если в цепочке нет больше элементов, то значение next == -1
            // Если нашли ключ в словре, то обновляем соответствующее значение 
            for (int i = buckets[targetBucket]; i >= 0; i = entries[i].next)
            {
                // если хэш код и ключ совпали текущего и существующего элемента совпали, то просто изменяем значение
                // также можно вызвать исключение AlreadyExist
                if (entries[i].hashCode == hashCode && entries[i].key.Equals(key))
                {
                    entries[i].value = value;
                    return;
                }
            }

            int index;
            //если есть свободные дыры в entries
            if (freeCount > 0)
            {
                index = freeList;
                freeList = entries[index].next;
                freeCount--;
            }
            // нет свободных ячеек в entries
            else
            {
                // словарь заполнен, необходим Resize() чтоб увеличить его вместимость (вместимость buckets и entries)
                if (count == entries.Length)
                {
                    //после Resize точно нет "дыр" в массиве, поэтому новый элемент будет последним
                    Resize();
                    // пересчитаем бакет для нового элемента 
                    targetBucket = hashCode % buckets.Length;
                }

                // индекс равен последнему элементу в массиве
                index = count;
                count++;
            }

            // если bucket уже содержал айтем, то он будет следующем в chain'e
            entries[index].next = buckets[targetBucket];
            // заполним entries[index] переданными значениями key, value
            entries[index].hashCode = hashCode;
            entries[index].key = key;
            entries[index].value = value;
            buckets[targetBucket] = index;
        }

        public bool Remove(TKey key)
        {
            // считаем неотрицательный хеш-код ключа
            int hashCode = key.GetHashCode() & 0x7FFFFFFF;
            //вычисляем его бакет
            int bucket = hashCode % buckets.Length;
            int last = -1; // индекс последнего
            //идем по индексам (по списку) начиная с индекса, лежащего в целевом бакете и по каждосу следюющему _next
            for (int i = buckets[bucket]; i >= 0; last = i, i = entries[i].next)
            {
                // если хэшкод и ключ совпали с ключом удаляемого элемента
                if (entries[i].hashCode == hashCode && entries[i].key.Equals(key))
                {
                    // если элемент был последним, то кладем в целевой бакет индекс следующего
                    if (last < 0)
                    {
                        buckets[bucket] = entries[i].next;
                    }
                    // если элемент был последним
                    else
                    {
                        // то следующий элемент у предыдущего элемента станет равен следующему элементу удаленного элемента 
                        entries[last].next = entries[i].next;
                    }

                    //чистим удаляемый элемент
                    // индекс следующего элемента для удаляемого линкуется на индекс пустого элемента из freeList 
                    entries[i].next = freeList;
                    //все значения структуры очищаются
                    entries[i].hashCode = -1;
                    entries[i].key = default(TKey);
                    entries[i].value = default(TValue);
                    // в freeList кладется индекс дыры в entity
                    freeList = i;
                    // счетчик пустых элементов увеличивается на 1.
                    freeCount++;
                    return true;
                }
            }

            return false;
        }

        public TValue GetValueOrDefault(TKey key)
        {
            // считаем неотрицательный хеш-код ключа
            int hashCode = key.GetHashCode() & 0x7FFFFFFF;
            //вычисляем его бакет
            int bucket = hashCode % buckets.Length;
            //идем по индексам (по списку) начиная с индекса, лежащего в целевом бакете и по каждосу следюющему _next
            for (int i = buckets[bucket]; i >= 0; i = entries[i].next)
            {
                // если хэшкод и ключ совпали с ключом удаляемого элемента
                if (entries[i].hashCode == hashCode && entries[i].key.Equals(key))
                {
                    return entries[i].value;
                }
            }

            return default(TValue);
        }

        private void Resize()
        {
            // каждый раз величиваем вместимость вдвое
            int newSize = count * 2;
            int[] newBuckets = new int[newSize]; // создаем новый массив  bucket'ов увеличенного размера 
            //инициализируем его указатели -1 (пустыми индексами) 
            for (int i = 0; i < newBuckets.Length; i++)
            {
                newBuckets[i] = -1;
            }

            // создаем новый массив для entries увеличенного размера 
            Entry[] newEntries = new Entry[newSize];
            // копируем в него все текущие значения 
            Array.Copy(entries, 0, newEntries, 0, count);
            // для всех
            for (int i = 0; i < count; i++)
            {
                // если элемент не пустой
                if (newEntries[i].hashCode >= 0)
                {
                    //считаем его новый целевой бакет
                    int bucket = newEntries[i].hashCode % newSize;
                    // индексом следующего элемента для текущего будет индекс, который лежит в целевом бакете (если он есть) или -1
                    //т.е. если мы за ЭТОТ цикл переноса в newBuckets уже что-то туда положили, то кладем следующий,
                    //а в его _next кладем ссылку на уже лежавший
                    newEntries[i].next = newBuckets[bucket];
                    // индекс в целевом бакете = индексу текущего элемента
                    newBuckets[bucket] = i;
                }
            }

            buckets = newBuckets;
            entries = newEntries;
        }
    }
}
