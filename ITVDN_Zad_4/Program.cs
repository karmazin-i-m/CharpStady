using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork_Zad_1;

namespace ITVDN_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWork_Zad_1.List<int> list = new ClassWork_Zad_1.List<int>() { 1, 2, 3, 4, 5, 6, 7, 78, 9, 43, 14, 246, 8, 4, 4, 547346, 4, 346 };

            int[] array = list.GetArray<int>();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }

    static class Extentions
    {
        public static T[] GetArray<T> (this IEnumerable<T> list)
        {
            T[] items = new T[list.Count()];
            int counter = 0;
            foreach (var element in list)
            {
                items[counter] = element;
                counter++;
            }
            counter = 0;
            return items;
        }
    }
}
