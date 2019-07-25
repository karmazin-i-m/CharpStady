using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");
            dictionary.Add(6, "Six");
            dictionary.Add(7, "Seven");
            dictionary.Add(8, "Eight");

            Console.WriteLine(dictionary);

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary[i]); 
            }

            Console.ReadKey();
        }
    }
}
