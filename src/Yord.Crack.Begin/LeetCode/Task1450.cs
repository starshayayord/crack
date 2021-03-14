namespace Yord.Crack.Begin.LeetCode
{
    //startTime[i] - начало работы, endTime[i] - конец работы. Сколько студентов было занято в queryTime
    public class Task1450
    {
        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int r = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                {
                    r++;
                }
            }

            return r;
        }
    }
}
