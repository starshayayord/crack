namespace Yord.Crack.Begin.Chapter1
{
    // при наличии метода isSubstring написать метод, проверяющий получена ли одна строка циклическим сдвигом другой
    // можно использовать только 1 вызов метода isSubstring
    public class Task9
    {
        public static bool IsRotated(string str1, string str2)
        {
            // если строчка ротирована, значит какая-то ее часть слева отрезана и поставлена справа
            // тогда мы можем к кусочку справа поставить еще копию строки, чтоб пристыковать правую и левую части
            // ABCDEF  ротируем в CDEFAB, значит правая часть AB уехала влево 
            // тогда присоединим к ней копию строки, которая начинается с левой части CDEF[AB]_[CDEF]AB
            var mergedString = str1 + str1;
            return mergedString.Contains(str2);
        }
    }
}
