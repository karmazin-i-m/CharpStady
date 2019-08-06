using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string, string> dictionary = new MyDictionary<int, string, string>();

            dictionary.Add(1, "One_1", "One_2");
            dictionary.Add(2,"Two_1","Two_2");
            dictionary.Add(3,"Three_1", "Three_2");
            dictionary.Add(4, "Four_1", "Four_2");
            dictionary.Add(5, "Five_1", "Five_2");

            Console.WriteLine(dictionary);

            dictionary.Remuve(3);
            dictionary.Remuve(4);

            Console.WriteLine(dictionary);

            Console.ReadKey();
        }
    }
}
