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
            char[] array = new char[255];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)random.Next(255);
            }
            array.Mix();
        }

        static char[] Mix(char[] array)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                // обменять значения data[j] и data[i]
                var temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }

    }
}
