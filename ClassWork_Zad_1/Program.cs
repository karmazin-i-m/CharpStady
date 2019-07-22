using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    class Program
    {
        delegate void MyDelegate();
        static void Main(string[] args)
        {
            MyDelegate my1 = show1;
            MyDelegate my2 = show2;
            MyDelegate my3 = show3;
            MyDelegate my4 = show4;
            MyDelegate my5 = show5;

            MyDelegate result = my1 + my2 + my3 + my4 + my5;

            result.Invoke();

            result = my1 + my5 + my3 + my2;

            result.Invoke();

            Console.ReadKey();
        }

        static void show1()
        {
            Console.Write("Здравствуйте ");
        }
        static void show2()
        {
            Console.WriteLine("уважаемые господа.");
        }
        static void show3()
        {
            Console.Write("Сегодня мы ");
        }
        static void show4()
        {
            Console.Write("изучим ");
        }
        static void show5()
        {
            Console.WriteLine("делегаты.");
        }
    }
}
