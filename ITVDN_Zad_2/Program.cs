using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ITVDN_Zad_1;

namespace ITVDN_Zad_2
{

    using ITVDN_Zad_1;
    class Program
    {
        static int[] number = new int[120];
        static void Main(string[] args)
        {

            // Пример в целом такой же только вызываю генерацию цепочек еще 1 раз
            
            ITVDN_Zad_1.Matrix matrix = new Matrix();
            Console.SetBufferSize(121, 31);

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = i;
            }


            number.Mix();

            for (int i = 0; i < number.Length - 1; i++)
            {
                new Thread(() => {
                    matrix.Print(number[i]);
                }).Start();
            }

            Thread.Sleep(10000);

            for (int i = 0; i < number.Length - 1; i++)
            {
                new Thread(() => {
                    matrix.Print(number[i]);
                }).Start();
            }

            Console.ReadKey();
        }
    }
}
