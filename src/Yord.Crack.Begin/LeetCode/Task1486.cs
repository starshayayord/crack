namespace Yord.Crack.Begin.LeetCode
{
    // Получить массив в котором nums[i] = start + 2*i  длиной N
    // Вернуть XOR всех элементов
    public class Task1486
    {
        // есть последовательность start, start+2 ... start+2(n-1).  Последний бит во всех цифрах одинаковый:
        // если это 0, т.е. N -  четное, тогда последний бит результата тоже 0, иначе - 1.
        // Сдвигаем все числа на >>1  start/2, start/2+1...start/2+(n-1).
        // Нужно посчитать XOR этих чисел и добавить посдений бит.
        // Удобно сделать start - четным, т.к. 2x^(2x+1)=1.
        // Если start нечетный, то необходимо вычислить (start-1) ^ (start-1)^start^(start+1)^...^(start+(n-1)),
        // чтобы сделать его четным, т.е start, start+1, ..., start+(n-1) , но start=start-1;
        //каждая полная пара их правила дает 1, у нас n/2 пар. каждая дает 1 к результату.
        //Нужно не забывать про последнее число, которое не имеет пары, если оно есть.


        //Т.е. для четных start и n: start^start+1^...start+(n-1) = 1^1^1... Т.к.  x ^ x = 0 и  x ^ 0 = x,
        //то результат 0, если n/2 - четное, и 1, если нечетное.
        //Чтоб применить это к нечетному start, зададим новый start=start-1.
        // start - 1 ^ start ^ start + 1 ^ start + 2 ^ ... ^ start + n - 2 ^ start + n - 1
        // = start - 1 ^ 1 ^ 1 ^ ... ^ 1
        // Умножая эту последовательность на 2 получим оригинальную


        //Возвращает XOR для последовательности start + 2*i до n
        public static int XorOperation(int n, int start)
        {
            bool startIsEven = start % 2 == 0;
            bool nIsEven = n % 2 == 0;
            // Если start - четное, то результат будет четный.
            // Даже для нечетного start, если n - четное, то последние единички в числах при XOR дадут 0
            // т.е. у этом случае последний бит - 0;
            if (startIsEven || nIsEven)
            {
                // чтобы подогнать start^start+2^start+4... под s^s+1^s+2.., где пары  s^s+1 => 1, делим s на 2.
                // в конце умножим на 2
                return 2 * Xor(n, start >> 1);
            }

            // если все нечетное, то надо не забыть приклеить к результату единицу.т.к. она не скомпенсирована
            // мы потеряли ее, когда делили на 2
            return 2 * Xor(n, start >> 1) + 1;
        }

        // Возвращает XOR для последовательности k + i до n
        private static int Xor(int n, int k)
        {
            bool kIsEven = k % 2 == 0;
            if (kIsEven)
            {
                return XorEven(n, k);
            }

            // если число нечетное, то сделаем операцию для четного (k-1),
            // т.е. расширим последовательно до  (k - 1) ^ (k - 1) (самоуничтожаются), а (k - 1) ^ (k - 1) ^ k = k
            //k - 1 ^ k - 1 ^ k ^ k + 1 ^ k + 2 ^ ... ^ k + n - 2 ^ k + n - 1 = k - 1 ^ 1 ^ 1 ^ ... ^ 1
            return (k - 1) ^ XorEven(n + 1, k - 1);
        }

        // работает для четной K. Возвращает XOR для последовательности k + i до n
        private static int XorEven(int n, int k)
        {
            bool nIsEven = n % 2 == 0;
            int num1sToXor = n >> 1; // количество пар единиц
            bool num1sToXorIsEven = num1sToXor % 2 == 0;
            //если количество пар - четное, то все единицы самоуничтожились(1^1). иначе осталась одна из нечетной пары
            int r = num1sToXorIsEven ? 0 : 1;
            if (nIsEven)
                return r;
            // если N было нечетным, значит последнему числу не хватило пары
            return (k + n - 1) ^ r;
        }
/*
        public int XorOperation(int n, int start)
        {
            if ((n % 2 == 0) || (start % 2 == 0))
            {
                return 2 * Xor(n, start >> 1);
            }

            return 2 * Xor(n, start >> 1) + 1;
        }

        private int Xor(int n, int s)
        {
            return s % 2 == 0 ? XorEven(n, s) : (s - 1) ^ (XorEven(n + 1, s - 1));
        }

        private int XorEven(int n, int s)
        {
            int r = (n >> 1) % 2 == 0 ? 0 : 1;
            return n % 2 == 0 ? r : (s + n - 1) ^ r;
        }
        */
    }
}
