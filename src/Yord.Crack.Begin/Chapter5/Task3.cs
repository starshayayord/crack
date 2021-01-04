using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter5
{
    // найти самую длинную последовательность единиц, если в числе мб заменен только один 0.
    public class Task3
    {
        public static int GetMaxSequence(int num)
        {
            var str = Convert.ToString(num, 2);
            var counter = 0;
            var currentCounter = str.First();
            var seqList = new List<Tuple<char, int>>();
            foreach (var c in str)
            {
                if (c != currentCounter)
                {
                    seqList.Add(new Tuple<char, int>(currentCounter, counter));
                    currentCounter = c;
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }
            seqList.Add(new Tuple<char, int>(currentCounter, counter));
            var maxSeq = 0;
            for (var i = 0; i < seqList.Count; i++)
            {
                if (seqList[i].Item1 != '1')
                {
                    continue;
                }

                var tempMax = seqList[i].Item2;
                //checkLeft
                var leftIndex = i - 1;
                if (leftIndex > 0)
                {
                    if (seqList[leftIndex].Item2 > 1)
                    {
                        tempMax++;//поменяли один ноль слева
                    }
                    else
                    {
                        tempMax++;//поменяли один ноль слева
                        if (leftIndex - 1 >= 0)
                        {
                            tempMax += seqList[leftIndex - 1].Item2;  // учли длину слева от 1 нуля
                        }
                    }
                }

                if (tempMax > maxSeq)
                {
                    maxSeq = tempMax;
                }
                
                //checkright
                tempMax =  seqList[i].Item2;
                var rightIndex = i + 1;
                if (rightIndex < seqList.Count)
                {
                    if (seqList[rightIndex].Item2 > 1)
                    {
                        tempMax++;//поменяли один ноль справа
                    }
                    else
                    {
                        tempMax++;//поменяли один ноль справа
                        if (rightIndex + 1  < seqList.Count)
                        {
                            tempMax += seqList[rightIndex + 1].Item2;  // учли длину справа от 1 нуля
                        }
                    }
                }

                if (tempMax > maxSeq)
                {
                    maxSeq = tempMax;
                }
            }

            return maxSeq;
        }
    }
}
