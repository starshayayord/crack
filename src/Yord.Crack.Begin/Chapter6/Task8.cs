namespace Yord.Crack.Begin.Chapter6
{
    // В 100этажном здании если сбросить яйца с Nго этажа (или выше), то оно разобьется. Если нижу - нет.
    // Если есть 2 яйца, найти N за минимальное число бросков
    public class Task8
    {
        // В идеальном случае кол-во бросков 1го + кол-во бросков второго должно бысть константой.
        // Т.е. каждый доп бросок яйца 1 уменьшает необходимое число броской яйца 2 на 1 попытку.
        // Например яйцо не разбилось на 5 и 10, разбилось на 15, это значит
        // 3 попытки яйца1 (5,10,15) и еще 4 попытки яйца2 (11,12,13,14).
        // Еще например: яйцо разбилось на 100 (10,20,20...90,100), т.е. 10 попыток яйца1,
        // но еще необходимо 9 попыток яйца2 (91,92...98,99), чтоб найти N. Итого 19 попыток
        // Ищем идеальный случай, когда x + (x-1) + (x-2)+...+ 1= 100
        // Это арифмет. прогрессия a1=x, d=-1, a(последн) = a1 + d(n-1) = x - (x-1) 
        // значит сумма 100 = x(x-1)/2
        // корень 13.6
        // если возьмем 13, то худший случай будет иметь больше попопыток (аналогично рассчету выше) => округляем до 14.
        private const int MaxFloor = 100;
        private const int MinFloor = 1;

        public static int GetFloor(int initialN)
        {
            var interval = 14;
            var prevFloor = 0;
            var egg1 = interval;
            var trials = 0;
            //находим, где яйцо не разбилось
            while (!IsBroken(initialN, egg1) && egg1 <= MaxFloor)
            {
                trials++;
                interval--;
                prevFloor = egg1;
                egg1 += interval;
            }
            //ищем минимальный этаж с приращением в один
            var egg2 = prevFloor + 1;
            while (egg2 < egg1 && egg2 <=MaxFloor && !IsBroken(initialN, egg2))
            {
                trials++;
                egg2++;
            }

            return egg2 > MaxFloor ? -1 : egg2;
        }
        public static int GetFloor2(int initialN)
        {
            var max = MaxFloor;
            var min = MinFloor;
            var trials = 0;
            while (max != min+1)
            {
                trials++;
                var currentFloor = (max + min) / 2;
                var isBroken = IsBroken(initialN, currentFloor);
                if (isBroken)
                {
                    max = currentFloor;
                }
                else
                {
                    min = currentFloor;
                }
            }

            return max;
        }
        
        private static bool IsBroken(int initialN, int current)
        {
            return current >= initialN;
        }
    }
}
