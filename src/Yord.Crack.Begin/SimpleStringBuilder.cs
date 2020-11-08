using System;

namespace Yord.Crack.Begin
{
    public class SimpleStringBuilder
    {
        private char[] _buffer;
        private int _size;
        private const int _defaultCapacity = 32;

        public SimpleStringBuilder(int capacity)
        {
            _buffer = new char[capacity];
        }

        public SimpleStringBuilder() : this(_defaultCapacity)
        {
        }

        public void Append(string str)
        {
            var data = str.ToCharArray();
            if (_size + data.Length > _buffer.Length)
            {
                var newCapacity = _buffer.Length * 2;
                while (_size + data.Length > newCapacity)
                {
                    newCapacity *= 2;
                }

                var tmp = new char[newCapacity];
                Array.Copy(_buffer, 0, tmp, 0, _size);
                Array.Copy(data, 0, tmp, _size, data.Length);
                _buffer = tmp;
            }
            else
            {
                for (var i = 0; i < data.Length; i++)
                {
                    _buffer[_size + i] = data[i];
                }
            }

            _size += data.Length;
        }


        public void Clear()
        {
            _buffer = new char[_defaultCapacity];
            _size = 0;
        }

        public int Length => _size;

        public override string ToString()
        {
            var tmp = new char[_size];
            for (var i = 0; i < _size; i++)
            {
                tmp[i] = _buffer[i];
            }

            return new string(tmp);
        }
    }
}
