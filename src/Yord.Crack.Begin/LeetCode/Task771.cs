using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task771
    {
        public static int NumJewelsInStonesTime(string jewels, string stones) {
            var map = new Dictionary<char, int>();
            foreach(var c in jewels)
            {
                map[c] = 0;
            }
            var jNum = 0;
        
            foreach(var c in stones)
            {
                if (map.ContainsKey(c))
                {
                    jNum++;
                }
            }
            return jNum;
        }
        
        public static int NumJewelsInStonesSpace(string jewels, string stones) {
            var a = new int[58];
            foreach(var c in jewels)
            {
                var n = c - 65;
                a[n] = 1;
            }
            var jNum = 0;
        
            foreach(var c in stones)
            {
                var n = c - 65;
                if (a[n] > 0)
                {
                    jNum++;
                }
            }
            return jNum;
        }
        
        public static int NumJewelsInStonesSpace2(string jewels, string stones) {
            long flag = 0;
            foreach (char c  in jewels) {
                int i = СharToIndex(c);
                // имеем единички на позициях драгоценных камней
                flag |= 1L << i;
            }
        
            int s = 0;
            foreach (char c in stones) {
                int i = СharToIndex(c);
                // если на этой позиции 1 в числе, то & больше 0, значит это драгоценный камень
                if ((flag & (1L << i)) > 0 ) {
                    s++;
                }
            }
            return s;
        }
    
        private static int СharToIndex(char c)
        {
            return 'Z' >= c && c >= 'A' ? c - 'A' : c - 'a' + 26;
        }
    }
}
