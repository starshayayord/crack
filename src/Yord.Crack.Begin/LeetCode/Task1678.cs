using System.Text;

namespace Yord.Crack.Begin.LeetCode
{
    // Пармер интерпретирует команды.  Команда состоит из "G", "()", "(al)" в каком-то порядке.
    // Интерпретация "G" -> "G", "()" -> "o", "al" => "al"l 
    public class Task1678
    {
        public static string Interpret(string command)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < command.Length;)
            {
                switch (command[i])
                {
                    case 'G':
                        sb.Append(command[i]);
                        i++;
                        break;
                    case '(':
                        if (command[i + 1] == ')')
                        {
                            sb.Append('o');
                            i += 2;
                        }
                        else
                        {
                            sb.Append("al");
                            i += 4;
                        }

                        break;
                }
            }

            return sb.ToString();
        }
        
        public static string Interpret_Regex(string command)
        {
            return command.Replace("()", "o").Replace("(al)", "al");
        }
    }
}
