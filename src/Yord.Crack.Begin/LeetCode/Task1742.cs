using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // Есть N шаров, пронумерованные от lowLimit до highLimit включительно, n == highLimit - lowLimit + 1
    // и бесконечное число коробок с номерами от 1.
    // Каждый шар кладем в коробку с номеров равным сумме цифр номера на шаре
    // вернуть кол-во шаров в самой заполненной коробке. lowLimit >=1, highLimit<= 100_000
    public class Task1742
    {
        public static int CountBalls(int lowLimit, int highLimit)
        {
            Dictionary<int, int> boxFreq = new Dictionary<int, int>();
            int maxFreq = 1;
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int ballNumber = i;
                int boxNumber = 0;
                while (ballNumber > 0)
                {
                    boxNumber += ballNumber % 10;
                    ballNumber /= 10;
                }

                if (boxFreq.ContainsKey(boxNumber))
                {
                    boxFreq[boxNumber]++;
                    maxFreq = Math.Max(maxFreq, boxFreq[boxNumber]);
                }
                else
                {
                    boxFreq[boxNumber] = 1;
                }
            }

            return maxFreq;
        }

        public static int CountBalls_Math(int lowLimit, int highLimit)
        {
            //максимальный номер коробки 9+9+9+9+9=45
            int[] boxes = new int[46];
        
            var idx = BoxIdx(lowLimit);//номер коробки для первого шара
            boxes[idx]++;//положили туда первый шар
            var max = 1;
            while (++lowLimit <= highLimit) {
                var tmp = lowLimit;
                //номер коробки будет увеличиваться на ++, пока не достигнем цифры 0 в числе
                //если достигли, то номер коробки уменьшился на 9 (но ++ сохраняется, т.к. увеличился ведущий десяток)
                while (tmp % 10 == 0) { 
                    idx -= 9;
                    tmp /= 10;
                }
                max = Math.Max(++boxes[++idx], max);//положили в коробку ++idx новый шар 
            }
            return max;
        }
        
        private static int BoxIdx(int n) {
            var res = 0;
            while (n > 0) {
                res += n % 10;
                n /= 10;
            }
            return res;
        }
        /*
         *  1 --------> 1
            2 --------> 2
            3 --------> 3
            4 --------> 4
            5 --------> 5
            6 --------> 6
            ...
            9 --------> 9
            10 ------> 1
            11 ------> 2
            ....
            18 ------> 9
            19 ------> 10
            20 ------> 2
            21 ------> 3
            ...
            29 ------> 11
            30 ------> 3
            31 ------> 4
            ...
            39 ------> 12
            40 ------> 4
            41 ------> 5
            ...
            49 ------> 13
            50 ------> 5
            51 ------> 6
            ...
            59 ------> 14
            60 ------> 6
            61 ------> 7
            ...
            69 ------> 15
            70 ------> 7
            71 ------> 8
            ...
            79 ------> 16
            80 ------> 8
            81 ------> 9
            ...
            89 ------> 17
            90 ------> 9
            91 ------> 10
            ...
            99 -----> 18
            100 -----> 1
            101 -----> 2
         */
         
    }
}
