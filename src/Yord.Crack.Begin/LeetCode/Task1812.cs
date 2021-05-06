namespace Yord.Crack.Begin.LeetCode
{
    // вернуть цвет клетки на шмахматной доске. Белая - true,  черная - false;
    public class Task1812
    {
        public static bool SquareIsWhite(string coordinates)
        {
            return (coordinates[0] - 'a' + coordinates[1] - '1') % 2 != 0;
        }
        
        // чтобы клетка была белой, надо, что она была не на (любой) диагонали
        public static bool SquareIsWhite2(string coordinates)
        {
            return coordinates[0]%2 != coordinates[1]%2;
        }
    }
}
