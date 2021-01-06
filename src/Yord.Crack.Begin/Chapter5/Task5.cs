using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter5
{
    // объясните, что делает код ((n & (n-1)) == 0) 
    public class Task5
    {
        // при вычитании единицы, инвертируются все нули и первая единица
        // утверждение верно, только когда единица одна единственная в числе
        // получается n и n-1 не содержат единиц в общих разрядах
        // значит N имеет вид 1000...0, т.е. это степень двойки
        // & с 0 равно нулю, так что N  мб равно 0
        public static List<int> GetNumbersTill(int max)
        {
            var r = new List<int>();
            for (var n = 0; n <= max; n++)
            {
                if ((n & (n - 1)) == 0)
                {
                    r.Add(n);
                }
            }

            return r;
        }
    }
}
