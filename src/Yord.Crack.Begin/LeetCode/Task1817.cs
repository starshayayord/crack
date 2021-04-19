using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //[id, time]
    // вернуть массив длиной k, где элемент равен кол-ву юзеров,
    // у которых кол-во активных минут равно индексу (от 1) выходного массива
    public class Task1817
    {
        public static int[] FindingUsersActiveMinutes(int[][] logs, int k)
        {
            var uamMap = new Dictionary<int, HashSet<int>>();
            var answer = new int [k];
            for (var i = 0; i < logs.Length; i++)
            {
                var id = logs[i][0];
                var min = logs[i][1];
                if (uamMap.ContainsKey(id))
                {
                    uamMap[id].Add(min);
                }
                else
                {
                    uamMap[id] = new HashSet<int> {min};
                }
            }

            foreach (var (_, minArr) in uamMap)
            {
                answer[minArr.Count - 1]++;
            }

            return answer;
        }
    }
}
