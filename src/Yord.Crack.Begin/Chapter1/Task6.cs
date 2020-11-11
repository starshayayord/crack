using System.Text;

namespace Yord.Crack.Begin.Chapter1
{
    // Сжатие строк с использованием счетчика повторяющихся символов
    // Если сжатая строка не становится короче, то возвращается исходная строка
    // Строка состоит из букв верхнего и нижнего регистра
    // PERFECT
    public class Task6
    {
        public static string Compress(string source)
        {
            var compressedSize = GetCompressedSize(source);
            if (compressedSize >= source.Length)
            {
                return source;
            }

            var sb = new StringBuilder();
            var count = 0;
            var previous = source[0];
            foreach (var c in source)
            {
                if (c == previous)
                {
                    count++;
                }
                else
                {
                    sb.Append($"{previous}{count}");
                    previous = c;
                    count = 1;
                }
            }

            sb.Append($"{previous}{count}");
            return sb.ToString();
        }

        private static int GetCompressedSize(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return 0;
            }

            var size = 0;
            var count = 0;
            var previous = source[0];
            foreach (var c in source)
            {
                if (c == previous)
                {
                    count++;
                }
                else
                {
                    size += 1 + count.ToString().Length;
                    previous = c;
                    count = 1;
                }
            }

            size += 1 + count.ToString().Length;
            return size;
        }
    }
}
