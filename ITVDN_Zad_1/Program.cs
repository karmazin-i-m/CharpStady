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
        static char[] array = new char[255];
        static object loker = new object();

        static void Main(string[] args)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)random.Next(127);
            }

            for (int i = 0; i < 80; i++)
            {
                Thread thread = new Thread(() => Print(i));
                thread.Start();
            }

            Console.ReadKey();
        }

        static void Print(int ColumNumber)
        {
            array.Mix();

            lock (loker) { 
            for (int i = 0; i < 5; i++)
            {
                Console.CursorLeft = ColumNumber;
                Console.WriteLine(array[i]);
            }
            Console.CursorTop = 0;
            }
        }
    }

    static class Extention
    {
        public static void Mix(this char[] array)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
