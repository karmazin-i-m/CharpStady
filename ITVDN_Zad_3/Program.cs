using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ITVDN_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> collection = new MyDictionary<int, string>();

            collection.Add(0, "Zero");
            collection.Add(1, "One");
            collection.Add(2, "Two");
            collection.Add(3, "Three");
            collection.Add(4, "Four");
            collection.Add(5, "Five");
            collection.Add(6, "Six");
            collection.Add(7, "Seven");
            collection.Add(8, "Eight");
            collection.Add(9, "Nine");

            foreach(var element in collection)
            {
                Console.WriteLine($"Key: {element.Key}| Value: {element.Value}");
            }
            Console.WriteLine(new string('-', 80));

            collection.Remove(7);

            foreach (var element in collection)
            {
                Console.WriteLine($"Key: {element.Key}| Value: {element.Value}");
            }

            collection.Insert(8,new KeyValuePair<int, string>(999, "Nine hungdred ninty nine"));

            foreach (var element in collection)
            {
                Console.WriteLine($"Key: {element.Key}| Value: {element.Value}");
            }

            Console.ReadKey();
        }
    }
}
