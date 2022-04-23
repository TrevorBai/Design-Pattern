using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private readonly MenuItem[] _items;
        private int _position = -1;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public MenuItem Current { get
            {
                try
                {
                    return _items[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        // .NET doesn't support for Remove method
        public void Remove()
        {
            throw new NotSupportedException("You shouldn't be trying to remove menu items.");
        }
    }
}
