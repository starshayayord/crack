using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1700
    {
        public static int CountStudents2(int[] students, int[] sandwiches)
        {
            //[0] <- count students pref 0
            //[1] <- count students pref 1
            var pref = new int[2];
            foreach (var student in students)
            {
                pref[student]++;
            }

            int s = 0;
            //пока не проверили все сэндвичи, начиная с верхнего
            while (s < sandwiches.Length)
            {
                //если для этого верхнего сэндвича есть студент, то проходим дальше
                if (pref[sandwiches[s]] > 0)
                {
                    pref[sandwiches[s]]--;
                }
                //иначе это сендвич сверху пачки, который некому взять
                else
                {
                    break;
                }

                s++;
            }

            return sandwiches.Length - s;//сколько осталось сендвичей в пачке
        }
        public static int CountStudents(int[] students, int[] sandwiches)
        {
            var queue = new Queue<int>();
            foreach (var student in students)
            {
                queue.Enqueue(student);
            }

            var c = 0;
            var sIdx = 0;
            while (c<queue.Count && sIdx<sandwiches.Length)
            {
                var curStudent = queue.Dequeue();
                if (sandwiches[sIdx] == curStudent)
                {
                    c = 0;
                    sIdx++;
                }
                else
                {
                    queue.Enqueue(curStudent);
                    c++;
                }
            }

            return queue.Count;
        }
    }
}
