using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_1
{
    class Program
    {
        delegate void Del<T>(ref T arg1, ref T arg2);
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            string xString = "Один", yString = "Два";
            Del<int> del1 = Show;
            Del<int> del2 = Change;
            Del<int> res = del1 + del2 + del1;

            Del<string> delString_1 = Show;
            Del<string> delString_2 = Change;
            Del<string> resString = delString_1 + delString_2 + delString_1;

            res.Invoke(ref x, ref y);
            resString.Invoke(ref xString, ref yString);

            Console.ReadKey();
        }

        static void Change<T>(ref T a, ref T b)
        {
            T x;
            x = a;
            a = b;
            b = x;
        }

        static void Show<T>(ref T a, ref T b)
        {
            Console.WriteLine($"Значение первого аргумента = {a}, значение второго аргумента = {b}");
        }
    }
}
