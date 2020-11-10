using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter1
{
    //Напишите функцию, которая проверяет, является ли строка перестановкой палиндрома
    public class Task4
    {
        public static bool IsPalindromePermutation(string str)
        {
            var map = new Dictionary<char, int>();
            foreach (var c in str.ToLower().Where(c => c != ' '))
            {
                if (map.ContainsKey(c))
                {
                    map[c]--;
                }
                else
                {
                    map[c] = 1;
                }
            }

            return map.Values.Count(v => v == 1) <= 1;
        }

        // PERFECT
        // если нужно учитывать только буквы английского алфавита (меньше памяти)
        public static bool IsPalindromePermutation2(string str)
        {
            var frequencyTable = new int[26];
            foreach (var c in str)
            {
                var number = char.ToLower(c) - 'a';
                if (number >= 0 && number <= 25)
                {
                    frequencyTable[number]++;
                }
            }

            var oddFound = false;
            foreach (var charFrequency in frequencyTable)
            {
                if (charFrequency % 2 != 0)
                {
                    if (oddFound)
                    {
                        return false;
                    }

                    oddFound = true;
                }
            }

            return true;
        }

        // PERFECT
        // Нет особой разницы с решением [2]
        public static bool IsPalindromePermutation3(string str)
        {
            var countOdd = 0;
            var frequencyTable = new int[26];
            foreach (var number in str.Select(c => char.ToLower(c) - 'a').Where(number => number >= 0 && number <= 25))
            {
                frequencyTable[number]++;
                if (frequencyTable[number] % 2 == 1)
                {
                    countOdd++;
                }
                else
                {
                    countOdd--;
                }
            }

            return countOdd <= 1;
        }

        //PERFECT   (битовые операции, еще меньше памяти)
        public static bool IsPalindromePermutation4(string str)
        {
            var bitVector = 0;
            foreach (var number in str.Select(c => char.ToLower(c) - 'a').Where(n => n >= 0 && n <= 25))
            {
                var mask = 1 << number;
                if ((bitVector & mask) == 0) //  символ встретился нечетное кол-во раз
                {
                    bitVector |= mask; // ставим 1 в текущий бит
                }
                else
                {
                    bitVector &= ~mask; //обнуляем текущий бит
                }
            }
            // вектор мб равен 0 или иметь одну единственную 1
            // чтобы проверить единственную 1, необходимо вычесть из числа 1 и сделать логическое &
            // 1 в первом векторе стоит в наибольшем разряде (нули впереди отбрасываются)
            // в bitVector - 1 в этом разряде стоит 0, в остальных стоит 1
            // 0&1  в главном разряде дадут 0. Если 1 были в каких-то еще разрядах, то результату будет != 0
            return (bitVector & (bitVector - 1)) == 0;
        }
    }
}
