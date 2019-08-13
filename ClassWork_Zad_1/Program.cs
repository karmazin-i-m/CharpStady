using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            ShowDetails(list);

            Console.WriteLine("Содержит ли 5? " + list.Contains(5));
            Console.WriteLine("Под каким индексом 3? " + list.IndexOf(3));

            list.Insert(3, 999);
            ShowDetails(list);

            list.Remove(5);
            Console.WriteLine("Содержит ли 5? " + list.Contains(5));
            ShowDetails(list);

            list.RemoveAt(list.Count - 1);
            ShowDetails(list);



            Console.ReadKey();
        }

        static void ShowDetails<T>(IList<T> list)
        {
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('_',80));
        }
    }
}
