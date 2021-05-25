using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //true, если все буквы алфавита появляются хотя бы раз
    //1 <= sentence.length <= 1000
    public class Task1832
    {
        public static bool CheckIfPangram(string sentence)
        {
            var h = new HashSet<char>();
            foreach (var c in sentence)
            {
                h.Add(c);
                if (h.Count == 26)
                {
                    return true;
                }
            }

            return false;
        }
        
        public static bool CheckIfPangram2(string sentence)
        {
            var h = new int [26];
            foreach (var c in sentence)
            {
                h[c - 'a']++;
            }

            return h.All(i => i >0);
        }
    }
}
