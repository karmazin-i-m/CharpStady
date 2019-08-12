using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITVDN_Zad_1
{
    class Program
    {
        static Random random = new Random((int)DateTime.Now.Ticks);

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Console.SetBufferSize(120, 30);

            for (int i = 0; i < 30; i++)
            {
                new Thread(() => {
                        matrix.Print(i*2);
                }).Start();
            }


            Console.ReadKey();
        }
    }
}
