using System.Linq;
using System.Text;

namespace Yord.Crack.Begin.Chapter1
{
    // Напишите метод, заменяющий все пробелы в строке на символы '%20'
    public class Task3
    {
        private const string SpaceReplacer = "%20";
        private const char Space = ' ';
        

        // [PERFECT1]
        public static string ReplaceSpaces1(string source)
        {
            var spaces = source.Count(c => c == Space);
            var newStr = new char[source.Length - spaces + spaces * SpaceReplacer.Length];
            var newStrIndex = 0;
            foreach (var c in source)
            {
                if (c != Space)
                {
                    newStr[newStrIndex] = c;
                    newStrIndex++;
                }
                else
                {
                    newStr[newStrIndex++] = '%';
                    newStr[newStrIndex++] = '2';
                    newStr[newStrIndex++] = '0';
                }
            }
            return new string(newStr);
        }

        //считаем, что в строке уже сохранено дополнительное место под будущие %20 (пустые места в конце массива)
        //и длина исходной строки известна заранее
        //Например: ("Test test  ", 9) -> ("Test%20test")
        //[PERFECT2]
        public static char[] ReplaceSpaces2(char[] source, int sourceLength)
        {
            var spaceCount = 0;
            // считаем пробелы, которые надо заменить в ИСХОДНОЙ строке (не доходя до пустых мест)
            for (var i = 0; i < sourceLength; i++)
            {
                if (source[i] == Space)
                {
                    spaceCount++;
                }
            }

            // каждый пробел(1 символ) заменяется на %20(3 символа)
            // индексация с 0, значит добавим -1;
            var newEndIndex = (sourceLength + spaceCount * 2) - 1; 
            //так как пустые места содержатся в конце, то необходимо заменять с КОНЦА строки
            for (var i = sourceLength - 1; i >= 0; i--)
            {
                if (source[i] == Space)
                {
                    source[newEndIndex--] = '0';
                    source[newEndIndex--] = '2';
                    source[newEndIndex--] = '%';
                }
                else
                {
                    source[newEndIndex--] = source[i];
                }
            }

            return source;
        }
        
        public static string ReplaceSpaces3(string source)
        {
            var sb = new StringBuilder();
            foreach (var c in source)
            {
                if (c.Equals(Space))
                {
                    sb.Append(SpaceReplacer);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
