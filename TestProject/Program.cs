using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            const double PI = 3.14;

            Console.WriteLine(Math.Sqrt(y));
            Console.WriteLine(Math.Pow(3,y));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);

            double c = x * Math.PI;
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
