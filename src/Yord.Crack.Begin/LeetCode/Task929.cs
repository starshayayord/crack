using System.Collections.Generic;
using System.Text;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task929
    {
        public static int NumUniqueEmails2(string[] emails)
        {
            var hs = new HashSet<string>();
            var sb = new StringBuilder();
            foreach (var email in emails)
            {
                sb.Clear();
                var addIdx = 0;
                for (var i = 0; i < email.Length; i++)
                {
                    switch (email[i])
                    {
                        case '.':
                            sb.Append(email.Substring(addIdx, i - addIdx));
                            addIdx = i + 1;
                            break;
                        case '+':
                        {
                            sb.Append(email.Substring(addIdx, i - addIdx));
                            while (email[i] != '@')
                            {
                                i++;
                            }
                            addIdx = i;
                            i--;
                            break;
                        }
                    }

                    if (email[i] != '@') continue;
                    sb.Append(email.Substring(addIdx, email.Length - addIdx));
                    break;

                }

                hs.Add(sb.ToString());
            }

            return hs.Count;
        }

        public static int NumUniqueEmails(string[] emails)
        {
            var hs = new HashSet<string>();
            foreach (var email in emails)
            {
                var parsedEmail = new List<char>();
                var shouldIgnore = false;
                var isDomain = false;
                foreach (var c in email)
                {
                    if (c == '@')
                    {
                        shouldIgnore = false;
                        isDomain = true;
                    }

                    if (shouldIgnore || (c == '.' && !isDomain))
                    {
                        continue;
                    }

                    if (c == '+')
                    {
                        shouldIgnore = true;
                        continue;
                    }


                    parsedEmail.Add(c);
                }

                hs.Add(new string(parsedEmail.ToArray()));
            }

            return hs.Count;
        }
    }
}
