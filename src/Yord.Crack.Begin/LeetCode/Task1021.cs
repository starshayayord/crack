using System.Text;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1021
    {
        // Валидная строка со скобками (пустая), т.е. () (A),
        // или A+B, где A и B  - валидные строки со скобками.
        // Строка примитивна, если не пустая и не существует варианта деления ее на A+B, где A и B - не пустые
        // Вернуть строку после удаления самых внешних скобок у каждого примитива.
        //(()())(()) -> ()()()
        //()() -> ""
        public static string RemoveOuterParentheses(string s)
        {
            StringBuilder sb = new StringBuilder();
            int flag = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    //если flag сразу == 0, значит  это первый символ (открывающаяся родительская скобка)
                    // и его надо пропустить. 
                    if (flag++ == 0)
                    {
                        continue;
                    }
                }
                else
                {
                    // Если при вычитании получили 0, значит это последняя закрывающаяся родительская скобка,
                    // такую надо пропустить
                    if (--flag == 0)
                    {
                        continue;
                    }
                }

                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
