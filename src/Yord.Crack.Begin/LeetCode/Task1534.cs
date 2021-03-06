using System;

namespace Yord.Crack.Begin.LeetCode
{
    // Триплет - числа из массива (arr[i], arr[j], arr[k]), причем такие, что: 
    //0 <= i < j < k < arr.length
    //|arr[i] - arr[j]| <= a
    //|arr[j] - arr[k]| <= b
    //|arr[i] - arr[k]| <= c
    //Вернуть кол-во таких чисел
    public class Task1534
    {
        // Итерируемся по среднему номеру, ищем нижнюю и верхнюю границу для номеров перед и после.
        // Затем итерируемся по возможным значениям перед, расширяя границы значений после 
        // 0 <= arr[i] <= 1000
        public static int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int n = arr.Length;
            int ans = 0;
            // pre[X] - кол-во значений слева от среднего числа, где значение X
            int[] pre = new int[1001];
            // post[X] - кол-во значений справа от среднего, где значение меньше либо равно текущему
            int[] post = new int[1001];
            //кол-во значений слева от Jго равных arr[0],
            //т.е. слева от самого начального j=1 находится всего 1 число равное arr[0]
            pre[arr[0]] =1; 
            // для всех возможных чисел справа от Jго 
            for (int i = 2; i < n; i++) 
            {
                // справа от Jго числа находится +1 кол-во значений равных arr[i]
                post[arr[i]]++; // post - кол-во этих значений в arr[i] 
            }

            //для всех возможных значений (мин - 0, но для него нет значений слева)
            for (int x = 1; x <= 1000; x++)
            {
                // кол-во значений меньших либо равных числу x - это кол-во предыдущих + кол-во значений равных x
                post[x] = post[x - 1] + post[x];
            }

            //для всех возможных j 
            for (int j = 1; j <= n - 2; j++)
            {
                int v = arr[j]; //текущее значение среднего числа
                int p1 = Math.Max(0, v - a); //  мин a[i]
                int p2 = Math.Min(1000, v + a); // макс a[i]
                int t1 = Math.Max(0, v - b); // мин a[k]
                int t2 = Math.Min(1000, v + b); // макс a[k]
                for (int s = p1; s <= p2; s++) //от мин значения a[i] до макс значения a[i]
                {
                    if (pre[s] == 0) continue; // нет такого a[i] слева от a[j] пропускает
                    int m1 = Math.Max(t1, s - c); // мин значение a[k]
                    int m2 = Math.Min(t2, s + c); // макс значение a[k]
                    if (m2 < m1) continue; //если такие границы невозможны - пропускаем
                    if (m1 == 0) //если мин a[k] == 0
                    {
                        // кол-во доп триплетов -это
                        // кол-во чисел равных значению a[i] слева от текущего
                        // * кол-во значений меньше или равных макс a[k] справа от текущего
                        ans += pre[s] * post[m2];
                    }
                    else
                    {
                        // кол-во доп триплетов - это
                        // кол-во чисел равных значению a[i] слева от текущего * 
                        // (кол-во значений меньше или равных макс a[k] справа от числа J
                        // - кол-во значений меньше или равных мин a[k-1] справа от числа J)
                        // т.е. начало триплета *
                        // (кол-во вариантов чисел до max(a[k] - кол-во вариантов чисел до min(a[k]-1))
                        ans += pre[s] * (post[m2] - post[m1 - 1]);
                    }
                }

                // сейчас будем сдвигаться правее, так что:
                // кол-во значений a[j]  +1, т.к. текущее число останется слева от будущего
                pre[v]++;
                // новое число станет средним (а раньше оно было справа)
                // так что кол-во значений справа меньших либо равных новому текущему уменьшается на 1
                // (т.е. на само себя, т.к. оно теперь будет не справа от себя, а само будет средним)
                for (int i = arr[j + 1]; i <= 1000; i++)
                {
                    // кол-во значений справа меньше или равных этому числу уменьшаем на 1
                    post[i]--;
                }
            }

            return ans;
        }


        public static int CountGoodTriplets_FenwTree(int[] arr, int a, int b, int c)
        {
            int m = 1000; //макс значение arr[x]
            int n = arr.Length;
            // valuesBefore[arr[x]] кол-во чисел слева от j которые равны arr[x]
            int[] valuesBefore = new int [m + 1];
            //  min(j)=1, значит перед ним только число arr[0] в кол-ве 1
            valuesBefore[arr[0]] = 1;
            // кол-во значений справа от j
            Fenw valuesAfter = new Fenw(m + 1);
            for (int i = 2; i < n; i++) //для всех индексов справа от j, min(k)=2
            {
                valuesAfter.Add(arr[i], 1);
            }

            int ans = 0;
            for (int j = 1; j < n - 1; j++) // для всех возможных j
            {
                int curVal = arr[j];
                int limUpA = Math.Min(m, curVal + a);
                int limLoA = Math.Max(0, curVal - a);
                int limUpB = Math.Min(m, curVal + b);
                int limLoB = Math.Max(0, curVal - b);
                for (int prevVal = limLoA; prevVal <= limUpA; prevVal++)
                {
                    // если нет значений слева от a[j]
                    if (valuesBefore[prevVal] == 0) continue;
                    int limUpC = Math.Min(prevVal + c, limUpB);
                    int limLoC = Math.Max(prevVal - c, limLoB);
                    if (limUpC < limLoC) continue; // границы для a[k] невозможны
                    ans += limLoC == 0
                        ? valuesBefore[prevVal] * valuesAfter.GetSum(limUpC)
                        : valuesBefore[prevVal] * valuesAfter.GetSum(limLoC, limUpC);
                }

                //сейчас двинемся дальше вправо, так что:
                //кол-во чисел слева от будущего текущего увеличивается на 1
                valuesBefore[curVal]++;
                // кол-во значений справа от значения следующего уменьшается на 1
                valuesAfter.Add(arr[j + 1], -1);
            }


            return ans;
        }

        class Fenw
        {
            private int[] tree;

            public Fenw(int size)
            {
                tree = new int[size + 1];
            }

            public void Add(int idx, int val)
            {
                for (int i = idx + 1; i < tree.Length; i += i & -i)
                {
                    tree[i] += val;
                }
            }

            public int GetSum(int i, int j)
            {
                return GetSum(j) - GetSum(i);
            }

            public int GetSum(int idx)
            {
                int r = 0;
                for (int i = idx + 1; i > 0; i -= i & -i)
                {
                    r += tree[i];
                }

                return r;
            }
        }

        public static int CountGoodTriplets_Cache(int[] arr, int a, int b, int c)
        {
            var s = new int [arr.Length][];
            for (var i = 0; i < arr.Length; i++)
            {
                var d = new int [arr.Length];
                Array.Fill(d, -1);
                s[i] = d;
            }

            int t = 0;
            for (var i = 0; i < arr.Length - 2; i++)
            {
                for (var j = i + 1; j < arr.Length - 1; j++)
                {
                    for (var k = j + 1; k < arr.Length; k++)
                    {
                        if (CalcOrGet(s, i, j, arr) <= a
                            && CalcOrGet(s, j, k, arr) <= b
                            && CalcOrGet(s, i, k, arr) <= c)
                        {
                            t++;
                        }
                    }
                }
            }

            return t;
        }

        private static int CalcOrGet(int[][] s, int index1, int index2, int[] arr)
        {
            int diff = s[index1][index2];
            if (diff != -1) return diff;
            diff = Math.Abs(arr[index1] - arr[index2]);
            s[index1][index2] = diff;

            return diff;
        }
    }
}
