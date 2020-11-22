using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter3
{
    // очередь из двух стеков
    public class Task4
    {
        public class QueueStack<T>
        {
            private Stack<T> _dequeueStack;
            private Stack<T> _enqueueStack;

            public QueueStack()
            {
                _dequeueStack = new Stack<T>();
                _enqueueStack = new Stack<T>();
            }

            public void Enqueue(T value)
            {
                _enqueueStack.Push(value);
            }

            //когда нужно достать из очереди, то переклдываем из первого стека во второй
            // тем самым делая порядок обратным
            // повторное перекладывание произойдет только когда вторая очередь будет извлечена вся
            public T Dequeue()
            {
                ToDequeueIfNeed();
                return _dequeueStack.Pop();
            }

            public T Peek()
            {
                ToDequeueIfNeed();
                return _dequeueStack.Peek();
            }

            private void ToDequeueIfNeed()
            {
                if (!_dequeueStack.Any())
                {
                    while (_enqueueStack.Any())
                    {
                        _dequeueStack.Push(_enqueueStack.Pop());
                    }
                }
            }

            public bool IsEmpty() => !_dequeueStack.Any() && !_enqueueStack.Any();
        }
    }
}
