using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //items[i] = [type, color, name]. вернуть кол-во айтемов, попадющих под 
    public class Task1773
    {
        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var idx = ruleKey switch
            {
                "type" => 0,
                "color" => 1,
                _ => 2
            };
            return items.Count(i => i[idx] == ruleValue);
        }
    }
}
