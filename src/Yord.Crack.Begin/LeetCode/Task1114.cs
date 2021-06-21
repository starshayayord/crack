using System;
using System.Threading;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1114
    {
        public class Foo
        {
            private System.Threading.Semaphore s1 = new System.Threading.Semaphore(0, 1);
            private System.Threading.Semaphore s2 = new System.Threading.Semaphore(0, 1);

            public Foo()
            {
            }

            public void First(Action printFirst)
            {
                printFirst();
                s1.Release();
            }

            public void Second(Action printSecond)
            {
                s1.WaitOne();
                printSecond();
                s2.Release();
            }

            public void Third(Action printThird)
            {
                s2.WaitOne();
                printThird();
            }
        }
    }
}
