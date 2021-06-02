using System;

namespace Yord.Crack.Begin.LeetCode
{
    //[кол-во коробок, кол-во штук в коробке], можно положить X коробок. Вернуть макс кол-во штук в грузовике
    //1 <= numberOfBoxesi, numberOfUnitsPerBoxi <= 1000
    public class Task1710
    {
        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            var unitBoxes = new int[1001];
            foreach (var boxType in boxTypes)
            {
                unitBoxes[boxType[1]] += boxType[0];
            }

            var r = 0;
            for (int i = 1000; i > 0 && truckSize > 0; i--)
            {
                if (unitBoxes[i] == 0)
                {
                    continue;
                }

                var canGetBoxes = Math.Min(truckSize, unitBoxes[i]);
                truckSize -= canGetBoxes;
                r += i * canGetBoxes;
            }

            return r;
        }
    }
}
