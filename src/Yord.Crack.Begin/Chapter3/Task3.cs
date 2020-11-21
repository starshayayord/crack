using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter3
{
    // реализовать SetOfStacks, состоящую из нескольких стеков.
    // Новый стек создается, когда пердыдущий переполнился достиг порогового значения кол-ва элементов)
    // Дополнительно реализовать функцию PopAt(int stackNumber)
    public class Task3
    {
        public class SetOfStacks<T>
        {
            private readonly int MaxSize;
            private List<InnerStack> _stacks;

            public int NumberOfStacks => _stacks.Count;

            public SetOfStacks(int maxSize)
            {
                MaxSize = maxSize;
                _stacks = new List<InnerStack>();
            }

            public void Push(T value)
            {
                var currentStack = _stacks.LastOrDefault();
                //самая первая нода или переполнение на текущем стеке
                if (currentStack == null || currentStack._size + 1 > MaxSize)
                {
                    _stacks.Add(new InnerStack
                    {
                        _size = 1,
                        _top = new StackNode(value)
                    });
                }
                else
                {
                    //не первая нода, нет переполнения
                    var newNode = new StackNode(value, currentStack._top);
                    currentStack._top = newNode;
                    currentStack._size++;
                }
            }

            public T Pop()
            {
                var lastStack = _stacks.LastOrDefault();
                if (lastStack == null) throw new IndexOutOfRangeException();
                var value = lastStack._top._value;
                //удаляем НЕ последнюю ноду
                if (lastStack._size - 1 != 0)
                {
                    lastStack._top = lastStack._top._next;
                    lastStack._size--;
                }
                else
                {
                    _stacks.RemoveAt(_stacks.Count - 1);
                }

                return value;
            }

            public T PeekAt(int stackNumber)
            {
                return _stacks[stackNumber]._top._value;
            }

            public T PopAt(int stackNumber)
            {
                if (_stacks.Count < stackNumber + 1) throw new IndexOutOfRangeException();
                var currentStack = _stacks[stackNumber];
                var value = currentStack._top._value;
                //последний элемент с стеке, просто удаляем стек
                if (currentStack._size == 0)
                {
                    _stacks.RemoveAt(stackNumber);
                }
                // не последний элемент. необходимо сдвинуть последующие стеки
                else
                {
                    // pop() из текущего стека
                    currentStack._top = currentStack._top._next;
                    currentStack._size--;
                    // от текущего до предпоследнего стека (последний модифицируется время операции с предпоследним)
                    for (var i = stackNumber; i < _stacks.Count - 1; i++)
                    {
                        //это последняя нода в следующем стеке: переносим ее в текущий и удаляем следющий стек
                        if (_stacks[i + 1]._size == 1)
                        {
                            _stacks[i]._top = new StackNode(_stacks[i + 1]._top._value, _stacks[i]._top);
                            _stacks.RemoveAt(_stacks.Count - 1);
                        }
                        //не последняя нода в следующем стеке
                        //заменяем топ текущего на низ следующего и удаляем низ следующего
                        else
                        {
                            var removedValue = RemoveBottom(_stacks[i + 1]);
                            _stacks[i]._top = new StackNode(removedValue, _stacks[i]._top);
                        }

                        _stacks[i]._size++;
                    }
                }

                return value;
            }

            private T RemoveBottom(InnerStack stack)
            {
                var n = stack._top._next; // до нижней
                var prev = stack._top; // до предпоследней
                while (n._next != null)
                {
                    prev = n;
                    n = n._next;
                }

                //удаляем нижнюю ноду и уменьшаем размер стека
                prev._next = null;
                stack._size--;
                return n._value;
            }

            private class InnerStack
            {
                public StackNode _top;
                public int _size;
            }

            private class StackNode
            {
                public StackNode _next;
                public T _value;

                public StackNode(T value, StackNode next = null)
                {
                    _value = value;
                    _next = next;
                }
            }
        }
    }
}
