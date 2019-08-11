using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Class_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadWorker<int> threadWorker = new ThreadWorker<int>(Count<int>);

            Console.WriteLine("Проверка на работу внутренней задержки при неготовности: ");
            threadWorker.Start();
            Console.WriteLine(threadWorker.Result);

            Console.WriteLine("Проверка на работу внутренней задержки при готовности: ");
            threadWorker.Start();
            Thread.Sleep(1000);
            Console.WriteLine(threadWorker.Result);

            threadWorker = new ThreadWorker<int>(() => throw new DivideByZeroException());
            try
            {
                threadWorker.Start();
                Console.WriteLine(threadWorker.Result); 
            }
            catch(Exception)
            {
                Console.WriteLine("Попытка деления на нуль.");
            }

            Console.ReadKey();
        }

        

        static int Count<Tres>()
        {
            int res = 0;
            for (int i = 0; i < 1000; i++)
            {
                res += i;
            }
            return res;
        }
    }
}
