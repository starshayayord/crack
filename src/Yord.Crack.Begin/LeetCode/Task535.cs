using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task535
    {
        public class Codec
        {
            
            private const string Domain = "http://tinyurl.com/";
            private Dictionary<int, string> map = new Dictionary<int, string>();
            public string encode(string longUrl)
            {
                var shortUrl = longUrl.GetHashCode();
                while (map.ContainsKey(shortUrl))
                {
                    shortUrl = shortUrl.GetHashCode();
                }
                map.Add(shortUrl, longUrl);
                return Domain + shortUrl;
            }

            
            public string decode(string shortUrl)
            {
                shortUrl = shortUrl.Replace(Domain, "");
                return map[int.Parse(shortUrl)];
            }
        }
    }
}
