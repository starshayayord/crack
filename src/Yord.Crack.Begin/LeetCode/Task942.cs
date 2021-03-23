namespace Yord.Crack.Begin.LeetCode
{
    //Команды: I -  увеличить (A[i] < A[i+1]), D - уменьшить (A[i] > A[i+1]).N = s.Length
    // Вернуть любую перестановку [0,1,..N], чтобы правило выполнялось
    //
    public class Task942
    {
        public static int[] DiStringMatch(string S)
        {
            
            int n = S.Length;
            int[] r = new int[n];
            int l = 0;

            for (int i = 0; i < S.Length; i++)
            {
                //в следующей клетке нужен I, значит сейчас ставим меньшую
                if (S[i] == 'I')
                {
                    r[i] = l++;
                }
                // в следующей клеткке нужен D, значит ставим большую
                else
                {
                    r[i] = n--;
                }
            }

            r[S.Length] = l;// сравняется с n

            return r;
        }
    }
}
