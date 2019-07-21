using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер цвета: ");
            int color = Int32.Parse(Console.ReadLine());
            Console.Write("Введите строку для вывода: ");
            Priter.Print(Console.ReadLine(),color);

            Console.ReadKey();
        }
    }

    static class Priter
    {
        public static void Print(string @string, int color)
        {
            if (color <0 || color > 15)
            {
                Console.WriteLine("Такого цвета не существует");
                return;
            }
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(@string);

        }
    }
}
