using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Class_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadWorker<int> threadWorker = new ThreadWorker<int>(Count<int>);

            threadWorker.Start();
            System.Console.WriteLine(threadWorker.Result);

            threadWorker.Start();
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine(threadWorker.Result);

            try
            {
                ThreadWorker<int> thread = new ThreadWorker<int>(() => {
                    int res = 0;
                    return 24/res;
                    });
                System.Console.WriteLine(thread.Result);
            }catch(System.DivideByZeroException e)
            {
                System.Console.WriteLine("Попытка деления на нуль.");
            }

            System.Console.ReadKey();
        }

        

        static int Count<Tres>()
        {
            int res = 0;
            for (int i = 0; i < 100; i++)
            {
                res += i;
            }
            return res;
        }
    }
}
