using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List = new List<string>();

            Console.WriteLine("Введите несколько строк на разных языках.");

            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                List.Add(Console.ReadLine());
            }

            Console.ReadKey();
        }

        static bool IsLatin(string str)
        {
            char[] array = str.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                //if(array[i])
            }
            return default;
        }
    }
}
