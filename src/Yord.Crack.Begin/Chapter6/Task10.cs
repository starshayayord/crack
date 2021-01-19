using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter6
{
    // Имеется 1000 бутылок с лимонадом, одна отравлена. Есть 10 тестовых полосок.
    // Даже одна капля яда делает полоску непригодной для дальшейшего использования,
    // но одновременно можно нанести на нее бесконечное число капель.
    // Полоска мб использована бесконечное число раз, если на нее не было нанесено яда.
    // Испытания можно проводить 1 раз в день, получение результата занимает 7 дней.
    // Найти отравленную бутылку за минимальное кол-во дней
    public class Task10
    {
        private const int BottlesCount = 1000;
        private const int StripsCount = 10;
        private static readonly Random Random = new Random();
        private readonly List<Strip> _testStrips;
        private readonly List<Bottle> _bottles;
        public int PoisonedBottleNumber;

        private class Strip
        {
            public bool IsPositive;

            public void Drip(Bottle bottle)
            {
                if (bottle.IsPoisoned)
                {
                    IsPositive = true;
                }
            }
        }

        private class Bottle
        {
            public int Number { get; set; }

            public bool IsPoisoned { get; set; }
        }

        public Task10()
        {
            PoisonedBottleNumber = Random.Next(1, BottlesCount);
            _testStrips = GenerateStrips();
            _bottles = GenerateBottles();

            List<Strip> GenerateStrips()
            {
                var strips = new List<Strip>();
                for (var i = 0; i < StripsCount; i++)
                {
                    strips.Add(new Strip());
                }

                return strips;
            }

            List<Bottle> GenerateBottles()
            {
                var bottles = new List<Bottle>();
                for (var i = 0; i < BottlesCount; i++)
                {
                    bottles.Add(new Bottle
                    {
                        Number = i + 1,
                        IsPoisoned = i + 1 == PoisonedBottleNumber
                    });
                }

                return bottles;
            }
        }


        public int FindBottle()
        {
            foreach (var bottle in _bottles)
            {
                TestBottle(bottle);
            }

            return CheckResults();
        }

        // Всего 1000 бутылок и 10 полосок. Попытаемся закодировать номер каждой бутылки в двоичном виде
        // 2^10 = 1024<1000, т.е. необходимо как раз 10 разрядов, чтоб закодировать 1000 чисел
        // Если в заданном разряде 1, то капаем на эту по счету полоску, иначе - пропускаем
        // Например число 2 - это 0000000010, т.е. капаем только один раз на вторую полоску, пропустив первую
        private void TestBottle(Bottle bottle)
        {
            var n = bottle.Number;
            var stripIndex = 0;
            while (n > 0)
            {
                var shouldDrip = (n & 1) == 1;
                if (shouldDrip)
                {
                    _testStrips[stripIndex].Drip(bottle);
                }

                stripIndex++;
                n >>= 1;
            }
        }

        // Проверяем полоски, составляя число
        // Если полоска окрасилась ядом, значит в этом разряде единица, иначе - ноль
        // Получаем двоичный код номера отравленной бутылки
        private int CheckResults()
        {
            var number = 0;
            for (var i = 0; i < StripsCount; i++)
            {
                var strip = _testStrips[i];
                if (strip.IsPositive)
                {
                    number |= 1 << i;
                }
            }

            return number;
        }
    }
}
