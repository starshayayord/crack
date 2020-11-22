using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter3
{
    // реализовать метод сортировки стека (псамый большой Pop() первым)
    // можно использовать только один дополнительный стек, перекладывать зачения в другие структуры данных нельзя
    public class Task5
    {
        public static Stack<int> Sort(Stack<int> stack)
        {
            var sorted = new Stack<int>();
            while (stack.Any())
            {
                // берем значение из несортированного стека, пока есть, что брать
                var tmp = stack.Pop();
                // если оно больше или равно верхушке сортированного, то кладем его в сортированный стек 
                // если оно меньше, то возвращаем из сортированного стека в несортированный
                // пока это значение не станет больше или равно верхушке
                while (sorted.Any() && tmp < sorted.Peek())
                {
                    stack.Push(sorted.Pop());
                }
                sorted.Push(tmp);
            }

            return sorted;
        }
    }
}
