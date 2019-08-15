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
            Console.Write("Введите символ для проверки: ");
            char sign = Console.ReadKey(false).KeyChar;
            Console.WriteLine();

            if (sign < (char)33 && sign > (char)126 || sign < (char)122 && sign > (char)255)
            {
                throw new Exception("Вы ввели не русский, или латинский символ!");
            }

            Console.WriteLine(sign);

            Console.ReadKey();
        }
    }
}
