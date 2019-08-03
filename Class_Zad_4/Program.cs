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

            List.Add("asfsddsh");
            List.Add("ы");
            List.Add("і");

            for (int i = 0; i < 5; i++)
            {
                List.Add(Console.ReadLine());
            }

            for (int i = 0; i < List.Count; i++)
            {
                Console.Write("Строка ");
                Console.Write(List[i]+" на ");
                if (IsLatin(List[i]) == true)
                {
                    Console.WriteLine("английском языке.");
                }
                else
                {
                    Console.WriteLine("русском языке.");
                }
            }

            Console.ReadKey();
        }

        static bool IsLatin(string str)
        {
            str.ToLower();
            char[] array = str.ToArray();

            return (array[0] <= '\x00ff');
        }
    }
}
