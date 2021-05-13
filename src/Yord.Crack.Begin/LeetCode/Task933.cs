using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task933
    {
        //вернуть кол-во коллов в последние 3000 секунд
        public class RecentCounter
        {
            private LinkedList<int> _calls;
            public RecentCounter()
            {
                _calls = new LinkedList<int>();
            }

            public int Ping(int t)
            {
                _calls.AddLast(t);
                while (_calls.Last.Value - _calls.First.Value > 3000)
                {
                    _calls.RemoveFirst();
                }
                return _calls.Count;
            }
        }
    }
}
