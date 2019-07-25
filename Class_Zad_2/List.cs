using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_2
{
    class List<T> : IList<T>
    {
        private const int defaultSize = 4;

        T[] array = new T[defaultSize];

        private int count = 0;
        private int capacity = defaultSize;

        T this[int index]
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

        public void Add(T item)
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

        public int IndexOf(T item)
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
                array[count] = default(T);
                count--;
                return true;
            }
            return false;
        }

        public bool Remove(T item)
        {
            return RemoveAt(IndexOf(item));
        }

        public void Resize(int newLength)
        {
            T[] newArray = new T[newLength];
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
    }
}
