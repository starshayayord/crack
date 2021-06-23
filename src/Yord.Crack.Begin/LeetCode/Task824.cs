using System;
using System.Collections.Generic;
using System.Text;

namespace Yord.Crack.Begin.LeetCode
{
    //если слово начинается с a, e, i, o, or u), то добавить "ma" в конец
    //иначе взять первую букву, отправить ее в конец, добавить "ma" в конец
    // добавить столько "a" в конец каждого слова, какой индекс у слова в предложении, начиная с 1
    public class Task824
    {
        public static string ToGoatLatin(string sentence)
        {
            var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            var sb = new StringBuilder();
            var words = sentence.Split();
            for (var i = 0; i < words.Length; i++)
            {
                sb.Append(vowels.Contains(words[i][0]) 
                    ? words[i]+"ma"
                    : words[i][1..] + new string(new[]{words[i][0], 'm', 'a'}));
                
                var aArr = new char[i + 1];
                Array.Fill(aArr, 'a');
                sb.Append(new string(aArr));
                if (i != words.Length - 1)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
