using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    public class List<T> : IList<T>, IEnumerable<T>, IEnumerator<T>
    {
        private const int defaultSize = 4;

        T[] items = new T[defaultSize];

        private IEnumerator<T> enumerator = null;
        private int count = 0;
        private int capacity = defaultSize;
        private T current;

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return items[index];
                }
                else
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    items[index] = value;
                }
                else
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
            }
        }
        public int Capacity { get => items.Length; }

        public int Count { get => count; }

        public T Current { get => current; }

        private int position = -1;

        public bool IsReadOnly => false;

        public IEnumerator<T> Enumerator { set => enumerator = value; }

        object IEnumerator.Current { get => Current; }

        public void Add(T item)
        {
            if (count < capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                capacity = Capacity * 2;
                Array.Resize(ref items, capacity);
                Add(item);
            }

        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item)) return i;
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index > count && index < 0)
                throw new ArgumentOutOfRangeException();

            Array.Copy(items, index + 1, items, index, items.Length - index - 1);
            count--;
        }

        public bool Remove(T item)
        {
            RemoveAt(IndexOf(item));
            return true;
        }

        public void Clear()
        {
            items = new T[defaultSize];
            count = 0;
        }

        public bool Contains(T item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }

        public T[] ToArray()
        {
            T[] newArray = new T[count];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[i];
            }

            return newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return enumerator != null ? enumerator : this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            position++;
            if (position < Count)
            {
                current = items[position];
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public void Insert(int index, T item)
        {
            if (index > count && index < 0)
                throw new ArgumentOutOfRangeException();
            if (count == capacity)
            {
                capacity = Capacity * 2;
                Array.Resize(ref items, capacity);
            }
            Array.Copy(items, index, items, index + 1, Count - index + 1);
            this[index] = item;
            count++;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(items, 0, array, arrayIndex, items.Length);
        }
    }
}
