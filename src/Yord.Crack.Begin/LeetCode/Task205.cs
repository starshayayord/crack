namespace Yord.Crack.Begin.LeetCode
{
    // если символы X мб заменены символами Y, значит строки изоморфны
    public class Task205
    {
        public static bool IsIsomorphic(string s, string t)
        {
            var mapS = new int[256];
            var mapT = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                
                if (mapS[s[i]] != mapT[t[i]])
                {
                    return false;
                }
                // мапим для символов, которые должны соответствовать какое-то уникальное число (одинаковое)
                //если они встретятся еще раз и не будут иметь одно уникальное число, значит маппинг нарушен
                mapS[s[i]]=i+1; //+1 чтоб с i=0 тоже работало
                mapT[t[i]]=i+1;
            }

            return true;
        }
    }
}
