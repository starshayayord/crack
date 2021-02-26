namespace Yord.Crack.Begin.LeetCode
{
    public interface Task1603
    {
        public class ParkingSystem
        {
            private readonly int[] slots;

            public ParkingSystem(int big, int medium, int small)
            {
                slots = new[] {big, medium, small};
            }

            public bool AddCar(int carType)
            {
                return slots[carType - 1]-- > 0;
            }
        }
    }
}
