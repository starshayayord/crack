using System;
using System.Linq;

namespace Yord.Crack.Begin.Chapter1
{
    // Функция проверки, находятся ли строки в одной модификации друг от друга
    // Модификации: удаление/замена/добавление символа
    // строки содержат только буквы англиского алфавита в нижнем регистре
    public class Task5
    {
        //PERFECT
        public static bool IsOneModification3(string str1, string str2)
        {
            if (Math.Abs(str1.Length - str2.Length) > 1)
            {
                return false;
            }

            var longer = str1.Length > str2.Length ? str1 : str2;
            var shorter = str1.Length > str2.Length ? str2 : str1;
            var i = 0;
            var j = 0;
            var foundDiff = false;
            while (i < longer.Length && j < shorter.Length)
            {
                if (longer[i] != shorter[j])
                {
                    if (foundDiff)
                    {
                        return false;
                    }
                    
                    if (longer.Length == shorter.Length)
                    {
                        j++;
                    }
                    foundDiff = true;
                }
                else
                {
                    j++;
                }
                i++;
            }

            return longer.Length != shorter.Length || foundDiff;
        }
        
        //PERFECT
        public static bool IsOneModification2(string str1, string str2)
        {
            //замена одного символа
            
            if (str1.Length == str2.Length)
            {
                var foundDiff = false;
                for (var i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        if (foundDiff)
                        {
                            return false;
                        }

                        foundDiff = true;
                    }
                }

                return foundDiff;
            }

            //удаление одного символа
            if (str1.Length - 1 == str2.Length)
            {
                return IsOneInsert(str1, str2);
            }

            //добавление одного символа
            if (str1.Length + 1 == str2.Length)
            {
                return IsOneInsert(str2, str1);
            }

            return false;
        }

        private static bool IsOneInsert(string longStr, string shortStr)
        {
            var i = 0;
            var j = 0;
            while (i < longStr.Length && j < shortStr.Length)
            {
                if (longStr[i] != shortStr[j])
                {
                    if (i != j)
                    {
                        return false;
                    }

                    i++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            return true;
        }
        
        public static bool IsOneModification(string str1, string str2)
        {
            var lengthDiff = str1.Length - str2.Length;
            if (lengthDiff < -1 || lengthDiff > 1)
            {
                return false;
            }
            var frequencyTable = new int[26];
            foreach (var number in str1.Select(c => char.ToLower(c) - 'a').Where(n => n >= 0 && n <= 25))
            {
                frequencyTable[number]++;
            }

            foreach (var number in str2.Select(c => char.ToLower(c) - 'a').Where(n => n >= 0 && n <= 25))
            {
                frequencyTable[number]--;
            }
            if (frequencyTable.Any(frequency => frequency < -1 || frequency > 1))
            {
                return false;
            }

            var diffFound = 0;
            foreach (var f in frequencyTable)
            {
                if (f < -1 || f > 1)
                {
                    return false;
                }

                if (f != 0)
                {
                    diffFound++;
                }
            }
            //строки одной длины, только модификация (должно быть ровно 2 отличия)
            if (lengthDiff == 0)
            {
                return diffFound == 2;
            }
            //строки разной, только удаление или добавление (должно быть ровно 1 отличик)
            return diffFound == 1;
        }
    }
}
