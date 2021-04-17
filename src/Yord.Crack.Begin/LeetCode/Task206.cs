using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // кол-во простых чисел меньше n
    public class Task206
    {
        public static int CountPrimes_Simple(int n)
        {
            var notPrime = new bool[n];
            if (n <= 2)
            {
                return 0;
            }
            var c = n -2; //-2, т.е.не n и не 1
            //т.к. x*i > maxToCheck уже были проверены во внутреннем цикле
            var maxToCheck = Math.Sqrt(n);
            for (int i = 2; i <= maxToCheck; i++)
            {
                if (notPrime[i])
                {
                    continue;
                }

                for (int j = i * i; j < n; j += i)
                {

                    if (!notPrime[j])
                    {
                        notPrime[j] = true;
                        c--;
                    }
                    
                }
            }

            return c;
        }
        
        public static int CountPrimes(int n)
        {
            var notPrime = new bool[n];
            int primeCount = n/2; // как минимум половина из n - четные, значит простых не более  n/2
            // стартуем с первого нечетного (2 точно простая и 2*х - всегда четное)
            // инкрементим на 2, чтоб пропустить четные, которые точно не простые
            for (var i = 3; i*i < n; i+=2)
            {
                if (notPrime[i]) // уже поняли, что не является простым
                {
                    continue;
                }
                //знаем что i - простое и нечетное
                //проитерируемся по всем нечетным числам, которые получаются из i умножением, пометим их как не простые
                //i*i точно не простое (получено умножением).
                //i * i + i - тоже непростое и четное (i -нечетное, i*i - тоже, значит i*i+i - четное)
                //(по сути, умножение на i+1) => i * i + a*i тоже не простое
                // нужно пропустить все четные, т.к. мы уже изначально из убрали  (primeCount = n/2),т.е.
                // i * i + a*i для всех НЕЧЕТНЫХ а.
                // начинаем с j = i * i, потому что i не мб четными (i+=2), а все предыдущие нечетные i мы уже проверили
                //  и они либо уже были среди составных, либо были среди простых и мы поменили все составные от них
                for (int j = i * i; j < n; j += 2 * i)
                {
                    if (!notPrime[j])
                    {
                        --primeCount;
                        notPrime[j] = true;
                    }
                }
            }

            return primeCount;
        }
        
        public static int CountPrimes_LinearErato(int n)
        {
            var pr = new List<int>();
            var lp = new int[n + 1];
            for (int i = 2; i < n; i++)
            {
                //число простое, т.к. наименьший простой делитель еще не установлен
                if (lp[i] == 0)
                {
                    //для этого числа наименьший простой делитель - оно само
                    lp[i] = i;
                    //добавим его в массив простых
                    pr.Add(i);
                }

                //для всех найденных простых
                foreach (var p in pr)
                {
                    long idx = p * i;
                    //пока они не больше наименьшего делителя текущего числа
                    //и пока перебираемый результат, кратный простому числу не больше искомого диапазона
                    if (p <= lp[i] && idx <= n)
                    {
                        //обновлять простой делитель для числа, кратного простому
                        lp[idx] = p;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return pr.Count;
        }
    }
}
