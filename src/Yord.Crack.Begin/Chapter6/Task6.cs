namespace Yord.Crack.Begin.Chapter6
{
    // Все голубоглазые должны покинуть остров. Самолет каждый вечер в 20:00
    // Человек видит цвет глаз других, не знает собственный (говорить нельзя)
    // Кол-во голубоглазых неизвестно, но больше 0
    // Сколько нужно, чтоб все голубоглазые уехали?
    public class Task6
    {
        // Пусть N=1. Т.к. голубоглазых >0, значит если я не вижу их, значит это 1. Покидаем за день

        // Пусть N<=2. Т.К. голубоглазых >0. Если бы N=1, то он улетел бы вчера,
        // значит голубоглазых столько, сколько вижу (1) и еще я (1) N = 2. Улетаем одним самолетом за 2 дня

        // Пусть N <=3. Т.К. голубоглазых >0, N!=1, т.к. я вижу двоих
        // если бы N=2, то первый день они бы прождали, второй бы поняли, что их >1 и обе бы улетели
        // но я вижу двоих, значит нас минимум 3

        // значит если N неизвестно, то через N ночей я пойму, что вижу (N-1) и они не улетели накануне, значит нас N.
        // Через N ночей улетаем все одним самолетом
    }
}
