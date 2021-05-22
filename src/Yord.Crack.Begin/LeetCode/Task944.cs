namespace Yord.Crack.Begin.LeetCode
{
    // строки одинаковой длины друг под другом. удалить колонки, которые не отсортированы по  убыванию
    //
    public class Task944
    {
        public static int MinDeletionSize(string[] strs)
        {
            var toDel = 0;
            for (var i = 0; i < strs[0].Length; i++)
            {
                for (var j = 1; j < strs.Length; j++)
                {
                    if (strs[j-1][i] > strs[j][i])
                    {
                        toDel++;
                        break;
                    }
                }
            }

            return toDel;
        }
    }
}
