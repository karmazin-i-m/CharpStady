using System;
using System.Collections;

namespace ITVDN_Zad_4
{
    class ArrayList :IEnumerable, IEnumerator
    {
        private const int defaultSize = 4;

        object[] array = new object[defaultSize];
        
        private int count = 0;
        private int capacity = defaultSize;
        private object current;

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return array[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    array[index] = value;
                }
            }
        }
        public int Capacity { get => capacity; }

        public int Count { get => count; }

        public object Current { get => current; }

        private int position = -1;

        object IEnumerator.Current { get => Current; }

        public void Add(object item)
        {
            if (count < capacity)
            {
                array[count] = item;
                count++;
            }
            else
            {
                Resize(capacity * 2);
                Add(item);
            }

        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item)) return i;
            }
            return -1;
        }

        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[count] = default(object);
                count--;
                return true;
            }
            return false;
        }

        public bool Remove(object item)
        {
            return RemoveAt(IndexOf(item));
        }

        public void Resize(int newLength)
        {
            object[] newArray = new object[newLength];
            for (int i = 0; i < capacity; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            capacity = array.Length;
        }

        public override string ToString()
        {
            for (int i = 0; i < count; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 80));
                }
                Console.Write(array[i] + " | ");
            }
            return "";
        }

        public void Clear()
        {
            array = new object[defaultSize];
        }

        public bool Contains(object item)
        {
            throw new NotImplementedException();
        }

        public object[] ToArray()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return this;
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
                current = array[position];
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
    }
}
