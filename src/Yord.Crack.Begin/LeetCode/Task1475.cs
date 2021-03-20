using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // prices[i] цена iтого товара. Есть спец скидка: покупаешь iый товар, получаешь скидку равную prices[j],
    // где j - мин индекс, где j>i и prices[j] <= prices[i], в противном случае скидки нет.
    // Вернуть массив финальных скидок
    public class Task1475
    {
        public static int[] FinalPrices(int[] prices)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < prices.Length; i++)
            {
                // если есть элементы без скидки и к ним можно применить скидку
                // пока не применим ко всем, к каким возможно - крутимся.
                //т.е. в стеке будут индексы всех чисел, для которых скидка еще не найден,
                // причем числа эти идут по возрастанию
                while (stack.Any() && prices[stack.Peek()] >= prices[i])
                {
                    prices[stack.Pop()] -= prices[i];
                }
                // всегда кладем текущий элемент в стек, чтоб потом найти для него скидку
                stack.Push(i);
            }

            return prices;
        }
    }
}
