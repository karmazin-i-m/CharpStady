using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    class ListCollection<T> : IList<T>
    {
        private const int defaultSizeArray = 4;

        private T[] array = new T[defaultSizeArray];
        private int count = 0;
        private int capacity = defaultSizeArray;


        public T this[int index]
        {
            get
            {
                if (index <= 0 && index >= Count) return default(T);
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public int Count { get => count; }

        public int Capacity { get => capacity; }

        public void Add(T item)
        {
            if (count < array.Length)
            {
                array[Count] = item;
                count++;
            }
            else
            {
                Resize(array.Length * 2);
                Add(item);
            }
        }

        public void Clear()
        {
            array = new T[defaultSizeArray];
            count = 0;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(T item)
        {
            return RemoveAt(IndexOf(item));
        }

        public void Resize(int capacity)
        {
            T[] newArray = new T[capacity];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public T[] ToArray()
        {
            T[] newArray = new T[count];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[count] = default(T);
                count--;
                return true;
            }
            return false;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]); 
            }
            return "";
        }
    }
}
