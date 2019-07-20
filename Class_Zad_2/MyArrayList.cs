using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_2
{
    class MyArrayList
    {
        private object[] array = new object[4];
        private int Lenght = 0;
        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public int Lenghts
        {
            get
            {
                return Lenght;
            }
        }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < Lenght)
                    return array[index];
                return null;
            }

        }

        public void Add(object value)
        {
            if (Lenght < array.Length)
            {
                array[Lenght] = value;
                Lenght++;
            }
            else
            {
                Resize(array.Length * 2);
            }
        }

        private void Resize(int newLength)
        {
            object[] newArray = new object[newLength];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}
