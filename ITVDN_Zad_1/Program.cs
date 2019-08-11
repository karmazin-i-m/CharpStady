using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(5);

            Console.ReadKey();
        }

        static void Print(int ColumNumber)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            Console.CursorLeft = ColumNumber;
            Console.Write("asfasf");
        }
    }
}
