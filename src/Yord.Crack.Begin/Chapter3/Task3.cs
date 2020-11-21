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
        // PERFECT
        // код приятнее, чем мой. + оптимизация за счет двусвязности и знания последней ноды в стеке
        public class SetOfStacks<T>
        {
            private List<InnerStack> _stacks;

            private readonly int MaxSize;

            public SetOfStacks(int maxSize)
            {
                MaxSize = maxSize;
                _stacks = new List<InnerStack>();
            }

            //пушим в последний стек. если он заполнен то создаем новый, пушим в него и кладем в список стеков
            public void Push(T value)
            {
                var lastStack = _stacks.LastOrDefault();
                if (lastStack != null && !lastStack.IsFull)
                {
                    lastStack.Push(value);
                }
                else
                {
                    var newStack = new InnerStack(MaxSize);
                    newStack.Push(value);
                    _stacks.Add(newStack);
                }
            }

            // достаем из последнего стека
            //если он опустел, то удаляем его из списка стеков
            public T Pop()
            {
                var lastStack = _stacks.LastOrDefault();
                if (lastStack == null) throw new IndexOutOfRangeException();
                var value = lastStack.Pop();
                if (lastStack.IsEmpty)
                {
                    _stacks.RemoveAt(_stacks.Count - 1);
                }

                return value;
            }

            public T PopAt(int index)
            {
                return LeftShift(index, true);
            }

            public T PeekAt(int stackNumber)
            {
                return _stacks[stackNumber]._top._value;
            }

            public int NumberOfStacks => _stacks.Count;


            // возвращает удаленную ноду
            // если это самый верхний LeftShift(), то это Pop() нужно удалить верхнюю ноду, которую извлекли
            private T LeftShift(int index, bool removeTop = false)
            {
                var stack = _stacks[index];
                // если это не верхний LeftShift, то это не Pop, и нужно удалить низ текущего стека
                // потому что ниже в него Push() вытащенный из следующего стека низ
                var removedValue = removeTop ? stack.Pop() : stack.RemoveBottom();
                if (stack.IsEmpty)
                {
                    _stacks.RemoveAt(index);
                }
                else
                {
                    //если это не последний стек, то необходимо двигать дальше
                    if (_stacks.Count > index + 1)
                    {
                        var v = LeftShift(index + 1);
                        stack.Push(v);
                    }
                }

                return removedValue;
            }

            private class InnerStack
            {
                private int _maxSize;
                public StackNode _top;
                public StackNode _bottom;
                public int _size;

                public InnerStack(int maxSize)
                {
                    _maxSize = maxSize;
                }

                public bool IsFull => _size == _maxSize;

                public bool IsEmpty => _size == 0;

                public void Push(T value)
                {
                    _size++;
                    var newNode = new StackNode(value);
                    if (_size == 1)
                    {
                        _bottom = newNode;
                    }
                    else
                    {
                        newNode._next = _top;
                        _top._previous = newNode;
                    }

                    _top = newNode;
                }

                public T Pop()
                {
                    var value = _top._value;
                    _top = _top._next;
                    if (_top != null)
                    {
                        _top._previous = null;
                    }
                    _size--;
                    return value;
                }

                //удаляет нижнюю ноду стека и возвращает удаленное значение
                public T RemoveBottom()
                {
                    var removedItem = _bottom._value;
                    _bottom = _bottom._previous;
                    if (_bottom != null)
                    {
                        // у последней ноды не должно быть следующей
                        _bottom._next = null;
                    }

                    _size--;
                    return removedItem;
                }
            }

            private class StackNode
            {
                public StackNode _next;
                public StackNode _previous;
                public T _value;

                public StackNode(T value, StackNode next = null)
                {
                    _value = value;
                    _next = next;
                }
            }
        }

        public class SetOfStacks2<T>
        {
            private readonly int MaxSize;
            private List<InnerStack> _stacks;

            public int NumberOfStacks => _stacks.Count;

            public SetOfStacks2(int maxSize)
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
