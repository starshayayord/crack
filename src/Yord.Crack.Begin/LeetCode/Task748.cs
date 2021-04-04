namespace Yord.Crack.Begin.LeetCode
{
    // найти первое самое короткое слово,которое покрывает все буквы в первом вне зависимости от регистра
    public class Task748
    {
        public static string ShortestCompletingWord_Math(string licensePlate, string[] words)
        {
            // каждой букве присваиваем простое число.
            // Если в итоге произведение делится нацело на произведение из номера, значит слово подходит
            var primes = new[]
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103
            };
            long source = 1;
            for (int i = 0; i < licensePlate.Length; i++)
            {
                if (licensePlate[i] >= 'a' && licensePlate[i] <= 'z' ||
                    licensePlate[i] >= 'A' && licensePlate[i] <= 'Z')
                {
                    var c = char.ToLower(licensePlate[i]);
                    source *= primes[c - 'a'];
                }
            }

            string s = null;
            for (int i = 0; i < words.Length; i++)
            {
                long t = 1;
                for (int j = 0; j < words[i].Length; j++)
                {
                    t *= primes[words[i][j] - 'a'];
                }

                if (t % source == 0 && (s == null || s.Length > words[i].Length))
                {
                    s = words[i];
                }
            }

            return s;
        }

        public static string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var source = new int [26];
            for (int i = 0; i < licensePlate.Length; i++)
            {
                if (licensePlate[i] >= 'a' && licensePlate[i] <= 'z' ||
                    licensePlate[i] >= 'A' && licensePlate[i] <= 'Z')
                {
                    var c = char.ToLower(licensePlate[i]);
                    source[c - 'a']++;
                }
            }

            string s = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                var t = new int [26];
                for (int j = 0; j < words[i].Length; j++)
                {
                    t[words[i][j] - 'a']++;
                }

                bool contains = true;
                for (int j = 0; j < source.Length; j++)
                {
                    if (t[j] - source[j] < 0)
                    {
                        contains = false;
                    }
                }

                if (contains && (s == string.Empty || words[i].Length < s.Length))
                {
                    s = words[i];
                }
            }

            return s;
        }
    }
}
