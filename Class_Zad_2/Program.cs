using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList myArrayList = new MyArrayList();

            myArrayList.Add("Sing");
            myArrayList.Add(5);
            myArrayList.Add(DateTime.Now);

            for (int i = 0; i < myArrayList.Lenghts; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.ReadKey();
        }
    }
}
