namespace Yord.Crack.Begin.Chapter6
{
    // Есть 20 баночек. В 19 таблетки по 1г, в оставшейся 1.1г. Вычисить баночку, в которой таблетки тяжелее
    // взвешивать можно 1 раз
    public class Task1
    {
        private const int BottlesQuantity = 20;
        private const int NormalPillWeight = 1;
        private const double HeavyPillWeight = 1.1;

        public static int FindHeavyBottle(int heavyBottleNumber)
        {
            
            double totalWeight = 0;
            // реальный вес таблеток на весах
            for (var bottleNumber = 1; bottleNumber <= BottlesQuantity; bottleNumber++)
            {
                totalWeight += bottleNumber == heavyBottleNumber
                    ? HeavyPillWeight * bottleNumber
                    : NormalPillWeight * bottleNumber;
            }

            //столько должны весить таблетки, если бы они все были нормальными
            //формула Nго члена арифметической прогрессии:
            //Sn = (2*x1 + d*(N-1))/2  *  N 
            var normalPillWeight = (2 * NormalPillWeight + NormalPillWeight * (BottlesQuantity - 1)) *
                BottlesQuantity/2;
            // тогда разница между реальным и нормальным весом,
            // если ее поделить на разницу между тяжелой и нормальной таблеткой
            //даст номер бутылки с тяжелыми таблетками
            var heavyHumber = (totalWeight - normalPillWeight) / (HeavyPillWeight - NormalPillWeight);
            return (int)heavyHumber;
        }
    }
}
