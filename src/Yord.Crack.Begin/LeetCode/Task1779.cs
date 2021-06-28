using System;

namespace Yord.Crack.Begin.LeetCode
{
    //среди точек, которые имеют ту же координату х или у. вернуть наименьший индекс самой близкой точки 
    public class Task1779
    {
        public static int NearestValidPoint(int x, int y, int[][] points)
        {
            var minDistance = int.MaxValue;
            var minIndex = -1;
            for (var i = 0; i< points.Length; i++)    
            {
                if (points[i][0] == x)
                {
                    var distance = Math.Abs(points[i][1] - y);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        minIndex = i;
                    }
                    continue;
                }
                if (points[i][1] == y)
                {
                    var distance = Math.Abs(points[i][0] - x);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }
    }
}
