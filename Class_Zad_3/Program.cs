using System;
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
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("apple", "яблоко");
            dictionary.Add("struvberry", "клубника");
            dictionary.Add("watermelow", "арбуз");

            while (true)
            {
                Console.Write("Введите название для проверки: ");
                string a = Console.ReadLine();
                if (SearchForDictionary<string, string, string>(dictionary, a.ToLower()))
                {
                    Console.WriteLine("Такой элемент есть");
                }
                else if (a.ToLower() == "exit")
                {
                    Console.WriteLine("Выхожу...");
                    System.Threading.Thread.Sleep(2000);
                    return;
                }
                else Console.WriteLine("Такого элемента нет в базе.");
            }
        }

        static bool SearchForDictionary<TKey, TValue, TItem>(Dictionary<TKey, TValue> dictionary, TItem item)
        {
            for (int i = 0; i < dictionary.Count; i++)
            {
                if(item is TKey)
                {
                    if (dictionary.Keys.ToArray()[i].Equals(item)) return true;
                }
                if(item is TValue)
                {
                    if (dictionary.Values.ToArray()[i].Equals(item)) return true;
                }
            }
            return false;
        }
    }
}
