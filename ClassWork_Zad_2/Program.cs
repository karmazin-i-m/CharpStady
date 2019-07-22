using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_2
{
    class Program
    {
        delegate int MyDelegate(int num);
        static void Main(string[] args)
        {
            MyDelegate increment = Increment;
            MyDelegate decrement = Decrement;

            Console.Write("Введите число для операций: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine(increment(num));
            Console.WriteLine(decrement(num));

            Console.ReadKey();
        }

        static int Increment(int num)
        {
            return ++num;
        }

        static int Decrement(int num)
        {
            return --num;
        }
    }
}
