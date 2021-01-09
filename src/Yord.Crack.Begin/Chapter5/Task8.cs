using System;

namespace Yord.Crack.Begin.Chapter5
{
    // Содержимое монохромного экрана хранится в одномерном массиве байтов
    // (т.е. в одном байте содержится информация о восьми соседних пикселях).
    // Ширина изображения кратна 8 (т.е. байты не переходят между столбцами)
    // Высоту экрана можно рассчитать, зная длину массива и ширину экрана.
    // Функция должна рисовать горизонтальную линию из точки х1,y в точку x2,y
    public class Task8
    {
        private const byte FullByte = 255;
        public static void DrawLine(byte[] screen, int width, int x1, int x2, int y)
        {
            var skipRows = (width / 8) * y;//пропустить строки, высота в которых не равна Y
            
            var startOffset = x1 % 8; //сколько битов пропустить слева в первом байте
            var firstFullByte = skipRows + x1 / 8; //первый байт, который надо заполнить полностью
            //если в первом байте есть каике-то пропуски битов, то первым полностью заполним только следующий
            if (startOffset != 0)
            {
                firstFullByte++;
            }

            var endOffset = x2 % 8;// координата последнего заполненного бита в последнем байте
            var lastFullByte = skipRows + x2 / 8;//последний байт, который надо заполнить полностью
            // если последний бит заполнен не полностью, то последним полностью заполним предыдущий
            if (endOffset != 7)
            {
                lastFullByte--;
            }
            //заполняем полные байты
            for (var b = firstFullByte; b <= lastFullByte; b++)
            {
                screen[b] = 0xFF;
            }

            var startByteMask = 0xFF >> startOffset;
            var endByteMask = ~(0xFF >> (endOffset + 1));
            if (x1 / 8 == x2 / 8) //если начало и конец в одном байте
            {
                var byteMask = (byte) (startByteMask & endByteMask);
                screen[lastFullByte - 1] |= byteMask;
            }
            else //начало и конец в разных байтах
            {
                if (startOffset != 0) // первый байт заполнен не полностью
                {
                    screen[firstFullByte - 1] |= (byte) startByteMask;
                }

                if (endOffset != 7) // последний байт заполнен не полностью
                {
                    screen[lastFullByte + 1] |= (byte) endByteMask;
                }
            }
        }
    }
}
