using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITVDN_DopZad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            Metod1();
        }

        static void Metod1()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread thread = new Thread(Metod2);
            thread.Start();
        }
        static void Metod2()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread thread = new Thread(Metod1);
            thread.Start();
        }
    }
}
