using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // дан неубывающий массив. вернуть квадраты по возрастанию
    public class Task977
    {
        public static int[] SortedSquares(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            // заполняем с конца
            var i = nums.Length - 1;
            var newArr = new int[nums.Length];
            
            // пока границы не зашли одна за другую, выбираем большее числи (справа или слева)
            // и ставим его на последнее незаполненное место.
            // затем сдвигаем использованную (левую или правую) границу ближе к центру
            while (left <= right)
            {
                //если левый больше, то на место последнего надо поставить его квадрат и сдвинуть левый вправо
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    newArr[i--] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    // иначе на место последнего ставим квадрат правого и сдвигаем правый влево
                    newArr[i--] = nums[right] * nums[right];
                    right--;
                }
            }

            return newArr;
        }

        public static int[] SortedSquaresStack(int[] nums)
        {
            var r = new int[nums.Length];
            var s = new Stack<int>();
            var ki = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    s.Push(-1 * nums[i]);
                }
                else
                {
                    while (s.Any() && s.Peek() <= nums[i])
                    {
                        var n = s.Pop();
                        r[ki++] = n * n;
                    }

                    r[ki++] = nums[i] * nums[i];
                }
            }

            while (s.Any())
            {
                var n = s.Pop();
                r[ki++] = n * n;
            }

            return r;
        }
    }
}
