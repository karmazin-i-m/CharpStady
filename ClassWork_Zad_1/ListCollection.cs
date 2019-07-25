using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    class ListCollection<T> : IList<T>
        where T : new()
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
                array[Count] = value;
            }
        }

        public int Count { get => count; }

        public int Capacity { get => capacity; }

        public void Add(T item)
        {
            if (count < array.Length)
            {
                array[Count] = item;
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
            int index = IndexOf(item);
            if (index == -1) return false;
            return true;
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

        public bool RemuveAt(int index)
        {
            if (!(index <= 0 && index >= Count)) return false;
            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
            return true;
        }
    }
}
