using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class InnerElementList<T> : IEnumerator<T>, IEnumerable<T>, IEnumerator
        where T : 
    {
        private const int defaultSize = 4;
        T[] items = ;
        private int position = -1;
        T current = default;

        public InnerElementList(int amount)
        {
            items = new T[amount];
            for (int i = 0; i < amount; i++)
            {
                items[i] = new T();
            }
        }

       object IEnumerator.Current => current;

        public T Current => current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            position++;
            if (position < items.Length)
            {
                this.current = items[position];
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class OuterElementList<T> : IEnumerator<T>, IEnumerable<T>, IEnumerator
    {
        private const int defaultSize = 4;
        T[] items = new T[defaultSize];

        private int position = -1;
        T current = default;

        object IEnumerator.Current => current;

        public T Current => current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            position++;
            if (position < items.Length)
            {
                this.current = items[position];
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
