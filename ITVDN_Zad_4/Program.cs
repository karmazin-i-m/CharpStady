using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITVDN_Zad_2;


namespace ITVDN_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ITVDN_Zad_2.List<int> list = new ITVDN_Zad_2.List<int>();
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 100));
            }
            Console.WriteLine(list);

            int[] array = list.GetArray<int>();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

    }

    static class Extension
    {
        public static T[] GetArray<T>(this ITVDN_Zad_2.List<T> list)
        {
            T[] newArray = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                newArray[i] = list[i];
            }
            return newArray;
        }
    }
}
